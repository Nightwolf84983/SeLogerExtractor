using SeLogerExtractor.DataAccess.DataAccess;
using System.Windows.Forms;
namespace ConsoleApplication1
{
    partial class FormTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label surfaceMaxLabel;
            System.Windows.Forms.Label terrainMaxLabel;
            System.Windows.Forms.Label prixCalculeLabel;
            System.Windows.Forms.Label prixProposeLabel;
            System.Windows.Forms.Label surfaceLabel;
            System.Windows.Forms.Label terrainLabel;
            System.Windows.Forms.Label prixSurfaceMCarreLabel;
            System.Windows.Forms.Label prixTerrainMCarreLabel;
            System.Windows.Forms.Label prixCalculeMoins10Label;
            System.Windows.Forms.Label filterOnPiscineLabel;
            System.Windows.Forms.Label withPiscineLabel;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel4 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.annonceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criteriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfaceMaxTrackBar = new System.Windows.Forms.TrackBar();
            this.surfaceMinTrackBar = new System.Windows.Forms.TrackBar();
            this.terrainMaxTrackBar = new System.Windows.Forms.TrackBar();
            this.terrainMinTrackBar = new System.Windows.Forms.TrackBar();
            this.surfaceMaxLabel2 = new System.Windows.Forms.Label();
            this.surfaceMinLabel1 = new System.Windows.Forms.Label();
            this.terrainMaxLabel2 = new System.Windows.Forms.Label();
            this.terrainMinLabel1 = new System.Windows.Forms.Label();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVillage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurface = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerrain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConstructionYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPiscine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChambres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrixM2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.annonceGridControl = new DevExpress.XtraGrid.GridControl();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.surfaceCibleSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.terrainCibleSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.variationSurfaceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.variationTerrainSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prixCalculeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.prixProposeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.surfaceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.terrainSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.prixSurfaceMCarreSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.prixTerrainMCarreSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.prixCalculeMoins10SpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.filterOnPiscineCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.withPiscineCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.villePrixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villePrixGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrixM21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrixTerrainM2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            surfaceMaxLabel = new System.Windows.Forms.Label();
            terrainMaxLabel = new System.Windows.Forms.Label();
            prixCalculeLabel = new System.Windows.Forms.Label();
            prixProposeLabel = new System.Windows.Forms.Label();
            surfaceLabel = new System.Windows.Forms.Label();
            terrainLabel = new System.Windows.Forms.Label();
            prixSurfaceMCarreLabel = new System.Windows.Forms.Label();
            prixTerrainMCarreLabel = new System.Windows.Forms.Label();
            prixCalculeMoins10Label = new System.Windows.Forms.Label();
            filterOnPiscineLabel = new System.Windows.Forms.Label();
            withPiscineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.annonceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceMaxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceMinTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainMaxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainMinTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annonceGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceCibleSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainCibleSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variationSurfaceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variationTerrainSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixCalculeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixProposeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixSurfaceMCarreSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixTerrainMCarreSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixCalculeMoins10SpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterOnPiscineCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withPiscineCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villePrixBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villePrixGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // surfaceMaxLabel
            // 
            surfaceMaxLabel.AutoSize = true;
            surfaceMaxLabel.Location = new System.Drawing.Point(12, 23);
            surfaceMaxLabel.Name = "surfaceMaxLabel";
            surfaceMaxLabel.Size = new System.Drawing.Size(50, 13);
            surfaceMaxLabel.TabIndex = 1;
            surfaceMaxLabel.Text = "Surface :";
            // 
            // terrainMaxLabel
            // 
            terrainMaxLabel.AutoSize = true;
            terrainMaxLabel.Location = new System.Drawing.Point(12, 124);
            terrainMaxLabel.Name = "terrainMaxLabel";
            terrainMaxLabel.Size = new System.Drawing.Size(46, 13);
            terrainMaxLabel.TabIndex = 5;
            terrainMaxLabel.Text = "Terrain :";
            // 
            // prixCalculeLabel
            // 
            prixCalculeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            prixCalculeLabel.AutoSize = true;
            prixCalculeLabel.Location = new System.Drawing.Point(1041, 536);
            prixCalculeLabel.Name = "prixCalculeLabel";
            prixCalculeLabel.Size = new System.Drawing.Size(65, 13);
            prixCalculeLabel.TabIndex = 24;
            prixCalculeLabel.Text = "Prix Calcule:";
            // 
            // prixProposeLabel
            // 
            prixProposeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            prixProposeLabel.AutoSize = true;
            prixProposeLabel.Location = new System.Drawing.Point(817, 510);
            prixProposeLabel.Name = "prixProposeLabel";
            prixProposeLabel.Size = new System.Drawing.Size(69, 13);
            prixProposeLabel.TabIndex = 26;
            prixProposeLabel.Text = "Prix Propose:";
            // 
            // surfaceLabel
            // 
            surfaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            surfaceLabel.AutoSize = true;
            surfaceLabel.Location = new System.Drawing.Point(817, 536);
            surfaceLabel.Name = "surfaceLabel";
            surfaceLabel.Size = new System.Drawing.Size(47, 13);
            surfaceLabel.TabIndex = 28;
            surfaceLabel.Text = "Surface:";
            // 
            // terrainLabel
            // 
            terrainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            terrainLabel.AutoSize = true;
            terrainLabel.Location = new System.Drawing.Point(817, 562);
            terrainLabel.Name = "terrainLabel";
            terrainLabel.Size = new System.Drawing.Size(43, 13);
            terrainLabel.TabIndex = 30;
            terrainLabel.Text = "Terrain:";
            // 
            // prixSurfaceMCarreLabel
            // 
            prixSurfaceMCarreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            prixSurfaceMCarreLabel.AutoSize = true;
            prixSurfaceMCarreLabel.Location = new System.Drawing.Point(782, 617);
            prixSurfaceMCarreLabel.Name = "prixSurfaceMCarreLabel";
            prixSurfaceMCarreLabel.Size = new System.Drawing.Size(104, 13);
            prixSurfaceMCarreLabel.TabIndex = 31;
            prixSurfaceMCarreLabel.Text = "Prix Surface MCarre:";
            // 
            // prixTerrainMCarreLabel
            // 
            prixTerrainMCarreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            prixTerrainMCarreLabel.AutoSize = true;
            prixTerrainMCarreLabel.Location = new System.Drawing.Point(786, 643);
            prixTerrainMCarreLabel.Name = "prixTerrainMCarreLabel";
            prixTerrainMCarreLabel.Size = new System.Drawing.Size(100, 13);
            prixTerrainMCarreLabel.TabIndex = 32;
            prixTerrainMCarreLabel.Text = "Prix Terrain MCarre:";
            // 
            // prixCalculeMoins10Label
            // 
            prixCalculeMoins10Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            prixCalculeMoins10Label.AutoSize = true;
            prixCalculeMoins10Label.Location = new System.Drawing.Point(998, 562);
            prixCalculeMoins10Label.Name = "prixCalculeMoins10Label";
            prixCalculeMoins10Label.Size = new System.Drawing.Size(108, 13);
            prixCalculeMoins10Label.TabIndex = 33;
            prixCalculeMoins10Label.Text = "Prix Calcule Moins10:";
            // 
            // filterOnPiscineLabel
            // 
            filterOnPiscineLabel.AutoSize = true;
            filterOnPiscineLabel.Location = new System.Drawing.Point(126, 209);
            filterOnPiscineLabel.Name = "filterOnPiscineLabel";
            filterOnPiscineLabel.Size = new System.Drawing.Size(86, 13);
            filterOnPiscineLabel.TabIndex = 34;
            filterOnPiscineLabel.Text = "Filter On Piscine:";
            // 
            // withPiscineLabel
            // 
            withPiscineLabel.AutoSize = true;
            withPiscineLabel.Location = new System.Drawing.Point(143, 231);
            withPiscineLabel.Name = "withPiscineLabel";
            withPiscineLabel.Size = new System.Drawing.Size(69, 13);
            withPiscineLabel.TabIndex = 36;
            withPiscineLabel.Text = "With Piscine:";
            // 
            // annonceBindingSource
            // 
            this.annonceBindingSource.DataSource = typeof(SeLogerExtractor.DataAccess.DataAccess.Annonce);
            // 
            // criteriaBindingSource
            // 
            this.criteriaBindingSource.DataSource = typeof(ConsoleApplication1.Criteria);
            // 
            // surfaceMaxTrackBar
            // 
            this.surfaceMaxTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.criteriaBindingSource, "SurfaceMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.surfaceMaxTrackBar.Location = new System.Drawing.Point(110, 66);
            this.surfaceMaxTrackBar.Maximum = 500;
            this.surfaceMaxTrackBar.Name = "surfaceMaxTrackBar";
            this.surfaceMaxTrackBar.Size = new System.Drawing.Size(555, 45);
            this.surfaceMaxTrackBar.TabIndex = 2;
            // 
            // surfaceMinTrackBar
            // 
            this.surfaceMinTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.criteriaBindingSource, "SurfaceMin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.surfaceMinTrackBar.Location = new System.Drawing.Point(110, 44);
            this.surfaceMinTrackBar.Maximum = 500;
            this.surfaceMinTrackBar.Name = "surfaceMinTrackBar";
            this.surfaceMinTrackBar.Size = new System.Drawing.Size(555, 45);
            this.surfaceMinTrackBar.TabIndex = 4;
            // 
            // terrainMaxTrackBar
            // 
            this.terrainMaxTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.criteriaBindingSource, "TerrainMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.terrainMaxTrackBar.Location = new System.Drawing.Point(110, 164);
            this.terrainMaxTrackBar.Maximum = 2000;
            this.terrainMaxTrackBar.Name = "terrainMaxTrackBar";
            this.terrainMaxTrackBar.Size = new System.Drawing.Size(555, 45);
            this.terrainMaxTrackBar.TabIndex = 6;
            // 
            // terrainMinTrackBar
            // 
            this.terrainMinTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.criteriaBindingSource, "TerrainMin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.terrainMinTrackBar.Location = new System.Drawing.Point(110, 143);
            this.terrainMinTrackBar.Maximum = 2000;
            this.terrainMinTrackBar.Name = "terrainMinTrackBar";
            this.terrainMinTrackBar.Size = new System.Drawing.Size(555, 45);
            this.terrainMinTrackBar.TabIndex = 8;
            // 
            // surfaceMaxLabel2
            // 
            this.surfaceMaxLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criteriaBindingSource, "SurfaceMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.surfaceMaxLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaxLabel2.Location = new System.Drawing.Point(223, 18);
            this.surfaceMaxLabel2.Name = "surfaceMaxLabel2";
            this.surfaceMaxLabel2.Size = new System.Drawing.Size(100, 23);
            this.surfaceMaxLabel2.TabIndex = 9;
            this.surfaceMaxLabel2.Text = "label1";
            this.surfaceMaxLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // surfaceMinLabel1
            // 
            this.surfaceMinLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criteriaBindingSource, "SurfaceMin", true));
            this.surfaceMinLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMinLabel1.Location = new System.Drawing.Point(65, 18);
            this.surfaceMinLabel1.Name = "surfaceMinLabel1";
            this.surfaceMinLabel1.Size = new System.Drawing.Size(100, 23);
            this.surfaceMinLabel1.TabIndex = 11;
            this.surfaceMinLabel1.Text = "label1";
            this.surfaceMinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // terrainMaxLabel2
            // 
            this.terrainMaxLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criteriaBindingSource, "TerrainMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.terrainMaxLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terrainMaxLabel2.Location = new System.Drawing.Point(223, 117);
            this.terrainMaxLabel2.Name = "terrainMaxLabel2";
            this.terrainMaxLabel2.Size = new System.Drawing.Size(100, 23);
            this.terrainMaxLabel2.TabIndex = 13;
            this.terrainMaxLabel2.Text = "label1";
            this.terrainMaxLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // terrainMinLabel1
            // 
            this.terrainMinLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criteriaBindingSource, "TerrainMin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.terrainMinLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terrainMinLabel1.Location = new System.Drawing.Point(65, 118);
            this.terrainMinLabel1.Name = "terrainMinLabel1";
            this.terrainMinLabel1.Size = new System.Drawing.Size(100, 23);
            this.terrainMinLabel1.TabIndex = 15;
            this.terrainMinLabel1.Text = "label1";
            this.terrainMinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVillage,
            this.colPrice,
            this.colSurface,
            this.colTerrain,
            this.colConstructionYear,
            this.colPiscine,
            this.colChambres,
            this.colPrixM2});
            this.gridView1.GridControl = this.annonceGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colVillage
            // 
            this.colVillage.FieldName = "Village";
            this.colVillage.Name = "colVillage";
            this.colVillage.Visible = true;
            this.colVillage.VisibleIndex = 0;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "Price", "{0:n0}")});
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            // 
            // colSurface
            // 
            this.colSurface.FieldName = "Surface";
            this.colSurface.Name = "colSurface";
            this.colSurface.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "Surface", "{0:n0}")});
            this.colSurface.Visible = true;
            this.colSurface.VisibleIndex = 2;
            // 
            // colTerrain
            // 
            this.colTerrain.FieldName = "Terrain";
            this.colTerrain.Name = "colTerrain";
            this.colTerrain.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "Terrain", "{0:n0}")});
            this.colTerrain.Visible = true;
            this.colTerrain.VisibleIndex = 3;
            // 
            // colConstructionYear
            // 
            this.colConstructionYear.FieldName = "ConstuctionYear";
            this.colConstructionYear.Name = "colConstructionYear";
            this.colConstructionYear.Visible = true;
            this.colConstructionYear.VisibleIndex = 4;
            // 
            // colPiscine
            // 
            this.colPiscine.FieldName = "Piscine";
            this.colPiscine.Name = "colPiscine";
            this.colPiscine.Visible = true;
            this.colPiscine.VisibleIndex = 5;
            // 
            // colChambres
            // 
            this.colChambres.FieldName = "Chambres";
            this.colChambres.Name = "colChambres";
            this.colChambres.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "Chambres", "{0:n1}")});
            this.colChambres.Visible = true;
            this.colChambres.VisibleIndex = 6;
            // 
            // colPrixM2
            // 
            this.colPrixM2.DisplayFormat.FormatString = "{0:n0}";
            this.colPrixM2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrixM2.FieldName = "PrixM2";
            this.colPrixM2.Name = "colPrixM2";
            this.colPrixM2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "PrixM2", "{0:n0}")});
            this.colPrixM2.Visible = true;
            this.colPrixM2.VisibleIndex = 7;
            // 
            // annonceGridControl
            // 
            this.annonceGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.annonceGridControl.DataSource = this.annonceBindingSource;
            gridLevelNode2.RelationName = "Attributs";
            this.annonceGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.annonceGridControl.Location = new System.Drawing.Point(12, 258);
            this.annonceGridControl.MainView = this.gridView1;
            this.annonceGridControl.Name = "annonceGridControl";
            this.annonceGridControl.Size = new System.Drawing.Size(687, 394);
            this.annonceGridControl.TabIndex = 1;
            this.annonceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(590, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(9, 242);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 17;
            this.lblCount.Text = "label1";
            // 
            // surfaceCibleSpinEdit
            // 
            this.surfaceCibleSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.criteriaBindingSource, "SurfaceCible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.surfaceCibleSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.surfaceCibleSpinEdit.Location = new System.Drawing.Point(4, 46);
            this.surfaceCibleSpinEdit.Name = "surfaceCibleSpinEdit";
            this.surfaceCibleSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.surfaceCibleSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.surfaceCibleSpinEdit.TabIndex = 18;
            // 
            // terrainCibleSpinEdit
            // 
            this.terrainCibleSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.criteriaBindingSource, "TerrainCible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.terrainCibleSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.terrainCibleSpinEdit.Location = new System.Drawing.Point(4, 143);
            this.terrainCibleSpinEdit.Name = "terrainCibleSpinEdit";
            this.terrainCibleSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.terrainCibleSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.terrainCibleSpinEdit.TabIndex = 19;
            // 
            // variationSurfaceSpinEdit
            // 
            this.variationSurfaceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.criteriaBindingSource, "VariationSurface", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.variationSurfaceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.variationSurfaceSpinEdit.Location = new System.Drawing.Point(4, 72);
            this.variationSurfaceSpinEdit.Name = "variationSurfaceSpinEdit";
            this.variationSurfaceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.variationSurfaceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.variationSurfaceSpinEdit.TabIndex = 20;
            // 
            // variationTerrainSpinEdit
            // 
            this.variationTerrainSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.criteriaBindingSource, "VariationTerrain", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.variationTerrainSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.variationTerrainSpinEdit.Location = new System.Drawing.Point(4, 169);
            this.variationTerrainSpinEdit.Name = "variationTerrainSpinEdit";
            this.variationTerrainSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.variationTerrainSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.variationTerrainSpinEdit.TabIndex = 21;
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Location = new System.Drawing.Point(726, 12);
            this.chartControl1.Name = "chartControl1";
            sideBySideBarSeriesLabel3.LineVisible = true;
            series2.Label = sideBySideBarSeriesLabel3;
            series2.Name = "Series 1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            sideBySideBarSeriesLabel4.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel4;
            this.chartControl1.Size = new System.Drawing.Size(483, 239);
            this.chartControl1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "< X <";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "< X <";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ConsoleApplication1.StudyResult);
            // 
            // prixCalculeSpinEdit
            // 
            this.prixCalculeSpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prixCalculeSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "PrixCalcule", true));
            this.prixCalculeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.prixCalculeSpinEdit.Location = new System.Drawing.Point(1107, 533);
            this.prixCalculeSpinEdit.Name = "prixCalculeSpinEdit";
            this.prixCalculeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.prixCalculeSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.prixCalculeSpinEdit.TabIndex = 25;
            // 
            // prixProposeSpinEdit
            // 
            this.prixProposeSpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prixProposeSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "PrixPropose", true));
            this.prixProposeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.prixProposeSpinEdit.Location = new System.Drawing.Point(892, 507);
            this.prixProposeSpinEdit.Name = "prixProposeSpinEdit";
            this.prixProposeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.prixProposeSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.prixProposeSpinEdit.TabIndex = 27;
            // 
            // surfaceSpinEdit
            // 
            this.surfaceSpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.surfaceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Surface", true));
            this.surfaceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.surfaceSpinEdit.Location = new System.Drawing.Point(892, 533);
            this.surfaceSpinEdit.Name = "surfaceSpinEdit";
            this.surfaceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.surfaceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.surfaceSpinEdit.TabIndex = 29;
            // 
            // terrainSpinEdit
            // 
            this.terrainSpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.terrainSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Terrain", true));
            this.terrainSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.terrainSpinEdit.Location = new System.Drawing.Point(892, 559);
            this.terrainSpinEdit.Name = "terrainSpinEdit";
            this.terrainSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.terrainSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.terrainSpinEdit.TabIndex = 31;
            // 
            // prixSurfaceMCarreSpinEdit
            // 
            this.prixSurfaceMCarreSpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prixSurfaceMCarreSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "PrixSurfaceMCarre", true));
            this.prixSurfaceMCarreSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.prixSurfaceMCarreSpinEdit.Location = new System.Drawing.Point(892, 614);
            this.prixSurfaceMCarreSpinEdit.Name = "prixSurfaceMCarreSpinEdit";
            this.prixSurfaceMCarreSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.prixSurfaceMCarreSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.prixSurfaceMCarreSpinEdit.TabIndex = 32;
            // 
            // prixTerrainMCarreSpinEdit
            // 
            this.prixTerrainMCarreSpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prixTerrainMCarreSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "PrixTerrainMCarre", true));
            this.prixTerrainMCarreSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.prixTerrainMCarreSpinEdit.Location = new System.Drawing.Point(892, 640);
            this.prixTerrainMCarreSpinEdit.Name = "prixTerrainMCarreSpinEdit";
            this.prixTerrainMCarreSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.prixTerrainMCarreSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.prixTerrainMCarreSpinEdit.TabIndex = 33;
            // 
            // prixCalculeMoins10SpinEdit
            // 
            this.prixCalculeMoins10SpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prixCalculeMoins10SpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "PrixCalculeMoins10", true));
            this.prixCalculeMoins10SpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.prixCalculeMoins10SpinEdit.Location = new System.Drawing.Point(1107, 559);
            this.prixCalculeMoins10SpinEdit.Name = "prixCalculeMoins10SpinEdit";
            this.prixCalculeMoins10SpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.prixCalculeMoins10SpinEdit.Size = new System.Drawing.Size(100, 20);
            this.prixCalculeMoins10SpinEdit.TabIndex = 34;
            // 
            // filterOnPiscineCheckEdit
            // 
            this.filterOnPiscineCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.criteriaBindingSource, "FilterOnPiscine", true));
            this.filterOnPiscineCheckEdit.Location = new System.Drawing.Point(218, 206);
            this.filterOnPiscineCheckEdit.Name = "filterOnPiscineCheckEdit";
            this.filterOnPiscineCheckEdit.Properties.Caption = "checkEdit1";
            this.filterOnPiscineCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.filterOnPiscineCheckEdit.TabIndex = 35;
            // 
            // withPiscineCheckEdit
            // 
            this.withPiscineCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.criteriaBindingSource, "WithPiscine", true));
            this.withPiscineCheckEdit.Location = new System.Drawing.Point(218, 228);
            this.withPiscineCheckEdit.Name = "withPiscineCheckEdit";
            this.withPiscineCheckEdit.Properties.Caption = "checkEdit1";
            this.withPiscineCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.withPiscineCheckEdit.TabIndex = 37;
            // 
            // villePrixBindingSource
            // 
            this.villePrixBindingSource.DataSource = typeof(ConsoleApplication1.VillePrix);
            // 
            // villePrixGridControl
            // 
            this.villePrixGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.villePrixGridControl.DataSource = this.villePrixBindingSource;
            this.villePrixGridControl.Location = new System.Drawing.Point(770, 258);
            this.villePrixGridControl.MainView = this.gridView2;
            this.villePrixGridControl.Name = "villePrixGridControl";
            this.villePrixGridControl.Size = new System.Drawing.Size(439, 220);
            this.villePrixGridControl.TabIndex = 38;
            this.villePrixGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVille,
            this.colPrixM21,
            this.colPrixTerrainM2,
            this.colCount});
            this.gridView2.GridControl = this.villePrixGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colVille
            // 
            this.colVille.FieldName = "Ville";
            this.colVille.Name = "colVille";
            this.colVille.Visible = true;
            this.colVille.VisibleIndex = 0;
            // 
            // colPrixM21
            // 
            this.colPrixM21.FieldName = "PrixM2";
            this.colPrixM21.Name = "colPrixM21";
            this.colPrixM21.Visible = true;
            this.colPrixM21.VisibleIndex = 1;
            // 
            // colPrixTerrainM2
            // 
            this.colPrixTerrainM2.FieldName = "PrixTerrainM2";
            this.colPrixTerrainM2.Name = "colPrixTerrainM2";
            this.colPrixTerrainM2.Visible = true;
            this.colPrixTerrainM2.VisibleIndex = 2;
            // 
            // colCount
            // 
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 3;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 672);
            this.Controls.Add(this.villePrixGridControl);
            this.Controls.Add(withPiscineLabel);
            this.Controls.Add(this.withPiscineCheckEdit);
            this.Controls.Add(filterOnPiscineLabel);
            this.Controls.Add(this.filterOnPiscineCheckEdit);
            this.Controls.Add(prixCalculeMoins10Label);
            this.Controls.Add(this.prixCalculeMoins10SpinEdit);
            this.Controls.Add(prixTerrainMCarreLabel);
            this.Controls.Add(this.prixTerrainMCarreSpinEdit);
            this.Controls.Add(prixSurfaceMCarreLabel);
            this.Controls.Add(this.prixSurfaceMCarreSpinEdit);
            this.Controls.Add(prixCalculeLabel);
            this.Controls.Add(this.prixCalculeSpinEdit);
            this.Controls.Add(prixProposeLabel);
            this.Controls.Add(this.prixProposeSpinEdit);
            this.Controls.Add(surfaceLabel);
            this.Controls.Add(this.surfaceSpinEdit);
            this.Controls.Add(terrainLabel);
            this.Controls.Add(this.terrainSpinEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.variationTerrainSpinEdit);
            this.Controls.Add(this.variationSurfaceSpinEdit);
            this.Controls.Add(this.terrainCibleSpinEdit);
            this.Controls.Add(this.surfaceCibleSpinEdit);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.terrainMaxTrackBar);
            this.Controls.Add(this.terrainMinTrackBar);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.surfaceMaxLabel2);
            this.Controls.Add(this.surfaceMinLabel1);
            this.Controls.Add(this.terrainMaxLabel2);
            this.Controls.Add(this.terrainMinLabel1);
            this.Controls.Add(surfaceMaxLabel);
            this.Controls.Add(this.surfaceMaxTrackBar);
            this.Controls.Add(this.surfaceMinTrackBar);
            this.Controls.Add(terrainMaxLabel);
            this.Controls.Add(this.annonceGridControl);
            this.Name = "FormTable";
            this.Text = "FormTable";
            ((System.ComponentModel.ISupportInitialize)(this.annonceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceMaxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceMinTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainMaxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainMinTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annonceGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceCibleSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainCibleSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variationSurfaceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variationTerrainSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixCalculeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixProposeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixSurfaceMCarreSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixTerrainMCarreSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixCalculeMoins10SpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterOnPiscineCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withPiscineCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villePrixBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villePrixGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource annonceBindingSource;
        private System.Windows.Forms.BindingSource criteriaBindingSource;
        private System.Windows.Forms.TrackBar surfaceMaxTrackBar;
        private System.Windows.Forms.TrackBar surfaceMinTrackBar;
        private System.Windows.Forms.TrackBar terrainMaxTrackBar;
        private System.Windows.Forms.TrackBar terrainMinTrackBar;
        private System.Windows.Forms.Label surfaceMaxLabel2;
        private System.Windows.Forms.Label surfaceMinLabel1;
        private System.Windows.Forms.Label terrainMaxLabel2;
        private System.Windows.Forms.Label terrainMinLabel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colVillage;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colConstructionYear;
        private DevExpress.XtraGrid.Columns.GridColumn colSurface;
        private DevExpress.XtraGrid.Columns.GridColumn colTerrain;
        private DevExpress.XtraGrid.Columns.GridColumn colPiscine;
        private DevExpress.XtraGrid.Columns.GridColumn colChambres;
        private DevExpress.XtraGrid.Columns.GridColumn colPrixM2;
        private DevExpress.XtraGrid.GridControl annonceGridControl;
        private Button btnRefresh;
        private Label lblCount;
        private DevExpress.XtraEditors.SpinEdit surfaceCibleSpinEdit;
        private DevExpress.XtraEditors.SpinEdit terrainCibleSpinEdit;
        private DevExpress.XtraEditors.SpinEdit variationSurfaceSpinEdit;
        private DevExpress.XtraEditors.SpinEdit variationTerrainSpinEdit;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private Label label1;
        private Label label2;
        private BindingSource productBindingSource;
        private DevExpress.XtraEditors.SpinEdit prixCalculeSpinEdit;
        private DevExpress.XtraEditors.SpinEdit prixProposeSpinEdit;
        private DevExpress.XtraEditors.SpinEdit surfaceSpinEdit;
        private DevExpress.XtraEditors.SpinEdit terrainSpinEdit;
        private DevExpress.XtraEditors.SpinEdit prixSurfaceMCarreSpinEdit;
        private DevExpress.XtraEditors.SpinEdit prixTerrainMCarreSpinEdit;
        private DevExpress.XtraEditors.SpinEdit prixCalculeMoins10SpinEdit;
        private DevExpress.XtraEditors.CheckEdit filterOnPiscineCheckEdit;
        private DevExpress.XtraEditors.CheckEdit withPiscineCheckEdit;
        private BindingSource villePrixBindingSource;
        private DevExpress.XtraGrid.GridControl villePrixGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colVille;
        private DevExpress.XtraGrid.Columns.GridColumn colPrixM21;
        private DevExpress.XtraGrid.Columns.GridColumn colPrixTerrainM2;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
    }
}