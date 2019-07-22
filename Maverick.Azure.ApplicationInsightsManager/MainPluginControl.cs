using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using XrmToolBox.Extensibility.Interfaces;
using Maverick.Azure.ApplicationInsightsManager.Helper;
using Microsoft.Xrm.Sdk.Metadata;
using Maverick.Azure.ApplicationInsightsManager.SealedClasses;
using System.Collections.ObjectModel;
using Microsoft.Xrm.Sdk.Messages;

namespace Maverick.Azure.ApplicationInsightsManager
{
    public partial class MainPluginControl : PluginControlBase, IGitHubPlugin, IHelpPlugin
    {
        #region Enums
        private enum WebResourceOption
        {
            Create,
            UseExisting
        }

        #endregion

        #region Private Variables
        private Settings mySettings;
        private BindingSource bindingSource = new BindingSource();
        private WebResourceOption selection;
        #endregion

        #region Public Variables
        public string RepositoryName => "";
        public string UserName => "Danz-maveRICK";
        public string HelpUrl => "";
        public string RepositoryUrl => "https://github.com/Danz-maveRICK/PCF-CustomControlBuilder/";
        #endregion

        #region Cache Variables

        private EntityCollection _solutionsCache;
        private List<Entity> _formsCache;
        private List<DataGridViewListItem> _formsDataGridViewCache;

        #endregion

        #region Custom Functions

