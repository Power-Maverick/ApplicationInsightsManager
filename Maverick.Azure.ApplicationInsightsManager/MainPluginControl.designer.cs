﻿namespace Maverick.Azure.ApplicationInsightsManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPluginControl));
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadSolutions = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.gboxSolutionManagement = new System.Windows.Forms.GroupBox();
            this.txtInstrumentationKey = new System.Windows.Forms.TextBox();
            this.lblInstrumentationKey = new System.Windows.Forms.Label();
            this.btnUseExistingWebResource = new System.Windows.Forms.Button();
            this.btnCreateWebResource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxSolutions = new System.Windows.Forms.ComboBox();
            this.gboxUseExisting = new System.Windows.Forms.GroupBox();
            this.cmbExistingWebResource = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gboxCreate = new System.Windows.Forms.GroupBox();
            this.txtCreateWrDisplayName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreateWrSchemaName = new System.Windows.Forms.TextBox();
            this.lblCreateSolutionPrefix = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvForms = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FormId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppInsightsExists = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxFilterBy = new System.Windows.Forms.ComboBox();
            this.pnlEntitiesSelection = new System.Windows.Forms.Panel();
            this.linklblSelectAll = new System.Windows.Forms.LinkLabel();
            this.gboxConfigs = new System.Windows.Forms.GroupBox();
            this.cboxPageSaveTime = new System.Windows.Forms.CheckBox();
            this.cboxEvents = new System.Windows.Forms.CheckBox();
            this.cboxDependency = new System.Windows.Forms.CheckBox();
            this.cboxMetrics = new System.Windows.Forms.CheckBox();
            this.cboxTrace = new System.Windows.Forms.CheckBox();
            this.cboxAjax = new System.Windows.Forms.CheckBox();
            this.cboxException = new System.Windows.Forms.CheckBox();
            this.cboxPageLoad = new System.Windows.Forms.CheckBox();
            this.cboxPageView = new System.Windows.Forms.CheckBox();
            this.btnApplyPublish = new System.Windows.Forms.Button();
            this.linklblCreator = new System.Windows.Forms.LinkLabel();
            this.gboxExamples = new System.Windows.Forms.GroupBox();
            this.btnCopyTraces = new System.Windows.Forms.Button();
            this.btnCopyDependencies = new System.Windows.Forms.Button();
            this.btnCopyException = new System.Windows.Forms.Button();
            this.btnCopyEvents = new System.Windows.Forms.Button();
            this.btnCopyMetric = new System.Windows.Forms.Button();
            this.lblDependencies = new System.Windows.Forms.Label();
            this.lblDependenciesLabel = new System.Windows.Forms.Label();
            this.lblExceptions = new System.Windows.Forms.Label();
            this.lblExceptionsLabel = new System.Windows.Forms.Label();
            this.lblTraces = new System.Windows.Forms.Label();
            this.lblTracesLabel = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblEventsLabel = new System.Windows.Forms.Label();
            this.lblMetrics = new System.Windows.Forms.Label();
            this.lblMetricsLabel = new System.Windows.Forms.Label();
            this.lblCopied = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenu.SuspendLayout();
            this.gboxSolutionManagement.SuspendLayout();
            this.gboxUseExisting.SuspendLayout();
            this.gboxCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).BeginInit();
            this.pnlEntitiesSelection.SuspendLayout();
            this.gboxConfigs.SuspendLayout();
            this.gboxExamples.SuspendLayout();
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
            // tssSeparator2
            // 
            this.tssSeparator2.Name = "tssSeparator2";
            this.tssSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbLoadSolutions,
            this.tssSeparator2,
            this.tsbReset,
            this.toolStripSeparator1,
            this.tsbHelp});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1068, 27);
            this.toolStripMenu.Stretch = true;
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbReset
            // 
            this.tsbReset.Image = ((System.Drawing.Image)(resources.GetObject("tsbReset.Image")));
            this.tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReset.Name = "tsbReset";
            this.tsbReset.Size = new System.Drawing.Size(59, 24);
            this.tsbReset.Text = "Reset";
            this.tsbReset.Click += new System.EventHandler(this.TsbReset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbHelp
            // 
            this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(56, 24);
            this.tsbHelp.Text = "Help";
            this.tsbHelp.Click += new System.EventHandler(this.TsbHelp_Click);
            // 
            // gboxSolutionManagement
            // 
            this.gboxSolutionManagement.Controls.Add(this.txtInstrumentationKey);
            this.gboxSolutionManagement.Controls.Add(this.lblInstrumentationKey);
            this.gboxSolutionManagement.Controls.Add(this.btnUseExistingWebResource);
            this.gboxSolutionManagement.Controls.Add(this.btnCreateWebResource);
            this.gboxSolutionManagement.Controls.Add(this.label1);
            this.gboxSolutionManagement.Controls.Add(this.cboxSolutions);
            this.gboxSolutionManagement.Controls.Add(this.gboxUseExisting);
            this.gboxSolutionManagement.Controls.Add(this.gboxCreate);
            this.gboxSolutionManagement.Location = new System.Drawing.Point(3, 30);
            this.gboxSolutionManagement.Name = "gboxSolutionManagement";
            this.gboxSolutionManagement.Size = new System.Drawing.Size(827, 109);
            this.gboxSolutionManagement.TabIndex = 5;
            this.gboxSolutionManagement.TabStop = false;
            // 
            // txtInstrumentationKey
            // 
            this.txtInstrumentationKey.Location = new System.Drawing.Point(210, 79);
            this.txtInstrumentationKey.Name = "txtInstrumentationKey";
            this.txtInstrumentationKey.Size = new System.Drawing.Size(241, 20);
            this.txtInstrumentationKey.TabIndex = 8;
            // 
            // lblInstrumentationKey
            // 
            this.lblInstrumentationKey.AutoSize = true;
            this.lblInstrumentationKey.Location = new System.Drawing.Point(7, 82);
            this.lblInstrumentationKey.Name = "lblInstrumentationKey";
            this.lblInstrumentationKey.Size = new System.Drawing.Size(197, 13);
            this.lblInstrumentationKey.TabIndex = 7;
            this.lblInstrumentationKey.Text = "Application Insights Instrumentation Key:";
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
            // gboxUseExisting
            // 
            this.gboxUseExisting.Controls.Add(this.cmbExistingWebResource);
            this.gboxUseExisting.Controls.Add(this.label6);
            this.gboxUseExisting.Location = new System.Drawing.Point(478, 17);
            this.gboxUseExisting.Name = "gboxUseExisting";
            this.gboxUseExisting.Size = new System.Drawing.Size(334, 82);
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
            this.cmbExistingWebResource.Size = new System.Drawing.Size(231, 21);
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
            // gboxCreate
            // 
            this.gboxCreate.Controls.Add(this.txtCreateWrDisplayName);
            this.gboxCreate.Controls.Add(this.label3);
            this.gboxCreate.Controls.Add(this.txtCreateWrSchemaName);
            this.gboxCreate.Controls.Add(this.lblCreateSolutionPrefix);
            this.gboxCreate.Controls.Add(this.label5);
            this.gboxCreate.Location = new System.Drawing.Point(478, 17);
            this.gboxCreate.Name = "gboxCreate";
            this.gboxCreate.Size = new System.Drawing.Size(334, 82);
            this.gboxCreate.TabIndex = 5;
            this.gboxCreate.TabStop = false;
            this.gboxCreate.Text = "Create";
            this.gboxCreate.Visible = false;
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
            // txtCreateWrSchemaName
            // 
            this.txtCreateWrSchemaName.Location = new System.Drawing.Point(132, 23);
            this.txtCreateWrSchemaName.Name = "txtCreateWrSchemaName";
            this.txtCreateWrSchemaName.Size = new System.Drawing.Size(181, 20);
            this.txtCreateWrSchemaName.TabIndex = 2;
            this.txtCreateWrSchemaName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCreateWrSchemaName_KeyUp);
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
            // dgvForms
            // 
            this.dgvForms.AllowUserToAddRows = false;
            this.dgvForms.AllowUserToDeleteRows = false;
            this.dgvForms.AllowUserToResizeRows = false;
            this.dgvForms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.FormId,
            this.EntityName,
            this.FormType,
            this.FormName,
            this.AppInsightsExists});
            this.dgvForms.Location = new System.Drawing.Point(7, 57);
            this.dgvForms.Name = "dgvForms";
            this.dgvForms.RowHeadersVisible = false;
            this.dgvForms.Size = new System.Drawing.Size(629, 445);
            this.dgvForms.TabIndex = 6;
            this.dgvForms.DataSourceChanged += new System.EventHandler(this.DgvForms_DataSourceChanged);
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
            // AppInsightsExists
            // 
            this.AppInsightsExists.DataPropertyName = "doesAiExists";
            this.AppInsightsExists.HeaderText = "AppInsightsExists";
            this.AppInsightsExists.Name = "AppInsightsExists";
            this.AppInsightsExists.ReadOnly = true;
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
            this.label8.Location = new System.Drawing.Point(446, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Filter By:";
            // 
            // cboxFilterBy
            // 
            this.cboxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFilterBy.FormattingEnabled = true;
            this.cboxFilterBy.Items.AddRange(new object[] {
            "All",
            "Form Type - Main",
            "Form Type - Quick Create",
            "AppInsights Does Not Exists",
            "AppInsights Exists"});
            this.cboxFilterBy.Location = new System.Drawing.Point(499, 7);
            this.cboxFilterBy.Name = "cboxFilterBy";
            this.cboxFilterBy.Size = new System.Drawing.Size(137, 21);
            this.cboxFilterBy.TabIndex = 10;
            this.cboxFilterBy.SelectedIndexChanged += new System.EventHandler(this.CboxFilterBy_SelectedIndexChanged);
            // 
            // pnlEntitiesSelection
            // 
            this.pnlEntitiesSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlEntitiesSelection.Controls.Add(this.linklblSelectAll);
            this.pnlEntitiesSelection.Controls.Add(this.gboxConfigs);
            this.pnlEntitiesSelection.Controls.Add(this.btnApplyPublish);
            this.pnlEntitiesSelection.Controls.Add(this.dgvForms);
            this.pnlEntitiesSelection.Controls.Add(this.cboxFilterBy);
            this.pnlEntitiesSelection.Controls.Add(this.label7);
            this.pnlEntitiesSelection.Controls.Add(this.label8);
            this.pnlEntitiesSelection.Controls.Add(this.txtSearch);
            this.pnlEntitiesSelection.Location = new System.Drawing.Point(3, 145);
            this.pnlEntitiesSelection.Name = "pnlEntitiesSelection";
            this.pnlEntitiesSelection.Size = new System.Drawing.Size(645, 650);
            this.pnlEntitiesSelection.TabIndex = 11;
            this.pnlEntitiesSelection.Visible = false;
            // 
            // linklblSelectAll
            // 
            this.linklblSelectAll.AutoSize = true;
            this.linklblSelectAll.Location = new System.Drawing.Point(7, 38);
            this.linklblSelectAll.Name = "linklblSelectAll";
            this.linklblSelectAll.Size = new System.Drawing.Size(197, 13);
            this.linklblSelectAll.TabIndex = 13;
            this.linklblSelectAll.TabStop = true;
            this.linklblSelectAll.Text = "Select All (except where AI Script Exists)";
            this.linklblSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinklblSelectAll_LinkClicked);
            // 
            // gboxConfigs
            // 
            this.gboxConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxConfigs.Controls.Add(this.cboxPageSaveTime);
            this.gboxConfigs.Controls.Add(this.cboxEvents);
            this.gboxConfigs.Controls.Add(this.cboxDependency);
            this.gboxConfigs.Controls.Add(this.cboxMetrics);
            this.gboxConfigs.Controls.Add(this.cboxTrace);
            this.gboxConfigs.Controls.Add(this.cboxAjax);
            this.gboxConfigs.Controls.Add(this.cboxException);
            this.gboxConfigs.Controls.Add(this.cboxPageLoad);
            this.gboxConfigs.Controls.Add(this.cboxPageView);
            this.gboxConfigs.Location = new System.Drawing.Point(7, 505);
            this.gboxConfigs.Name = "gboxConfigs";
            this.gboxConfigs.Size = new System.Drawing.Size(629, 93);
            this.gboxConfigs.TabIndex = 12;
            this.gboxConfigs.TabStop = false;
            this.gboxConfigs.Text = "Configurations";
            // 
            // cboxPageSaveTime
            // 
            this.cboxPageSaveTime.AutoSize = true;
            this.cboxPageSaveTime.Location = new System.Drawing.Point(316, 66);
            this.cboxPageSaveTime.Name = "cboxPageSaveTime";
            this.cboxPageSaveTime.Size = new System.Drawing.Size(185, 17);
            this.cboxPageSaveTime.TabIndex = 8;
            this.cboxPageSaveTime.Text = "Disable Page SaveTime Tracking";
            this.cboxPageSaveTime.UseVisualStyleBackColor = true;
            // 
            // cboxEvents
            // 
            this.cboxEvents.AutoSize = true;
            this.cboxEvents.Location = new System.Drawing.Point(316, 43);
            this.cboxEvents.Name = "cboxEvents";
            this.cboxEvents.Size = new System.Drawing.Size(137, 17);
            this.cboxEvents.TabIndex = 7;
            this.cboxEvents.Text = "Disable Event Tracking";
            this.cboxEvents.UseVisualStyleBackColor = true;
            // 
            // cboxDependency
            // 
            this.cboxDependency.AutoSize = true;
            this.cboxDependency.Location = new System.Drawing.Point(316, 20);
            this.cboxDependency.Name = "cboxDependency";
            this.cboxDependency.Size = new System.Drawing.Size(170, 17);
            this.cboxDependency.TabIndex = 6;
            this.cboxDependency.Text = "Disable Dependency Tracking";
            this.cboxDependency.UseVisualStyleBackColor = true;
            // 
            // cboxMetrics
            // 
            this.cboxMetrics.AutoSize = true;
            this.cboxMetrics.Location = new System.Drawing.Point(170, 66);
            this.cboxMetrics.Name = "cboxMetrics";
            this.cboxMetrics.Size = new System.Drawing.Size(143, 17);
            this.cboxMetrics.TabIndex = 5;
            this.cboxMetrics.Text = "Disable Metrics Tracking";
            this.cboxMetrics.UseVisualStyleBackColor = true;
            // 
            // cboxTrace
            // 
            this.cboxTrace.AutoSize = true;
            this.cboxTrace.Location = new System.Drawing.Point(170, 43);
            this.cboxTrace.Name = "cboxTrace";
            this.cboxTrace.Size = new System.Drawing.Size(137, 17);
            this.cboxTrace.TabIndex = 4;
            this.cboxTrace.Text = "Disable Trace Tracking";
            this.cboxTrace.UseVisualStyleBackColor = true;
            // 
            // cboxAjax
            // 
            this.cboxAjax.AutoSize = true;
            this.cboxAjax.Checked = true;
            this.cboxAjax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxAjax.Location = new System.Drawing.Point(170, 20);
            this.cboxAjax.Name = "cboxAjax";
            this.cboxAjax.Size = new System.Drawing.Size(129, 17);
            this.cboxAjax.TabIndex = 3;
            this.cboxAjax.Text = "Disable Ajax Tracking";
            this.cboxAjax.UseVisualStyleBackColor = true;
            // 
            // cboxException
            // 
            this.cboxException.AutoSize = true;
            this.cboxException.Location = new System.Drawing.Point(7, 66);
            this.cboxException.Name = "cboxException";
            this.cboxException.Size = new System.Drawing.Size(156, 17);
            this.cboxException.TabIndex = 2;
            this.cboxException.Text = "Disable Exception Tracking";
            this.cboxException.UseVisualStyleBackColor = true;
            // 
            // cboxPageLoad
            // 
            this.cboxPageLoad.AutoSize = true;
            this.cboxPageLoad.Location = new System.Drawing.Point(7, 43);
            this.cboxPageLoad.Name = "cboxPageLoad";
            this.cboxPageLoad.Size = new System.Drawing.Size(158, 17);
            this.cboxPageLoad.TabIndex = 1;
            this.cboxPageLoad.Text = "Disable PageLoad Tracking";
            this.cboxPageLoad.UseVisualStyleBackColor = true;
            // 
            // cboxPageView
            // 
            this.cboxPageView.AutoSize = true;
            this.cboxPageView.Location = new System.Drawing.Point(7, 20);
            this.cboxPageView.Name = "cboxPageView";
            this.cboxPageView.Size = new System.Drawing.Size(157, 17);
            this.cboxPageView.TabIndex = 0;
            this.cboxPageView.Text = "Disable PageView Tracking";
            this.cboxPageView.UseVisualStyleBackColor = true;
            // 
            // btnApplyPublish
            // 
            this.btnApplyPublish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplyPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyPublish.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyPublish.Image")));
            this.btnApplyPublish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyPublish.Location = new System.Drawing.Point(7, 603);
            this.btnApplyPublish.Name = "btnApplyPublish";
            this.btnApplyPublish.Size = new System.Drawing.Size(151, 44);
            this.btnApplyPublish.TabIndex = 11;
            this.btnApplyPublish.Text = "Apply & Publish";
            this.btnApplyPublish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplyPublish.UseMnemonic = false;
            this.btnApplyPublish.UseVisualStyleBackColor = true;
            this.btnApplyPublish.Click += new System.EventHandler(this.BtnApplyPublish_Click);
            // 
            // linklblCreator
            // 
            this.linklblCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklblCreator.Image = ((System.Drawing.Image)(resources.GetObject("linklblCreator.Image")));
            this.linklblCreator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linklblCreator.Location = new System.Drawing.Point(905, 4);
            this.linklblCreator.Name = "linklblCreator";
            this.linklblCreator.Size = new System.Drawing.Size(160, 23);
            this.linklblCreator.TabIndex = 12;
            this.linklblCreator.TabStop = true;
            this.linklblCreator.Text = "by Danish (Power Maverick)";
            this.linklblCreator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linklblCreator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinklblCreator_LinkClicked);
            // 
            // gboxExamples
            // 
            this.gboxExamples.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxExamples.Controls.Add(this.btnCopyTraces);
            this.gboxExamples.Controls.Add(this.btnCopyDependencies);
            this.gboxExamples.Controls.Add(this.btnCopyException);
            this.gboxExamples.Controls.Add(this.btnCopyEvents);
            this.gboxExamples.Controls.Add(this.btnCopyMetric);
            this.gboxExamples.Controls.Add(this.lblDependencies);
            this.gboxExamples.Controls.Add(this.lblDependenciesLabel);
            this.gboxExamples.Controls.Add(this.lblExceptions);
            this.gboxExamples.Controls.Add(this.lblExceptionsLabel);
            this.gboxExamples.Controls.Add(this.lblTraces);
            this.gboxExamples.Controls.Add(this.lblTracesLabel);
            this.gboxExamples.Controls.Add(this.lblEvents);
            this.gboxExamples.Controls.Add(this.lblEventsLabel);
            this.gboxExamples.Controls.Add(this.lblMetrics);
            this.gboxExamples.Controls.Add(this.lblMetricsLabel);
            this.gboxExamples.Location = new System.Drawing.Point(654, 145);
            this.gboxExamples.Name = "gboxExamples";
            this.gboxExamples.Size = new System.Drawing.Size(411, 650);
            this.gboxExamples.TabIndex = 14;
            this.gboxExamples.TabStop = false;
            this.gboxExamples.Text = "Examples to use in your scripts";
            this.gboxExamples.Visible = false;
            // 
            // btnCopyTraces
            // 
            this.btnCopyTraces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyTraces.FlatAppearance.BorderSize = 0;
            this.btnCopyTraces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyTraces.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyTraces.Image")));
            this.btnCopyTraces.Location = new System.Drawing.Point(379, 145);
            this.btnCopyTraces.Name = "btnCopyTraces";
            this.btnCopyTraces.Size = new System.Drawing.Size(26, 23);
            this.btnCopyTraces.TabIndex = 14;
            this.btnCopyTraces.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopyTraces.UseVisualStyleBackColor = true;
            this.btnCopyTraces.Click += new System.EventHandler(this.btnCopyTraces_Click);
            // 
            // btnCopyDependencies
            // 
            this.btnCopyDependencies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyDependencies.FlatAppearance.BorderSize = 0;
            this.btnCopyDependencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyDependencies.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyDependencies.Image")));
            this.btnCopyDependencies.Location = new System.Drawing.Point(379, 368);
            this.btnCopyDependencies.Name = "btnCopyDependencies";
            this.btnCopyDependencies.Size = new System.Drawing.Size(26, 23);
            this.btnCopyDependencies.TabIndex = 13;
            this.btnCopyDependencies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopyDependencies.UseVisualStyleBackColor = true;
            this.btnCopyDependencies.Click += new System.EventHandler(this.btnCopyDependencies_Click);
            // 
            // btnCopyException
            // 
            this.btnCopyException.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyException.FlatAppearance.BorderSize = 0;
            this.btnCopyException.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyException.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyException.Image")));
            this.btnCopyException.Location = new System.Drawing.Point(379, 212);
            this.btnCopyException.Name = "btnCopyException";
            this.btnCopyException.Size = new System.Drawing.Size(26, 23);
            this.btnCopyException.TabIndex = 12;
            this.btnCopyException.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopyException.UseVisualStyleBackColor = true;
            this.btnCopyException.Click += new System.EventHandler(this.btnCopyException_Click);
            // 
            // btnCopyEvents
            // 
            this.btnCopyEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyEvents.FlatAppearance.BorderSize = 0;
            this.btnCopyEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyEvents.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyEvents.Image")));
            this.btnCopyEvents.Location = new System.Drawing.Point(379, 92);
            this.btnCopyEvents.Name = "btnCopyEvents";
            this.btnCopyEvents.Size = new System.Drawing.Size(26, 23);
            this.btnCopyEvents.TabIndex = 11;
            this.btnCopyEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopyEvents.UseVisualStyleBackColor = true;
            this.btnCopyEvents.Click += new System.EventHandler(this.btnCopyEvents_Click);
            // 
            // btnCopyMetric
            // 
            this.btnCopyMetric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyMetric.FlatAppearance.BorderSize = 0;
            this.btnCopyMetric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyMetric.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyMetric.Image")));
            this.btnCopyMetric.Location = new System.Drawing.Point(379, 23);
            this.btnCopyMetric.Name = "btnCopyMetric";
            this.btnCopyMetric.Size = new System.Drawing.Size(26, 23);
            this.btnCopyMetric.TabIndex = 10;
            this.btnCopyMetric.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopyMetric.UseVisualStyleBackColor = true;
            this.btnCopyMetric.Click += new System.EventHandler(this.btnCopyMetric_Click);
            // 
            // lblDependencies
            // 
            this.lblDependencies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDependencies.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependencies.Location = new System.Drawing.Point(9, 391);
            this.lblDependencies.Name = "lblDependencies";
            this.lblDependencies.Size = new System.Drawing.Size(396, 32);
            this.lblDependencies.TabIndex = 9;
            this.lblDependencies.Text = "D365AppInsights.writeDependency(\"Test\", \"Some Method\", 100, true, 0);";
            // 
            // lblDependenciesLabel
            // 
            this.lblDependenciesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDependenciesLabel.AutoSize = true;
            this.lblDependenciesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependenciesLabel.Location = new System.Drawing.Point(6, 371);
            this.lblDependenciesLabel.Name = "lblDependenciesLabel";
            this.lblDependenciesLabel.Size = new System.Drawing.Size(110, 16);
            this.lblDependenciesLabel.TabIndex = 8;
            this.lblDependenciesLabel.Text = "Dependencies";
            // 
            // lblExceptions
            // 
            this.lblExceptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExceptions.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExceptions.Location = new System.Drawing.Point(9, 235);
            this.lblExceptions.Name = "lblExceptions";
            this.lblExceptions.Size = new System.Drawing.Size(396, 129);
            this.lblExceptions.TabIndex = 7;
            this.lblExceptions.Text = "try {\r\n       doSomethingNotDefined();\r\n}\r\ncatch (e) {\r\n       D365AppInsights.wr" +
    "iteException(e, \"ExceptionTest\", AI.SeverityLevel.Error, null, null);\r\n}";
            // 
            // lblExceptionsLabel
            // 
            this.lblExceptionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExceptionsLabel.AutoSize = true;
            this.lblExceptionsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExceptionsLabel.Location = new System.Drawing.Point(6, 215);
            this.lblExceptionsLabel.Name = "lblExceptionsLabel";
            this.lblExceptionsLabel.Size = new System.Drawing.Size(86, 16);
            this.lblExceptionsLabel.TabIndex = 6;
            this.lblExceptionsLabel.Text = "Exceptions";
            // 
            // lblTraces
            // 
            this.lblTraces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTraces.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraces.Location = new System.Drawing.Point(9, 168);
            this.lblTraces.Name = "lblTraces";
            this.lblTraces.Size = new System.Drawing.Size(396, 32);
            this.lblTraces.TabIndex = 5;
            this.lblTraces.Text = "D365AppInsights.writeTrace(\"Test\", AI.SeverityLevel.Warning, { myProp: \"a value\" " +
    "});";
            // 
            // lblTracesLabel
            // 
            this.lblTracesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTracesLabel.AutoSize = true;
            this.lblTracesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracesLabel.Location = new System.Drawing.Point(6, 148);
            this.lblTracesLabel.Name = "lblTracesLabel";
            this.lblTracesLabel.Size = new System.Drawing.Size(227, 16);
            this.lblTracesLabel.TabIndex = 4;
            this.lblTracesLabel.Text = "Traces and Custom Dimensions";
            // 
            // lblEvents
            // 
            this.lblEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEvents.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.Location = new System.Drawing.Point(9, 115);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(396, 24);
            this.lblEvents.TabIndex = 3;
            this.lblEvents.Text = "D365AppInsights.writeEvent(\"Button Click\", null, { click: 1 });";
            // 
            // lblEventsLabel
            // 
            this.lblEventsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventsLabel.AutoSize = true;
            this.lblEventsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsLabel.Location = new System.Drawing.Point(6, 95);
            this.lblEventsLabel.Name = "lblEventsLabel";
            this.lblEventsLabel.Size = new System.Drawing.Size(253, 16);
            this.lblEventsLabel.TabIndex = 2;
            this.lblEventsLabel.Text = "Events and Custom Measurements";
            // 
            // lblMetrics
            // 
            this.lblMetrics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMetrics.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetrics.Location = new System.Drawing.Point(9, 46);
            this.lblMetrics.Name = "lblMetrics";
            this.lblMetrics.Size = new System.Drawing.Size(396, 40);
            this.lblMetrics.TabIndex = 1;
            this.lblMetrics.Text = "D365AppInsights.writeMetric(\"Custom Metric: Measurement\", 5, 1);\r\nD365AppInsights" +
    ".writeMetric(\"Custom Metric: Aggregate\", 15, 3, 0, 30);";
            // 
            // lblMetricsLabel
            // 
            this.lblMetricsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMetricsLabel.AutoSize = true;
            this.lblMetricsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricsLabel.Location = new System.Drawing.Point(6, 26);
            this.lblMetricsLabel.Name = "lblMetricsLabel";
            this.lblMetricsLabel.Size = new System.Drawing.Size(61, 16);
            this.lblMetricsLabel.TabIndex = 0;
            this.lblMetricsLabel.Text = "Metrics";
            // 
            // lblCopied
            // 
            this.lblCopied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopied.AutoSize = true;
            this.lblCopied.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCopied.ForeColor = System.Drawing.Color.White;
            this.lblCopied.Location = new System.Drawing.Point(1019, 129);
            this.lblCopied.Name = "lblCopied";
            this.lblCopied.Size = new System.Drawing.Size(40, 13);
            this.lblCopied.TabIndex = 15;
            this.lblCopied.Text = "Copied";
            this.lblCopied.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCopied);
            this.Controls.Add(this.gboxExamples);
            this.Controls.Add(this.linklblCreator);
            this.Controls.Add(this.pnlEntitiesSelection);
            this.Controls.Add(this.gboxSolutionManagement);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MainPluginControl";
            this.Size = new System.Drawing.Size(1068, 798);
            this.OnCloseTool += new System.EventHandler(this.MainPluginControl_OnCloseTool);
            this.Load += new System.EventHandler(this.MainPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gboxSolutionManagement.ResumeLayout(false);
            this.gboxSolutionManagement.PerformLayout();
            this.gboxUseExisting.ResumeLayout(false);
            this.gboxUseExisting.PerformLayout();
            this.gboxCreate.ResumeLayout(false);
            this.gboxCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).EndInit();
            this.pnlEntitiesSelection.ResumeLayout(false);
            this.pnlEntitiesSelection.PerformLayout();
            this.gboxConfigs.ResumeLayout(false);
            this.gboxConfigs.PerformLayout();
            this.gboxExamples.ResumeLayout(false);
            this.gboxExamples.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLoadSolutions;
        private System.Windows.Forms.ToolStripSeparator tssSeparator2;
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
        private System.Windows.Forms.DataGridView dgvForms;
        private System.Windows.Forms.TextBox txtCreateWrDisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInstrumentationKey;
        private System.Windows.Forms.Label lblInstrumentationKey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AppInsightsExists;
        private System.Windows.Forms.GroupBox gboxConfigs;
        private System.Windows.Forms.CheckBox cboxPageView;
        private System.Windows.Forms.CheckBox cboxEvents;
        private System.Windows.Forms.CheckBox cboxDependency;
        private System.Windows.Forms.CheckBox cboxMetrics;
        private System.Windows.Forms.CheckBox cboxTrace;
        private System.Windows.Forms.CheckBox cboxAjax;
        private System.Windows.Forms.CheckBox cboxException;
        private System.Windows.Forms.CheckBox cboxPageLoad;
        private System.Windows.Forms.LinkLabel linklblSelectAll;
        private System.Windows.Forms.ToolStripButton tsbReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.LinkLabel linklblCreator;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.CheckBox cboxPageSaveTime;
        private System.Windows.Forms.GroupBox gboxExamples;
        private System.Windows.Forms.Label lblDependencies;
        private System.Windows.Forms.Label lblDependenciesLabel;
        private System.Windows.Forms.Label lblExceptions;
        private System.Windows.Forms.Label lblExceptionsLabel;
        private System.Windows.Forms.Label lblTraces;
        private System.Windows.Forms.Label lblTracesLabel;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblEventsLabel;
        private System.Windows.Forms.Label lblMetrics;
        private System.Windows.Forms.Label lblMetricsLabel;
        private System.Windows.Forms.Button btnCopyTraces;
        private System.Windows.Forms.Button btnCopyDependencies;
        private System.Windows.Forms.Button btnCopyException;
        private System.Windows.Forms.Button btnCopyEvents;
        private System.Windows.Forms.Button btnCopyMetric;
        private System.Windows.Forms.Label lblCopied;
        private System.Windows.Forms.Timer timer;
    }
}
