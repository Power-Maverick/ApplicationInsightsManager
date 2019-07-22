namespace Maverick.Azure.ApplicationInsightsManager
{
    partial class MainPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPluginControl));
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadSolutions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.gboxSolutionManagement = new System.Windows.Forms.GroupBox();
            this.gboxCreate = new System.Windows.Forms.GroupBox();
            this.txtCreateWrSchemaName = new System.Windows.Forms.TextBox();
            this.lblCreateSolutionPrefix = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxUseExisting = new System.Windows.Forms.GroupBox();
            this.cmbExistingWebResource = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUseExistingWebResource = new System.Windows.Forms.Button();
            this.btnCreateWebResource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxSolutions = new System.Windows.Forms.ComboBox();
            this.dgvForms = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxFilterBy = new System.Windows.Forms.ComboBox();
            this.pnlEntitiesSelection = new System.Windows.Forms.Panel();
            this.gboxExistingAppInsights = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colEntity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFormName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWebResourceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnApplyPublish = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FormId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCreateWrDisplayName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInstrumentationKey = new System.Windows.Forms.TextBox();
            this.toolStripMenu.SuspendLayout();
            this.gboxSolutionManagement.SuspendLayout();
            this.gboxCreate.SuspendLayout();
            this.gboxUseExisting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).BeginInit();
            this.pnlEntitiesSelection.SuspendLayout();
            this.gboxExistingAppInsights.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(24, 24);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbLoadSolutions
            // 
            this.tsbLoadSolutions.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadSolutions.Image")));
            this.tsbLoadSolutions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbLoadSolutions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadSolutions.Name = "tsbLoadSolutions";
            this.tsbLoadSolutions.Size = new System.Drawing.Size(109, 24);
            this.tsbLoadSolutions.Text = "Load Solutions";
            this.tsbLoadSolutions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbLoadSolutions.Click += new System.EventHandler(this.TsbLoadSolutions_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbLoadSolutions,
            this.toolStripSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1096, 27);
            this.toolStripMenu.Stretch = true;
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // gboxSolutionManagement
            // 
            this.gboxSolutionManagement.Controls.Add(this.txtInstrumentationKey);
            this.gboxSolutionManagement.Controls.Add(this.label2);
            this.gboxSolutionManagement.Controls.Add(this.btnUseExistingWebResource);
            this.gboxSolutionManagement.Controls.Add(this.btnCreateWebResource);
            this.gboxSolutionManagement.Controls.Add(this.label1);
            this.gboxSolutionManagement.Controls.Add(this.cboxSolutions);
            this.gboxSolutionManagement.Controls.Add(this.gboxCreate);
            this.gboxSolutionManagement.Controls.Add(this.gboxUseExisting);
            this.gboxSolutionManagement.Location = new System.Drawing.Point(3, 30);
            this.gboxSolutionManagement.Name = "gboxSolutionManagement";
            this.gboxSolutionManagement.Size = new System.Drawing.Size(1090, 109);
            this.gboxSolutionManagement.TabIndex = 5;
            this.gboxSolutionManagement.TabStop = false;
            // 
            // gboxCreate
            // 
            this.gboxCreate.Controls.Add(this.txtCreateWrDisplayName);
            this.gboxCreate.Controls.Add(this.label3);
            this.gboxCreate.Controls.Add(this.txtCreateWrSchemaName);
            this.gboxCreate.Controls.Add(this.lblCreateSolutionPrefix);
            this.gboxCreate.Controls.Add(this.label5);
            this.gboxCreate.Location = new System.Drawing.Point(478, 17);
            this.gboxCreate.Name = "gboxCreate";
            this.gboxCreate.Size = new System.Drawing.Size(441, 82);
            this.gboxCreate.TabIndex = 5;
            this.gboxCreate.TabStop = false;
            this.gboxCreate.Text = "Create";
            this.gboxCreate.Visible = false;
            // 
            // txtCreateWrSchemaName
            // 
            this.txtCreateWrSchemaName.Location = new System.Drawing.Point(132, 23);
            this.txtCreateWrSchemaName.Name = "txtCreateWrSchemaName";
            this.txtCreateWrSchemaName.Size = new System.Drawing.Size(181, 20);
            this.txtCreateWrSchemaName.TabIndex = 2;
            // 
            // lblCreateSolutionPrefix
            // 
            this.lblCreateSolutionPrefix.AutoSize = true;
            this.lblCreateSolutionPrefix.Location = new System.Drawing.Point(93, 26);
            this.lblCreateSolutionPrefix.Name = "lblCreateSolutionPrefix";
            this.lblCreateSolutionPrefix.Size = new System.Drawing.Size(0, 13);
            this.lblCreateSolutionPrefix.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Schema Name:";
            // 
            // gboxUseExisting
            // 
            this.gboxUseExisting.Controls.Add(this.cmbExistingWebResource);
            this.gboxUseExisting.Controls.Add(this.label6);
            this.gboxUseExisting.Location = new System.Drawing.Point(478, 17);
            this.gboxUseExisting.Name = "gboxUseExisting";
            this.gboxUseExisting.Size = new System.Drawing.Size(441, 82);
            this.gboxUseExisting.TabIndex = 6;
            this.gboxUseExisting.TabStop = false;
            this.gboxUseExisting.Text = "Use Existing";
            this.gboxUseExisting.Visible = false;
            // 
            // cmbExistingWebResource
            // 
            this.cmbExistingWebResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExistingWebResource.FormattingEnabled = true;
            this.cmbExistingWebResource.Location = new System.Drawing.Point(97, 31);
            this.cmbExistingWebResource.Name = "cmbExistingWebResource";
            this.cmbExistingWebResource.Size = new System.Drawing.Size(338, 21);
            this.cmbExistingWebResource.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Web Resource :";
            // 
            // btnUseExistingWebResource
            // 
            this.btnUseExistingWebResource.Enabled = false;
            this.btnUseExistingWebResource.Location = new System.Drawing.Point(241, 46);
            this.btnUseExistingWebResource.Name = "btnUseExistingWebResource";
            this.btnUseExistingWebResource.Size = new System.Drawing.Size(210, 23);
            this.btnUseExistingWebResource.TabIndex = 4;
            this.btnUseExistingWebResource.Text = "Use Existing App Insights Web Resource";
            this.btnUseExistingWebResource.UseVisualStyleBackColor = true;
            this.btnUseExistingWebResource.Click += new System.EventHandler(this.BtnUseExistingWebResource_Click);
            // 
            // btnCreateWebResource
            // 
            this.btnCreateWebResource.Enabled = false;
            this.btnCreateWebResource.Location = new System.Drawing.Point(10, 46);
            this.btnCreateWebResource.Name = "btnCreateWebResource";
            this.btnCreateWebResource.Size = new System.Drawing.Size(210, 23);
            this.btnCreateWebResource.TabIndex = 3;
            this.btnCreateWebResource.Text = "Create App Insights Web Resource";
            this.btnCreateWebResource.UseVisualStyleBackColor = true;
            this.btnCreateWebResource.Click += new System.EventHandler(this.BtnCreateWebResource_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your working solution";
            // 
            // cboxSolutions
            // 
            this.cboxSolutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSolutions.FormattingEnabled = true;
            this.cboxSolutions.Location = new System.Drawing.Point(152, 17);
            this.cboxSolutions.Name = "cboxSolutions";
            this.cboxSolutions.Size = new System.Drawing.Size(299, 21);
            this.cboxSolutions.TabIndex = 0;
            this.cboxSolutions.SelectedIndexChanged += new System.EventHandler(this.CboxSolutions_SelectedIndexChanged);
            // 
            // dgvForms
            // 
            this.dgvForms.AllowUserToAddRows = false;
            this.dgvForms.AllowUserToDeleteRows = false;
            this.dgvForms.AllowUserToResizeRows = false;
            this.dgvForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.FormId,
            this.EntityName,
            this.FormType,
            this.FormName});
            this.dgvForms.Location = new System.Drawing.Point(7, 34);
            this.dgvForms.Name = "dgvForms";
            this.dgvForms.RowHeadersVisible = false;
            this.dgvForms.Size = new System.Drawing.Size(550, 465);
            this.dgvForms.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(57, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(304, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Filter By:";
            // 
            // cboxFilterBy
            // 
            this.cboxFilterBy.FormattingEnabled = true;
            this.cboxFilterBy.Items.AddRange(new object[] {
            "All",
            "Form Type - Main",
            "Form Type - Quick Create"});
            this.cboxFilterBy.Location = new System.Drawing.Point(420, 7);
            this.cboxFilterBy.Name = "cboxFilterBy";
            this.cboxFilterBy.Size = new System.Drawing.Size(137, 21);
            this.cboxFilterBy.TabIndex = 10;
            this.cboxFilterBy.SelectedIndexChanged += new System.EventHandler(this.CboxFilterBy_SelectedIndexChanged);
            // 
            // pnlEntitiesSelection
            // 
            this.pnlEntitiesSelection.Controls.Add(this.gboxExistingAppInsights);
            this.pnlEntitiesSelection.Controls.Add(this.btnApplyPublish);
            this.pnlEntitiesSelection.Controls.Add(this.dgvForms);
            this.pnlEntitiesSelection.Controls.Add(this.cboxFilterBy);
            this.pnlEntitiesSelection.Controls.Add(this.label7);
            this.pnlEntitiesSelection.Controls.Add(this.label8);
            this.pnlEntitiesSelection.Controls.Add(this.txtSearch);
            this.pnlEntitiesSelection.Location = new System.Drawing.Point(3, 145);
            this.pnlEntitiesSelection.Name = "pnlEntitiesSelection";
            this.pnlEntitiesSelection.Size = new System.Drawing.Size(1090, 571);
            this.pnlEntitiesSelection.TabIndex = 11;
            this.pnlEntitiesSelection.Visible = false;
            // 
            // gboxExistingAppInsights
            // 
            this.gboxExistingAppInsights.Controls.Add(this.listView1);
            this.gboxExistingAppInsights.Location = new System.Drawing.Point(586, 10);
            this.gboxExistingAppInsights.Name = "gboxExistingAppInsights";
            this.gboxExistingAppInsights.Size = new System.Drawing.Size(501, 533);
            this.gboxExistingAppInsights.TabIndex = 12;
            this.gboxExistingAppInsights.TabStop = false;
            this.gboxExistingAppInsights.Text = "App Insights Web Resource Exists";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEntity,
            this.colFormName,
            this.colWebResourceName});
            this.listView1.Location = new System.Drawing.Point(6, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(489, 465);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // colEntity
            // 
            this.colEntity.Text = "Entity";
            // 
            // colFormName
            // 
            this.colFormName.Text = "Form Name";
            // 
            // colWebResourceName
            // 
            this.colWebResourceName.Text = "Web Resource Name";
            // 
            // btnApplyPublish
            // 
            this.btnApplyPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyPublish.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyPublish.Image")));
            this.btnApplyPublish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyPublish.Location = new System.Drawing.Point(7, 520);
            this.btnApplyPublish.Name = "btnApplyPublish";
            this.btnApplyPublish.Size = new System.Drawing.Size(151, 44);
            this.btnApplyPublish.TabIndex = 11;
            this.btnApplyPublish.Text = "Apply & Publish";
            this.btnApplyPublish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplyPublish.UseMnemonic = false;
            this.btnApplyPublish.UseVisualStyleBackColor = true;
            this.btnApplyPublish.Click += new System.EventHandler(this.BtnApplyPublish_Click);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Width = 50;
            // 
            // FormId
            // 
            this.FormId.DataPropertyName = "FormId";
            this.FormId.HeaderText = "FormId";
            this.FormId.Name = "FormId";
            this.FormId.Visible = false;
            // 
            // EntityName
            // 
            this.EntityName.DataPropertyName = "EntityName";
            this.EntityName.HeaderText = "EntityName";
            this.EntityName.Name = "EntityName";
            this.EntityName.Width = 150;
            // 
            // FormType
            // 
            this.FormType.DataPropertyName = "FormType";
            this.FormType.HeaderText = "FormType";
            this.FormType.Name = "FormType";
            // 
            // FormName
            // 
            this.FormName.DataPropertyName = "FormName";
            this.FormName.HeaderText = "FormName";
            this.FormName.Name = "FormName";
            this.FormName.Width = 200;
            // 
            // txtCreateWrDisplayName
            // 
            this.txtCreateWrDisplayName.Location = new System.Drawing.Point(93, 49);
            this.txtCreateWrDisplayName.Name = "txtCreateWrDisplayName";
            this.txtCreateWrDisplayName.Size = new System.Drawing.Size(220, 20);
            this.txtCreateWrDisplayName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Display Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Application Insights Instrumentation Key:";
            // 
            // txtInstrumentationKey
            // 
            this.txtInstrumentationKey.Location = new System.Drawing.Point(210, 79);
            this.txtInstrumentationKey.Name = "txtInstrumentationKey";
            this.txtInstrumentationKey.Size = new System.Drawing.Size(241, 20);
            this.txtInstrumentationKey.TabIndex = 8;
            // 
            // MainPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEntitiesSelection);
            this.Controls.Add(this.gboxSolutionManagement);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MainPluginControl";
            this.Size = new System.Drawing.Size(1096, 719);
            this.OnCloseTool += new System.EventHandler(this.MainPluginControl_OnCloseTool);
            this.Load += new System.EventHandler(this.MainPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gboxSolutionManagement.ResumeLayout(false);
            this.gboxSolutionManagement.PerformLayout();
            this.gboxCreate.ResumeLayout(false);
            this.gboxCreate.PerformLayout();
            this.gboxUseExisting.ResumeLayout(false);
            this.gboxUseExisting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).EndInit();
            this.pnlEntitiesSelection.ResumeLayout(false);
            this.pnlEntitiesSelection.PerformLayout();
            this.gboxExistingAppInsights.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLoadSolutions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.GroupBox gboxSolutionManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxSolutions;
        private System.Windows.Forms.Button btnCreateWebResource;
        private System.Windows.Forms.GroupBox gboxCreate;
        private System.Windows.Forms.Button btnUseExistingWebResource;
        private System.Windows.Forms.TextBox txtCreateWrSchemaName;
        private System.Windows.Forms.Label lblCreateSolutionPrefix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gboxUseExisting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbExistingWebResource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxFilterBy;
        private System.Windows.Forms.Panel pnlEntitiesSelection;
        private System.Windows.Forms.Button btnApplyPublish;
        private System.Windows.Forms.GroupBox gboxExistingAppInsights;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colEntity;
        private System.Windows.Forms.ColumnHeader colFormName;
        private System.Windows.Forms.ColumnHeader colWebResourceName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormName;
        private System.Windows.Forms.DataGridView dgvForms;
        private System.Windows.Forms.TextBox txtCreateWrDisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInstrumentationKey;
        private System.Windows.Forms.Label label2;
    }
}