        private void LoadSolutions()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Solutions...",
                Work = (worker, args) =>
                {
                    args.Result = MetadataHelper.RetrieveSolutions(Service);

                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var result = args.Result as EntityCollection;
                        if (result != null && result.Entities != null)
                        {
                            _solutionsCache = result;

                            var solutionListQuery = from entity in _solutionsCache.Entities
                                                    select (new ComboListItem
                                                    {
                                                        DisplayText = entity.GetAttributeValue<string>("friendlyname"),
                                                        MetaData = entity
                                                    });

                            var solutionList = solutionListQuery.ToList();
                            //solutionList.Add(new ComboListItem { DisplayText = "---Select---", MetaData = null });
                            solutionList.Sort((x, y) => string.Compare(x.DisplayText, y.DisplayText, StringComparison.Ordinal));
                            cboxSolutions.DisplayMember = "DisplayText";
                            cboxSolutions.DataSource = solutionList;
                            cboxSolutions.DroppedDown = true;
                        }
                    }

                }
            });
        }

        private void LoadForms()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Forms...",
                Work = (w, e) =>
                {
                    e.Result = MetadataHelper.GetAllForms(Service);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        _formsCache = (List<Entity>)args.Result;

                        var formListQuery = from entity in _formsCache
                                            select (new DataGridViewListItem()
                                            {
                                                FormId = entity.Id,
                                                FormName = entity.GetAttributeValue<string>("name"),
                                                FormType = entity.FormattedValues["type"],
                                                EntityName = entity.FormattedValues["objecttypecode"]
                                            });
                        _formsDataGridViewCache = formListQuery.OrderBy(o => o.EntityName).ToList();

                        bindingSource.DataSource = _formsDataGridViewCache;
                        dgvForms.DataSource = bindingSource;
                    }
                }
            });
        }

        private void CreateAndAddWebResourceToForms()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Creating Web Resource...",
                Work = (w, e) =>
                {
                    ComboListItem selectedSolution = (ComboListItem)cboxSolutions.SelectedItem;
                    var solutionUniqueName = selectedSolution.MetaData.GetAttributeValue<string>("uniquename");

                    e.Result = MetadataHelper.CreateWebResource(Service, solutionUniqueName, txtCreateWrDisplayName.Text, txtCreateWrSchemaName.Text, lblCreateSolutionPrefix.Text, txtInstrumentationKey.Text, RepositoryUrl);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var result = args.Result as CreateResponse;
                        if (result != null)
                        {
                            AddWebResourceToForms();
                        }
                    }
                }
            });
        }

        private void AddWebResourceToForms()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Adding Application Insights Web Resources to Forms...",
                Work = (w, e) =>
                {
                    // Get checked rows
                    var checkedRows = from DataGridViewRow r in dgvForms.Rows
                                      where Convert.ToBoolean(r.Cells[0].Value) == true
                                      select r;

                    // Add web resource to checked rows
                    foreach (var row in checkedRows)
                    {
                        //TODO
                        var formId = (Guid)row.Cells["FormId"].Value;
                        var formEntity = _formsCache.FirstOrDefault(f => f.Id == formId);

                        var formXml = formEntity.GetAttributeValue<string>("formxml");

                        MetadataHelper.AddJavascriptLibraryToForm(Service, formId, formXml, txtCreateWrSchemaName.Text, lblCreateSolutionPrefix.Text);
                    }
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        PublishChanges();
                    }
                }
            });
        }

        private void PublishChanges()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Publishing Changes...",
                Work = (w, e) =>
                {
                    MetadataHelper.PublishSystemForm(Service);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                    }
                }
            });
        }

        private bool ValidateSubmission()
        {
            bool isValid = false;

            if (selection == WebResourceOption.Create)
            {
                // Required textboxes contains data
                isValid = (!string.IsNullOrEmpty(txtCreateWrDisplayName.Text)
                            && !string.IsNullOrEmpty(txtCreateWrSchemaName.Text)
                            && !string.IsNullOrEmpty(txtInstrumentationKey.Text));

            }
            else if (selection == WebResourceOption.UseExisting)
            {
                // Required data is populated
                isValid = (cmbExistingWebResource.SelectedIndex != -1
                            && !string.IsNullOrEmpty(txtInstrumentationKey.Text));
            }

            return isValid;
        }

        #endregion

        public MainPluginControl()
        {
            InitializeComponent();
        }

        private void MainPluginControl_Load(object sender, EventArgs e)
        {
            //ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void TsbLoadSolutions_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadSolutions);
        }

        private void CboxSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboListItem selectedSolution = (ComboListItem)cboxSolutions.SelectedItem;

            lblCreateSolutionPrefix.Text = (selectedSolution.MetaData.GetAttributeValue<AliasedValue>("pub.customizationprefix")).Value.ToString() + "_";

            btnCreateWebResource.Enabled = true;
            btnUseExistingWebResource.Enabled = true;
            cboxFilterBy.SelectedIndex = 0;
        }

        private void BtnCreateWebResource_Click(object sender, EventArgs e)
        {
            gboxCreate.Visible = true;
            gboxUseExisting.Visible = false;
            pnlEntitiesSelection.Visible = true;
            selection = WebResourceOption.Create;

            ExecuteMethod(LoadForms);
        }

        private void BtnUseExistingWebResource_Click(object sender, EventArgs e)
        {
            gboxCreate.Visible = false;
            gboxUseExisting.Visible = true;
            pnlEntitiesSelection.Visible = true;
            selection = WebResourceOption.Create;

            //TODO - populate the existing web resource list

            ExecuteMethod(LoadForms);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                bindingSource.DataSource = _formsDataGridViewCache.Where(a => a.EntityName.ToLower().Contains(txtSearch.Text.ToLower()) || a.FormName.ToLower().Contains(txtSearch.Text.ToLower()));
                dgvForms.DataSource = bindingSource;
            }
        }

        private void CboxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboxFilterBy.SelectedIndex)
            {
                case 0:
                    bindingSource.DataSource = _formsDataGridViewCache.Where(a => a.FormType.ToLower().Contains("main"));
                    dgvForms.DataSource = bindingSource;
                    break;
                case 1:
                    bindingSource.DataSource = _formsDataGridViewCache.Where(a => a.FormType.ToLower().Contains("quick create"));
                    dgvForms.DataSource = bindingSource;
                    break;
                default:
                    break;
            }
        }

        private void BtnApplyPublish_Click(object sender, EventArgs e)
        {
            if (ValidateSubmission())
            {
                if (selection == WebResourceOption.Create)
                {
                    // Create a Web Resource and add it to the solution
                    ExecuteMethod(CreateAndAddWebResourceToForms);

                }
                else if (selection == WebResourceOption.UseExisting)
                {

                }
            }
            else
            {
                MessageBox.Show("Please populated the required data/components", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}