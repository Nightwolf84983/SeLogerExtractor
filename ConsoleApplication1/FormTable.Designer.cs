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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
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
            surfaceMaxLabel = new System.Windows.Forms.Label();
            terrainMaxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.annonceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceMaxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceMinTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainMaxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainMinTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annonceGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // surfaceMaxLabel
            // 
            surfaceMaxLabel.AutoSize = true;
            surfaceMaxLabel.Location = new System.Drawing.Point(12, 22);
            surfaceMaxLabel.Name = "surfaceMaxLabel";
            surfaceMaxLabel.Size = new System.Drawing.Size(50, 13);
            surfaceMaxLabel.TabIndex = 1;
            surfaceMaxLabel.Text = "Surface :";
            // 
            // terrainMaxLabel
            // 
            terrainMaxLabel.AutoSize = true;
            terrainMaxLabel.Location = new System.Drawing.Point(12, 79);
            terrainMaxLabel.Name = "terrainMaxLabel";
            terrainMaxLabel.Size = new System.Drawing.Size(46, 13);
            terrainMaxLabel.TabIndex = 5;
            terrainMaxLabel.Text = "Terrain :";
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
            this.surfaceMaxTrackBar.Location = new System.Drawing.Point(110, 44);
            this.surfaceMaxTrackBar.Maximum = 500;
            this.surfaceMaxTrackBar.Name = "surfaceMaxTrackBar";
            this.surfaceMaxTrackBar.Size = new System.Drawing.Size(555, 45);
            this.surfaceMaxTrackBar.TabIndex = 2;
            // 
            // surfaceMinTrackBar
            // 
            this.surfaceMinTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.criteriaBindingSource, "SurfaceMin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.surfaceMinTrackBar.Location = new System.Drawing.Point(110, 12);
            this.surfaceMinTrackBar.Maximum = 500;
            this.surfaceMinTrackBar.Name = "surfaceMinTrackBar";
            this.surfaceMinTrackBar.Size = new System.Drawing.Size(555, 45);
            this.surfaceMinTrackBar.TabIndex = 4;
            // 
            // terrainMaxTrackBar
            // 
            this.terrainMaxTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.criteriaBindingSource, "TerrainMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.terrainMaxTrackBar.Location = new System.Drawing.Point(110, 113);
            this.terrainMaxTrackBar.Maximum = 2000;
            this.terrainMaxTrackBar.Name = "terrainMaxTrackBar";
            this.terrainMaxTrackBar.Size = new System.Drawing.Size(555, 45);
            this.terrainMaxTrackBar.TabIndex = 6;
            // 
            // terrainMinTrackBar
            // 
            this.terrainMinTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.criteriaBindingSource, "TerrainMin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.terrainMinTrackBar.Location = new System.Drawing.Point(110, 79);
            this.terrainMinTrackBar.Maximum = 2000;
            this.terrainMinTrackBar.Name = "terrainMinTrackBar";
            this.terrainMinTrackBar.Size = new System.Drawing.Size(555, 45);
            this.terrainMinTrackBar.TabIndex = 8;
            // 
            // surfaceMaxLabel2
            // 
            this.surfaceMaxLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criteriaBindingSource, "SurfaceMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.surfaceMaxLabel2.Location = new System.Drawing.Point(671, 44);
            this.surfaceMaxLabel2.Name = "surfaceMaxLabel2";
            this.surfaceMaxLabel2.Size = new System.Drawing.Size(100, 23);
            this.surfaceMaxLabel2.TabIndex = 9;
            this.surfaceMaxLabel2.Text = "label1";
            // 
            // surfaceMinLabel1
            // 
            this.surfaceMinLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criteriaBindingSource, "SurfaceMin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.surfaceMinLabel1.Location = new System.Drawing.Point(671, 12);
            this.surfaceMinLabel1.Name = "surfaceMinLabel1";
            this.surfaceMinLabel1.Size = new System.Drawing.Size(100, 23);
            this.surfaceMinLabel1.TabIndex = 11;
            this.surfaceMinLabel1.Text = "label1";
            // 
            // terrainMaxLabel2
            // 
            this.terrainMaxLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criteriaBindingSource, "TerrainMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.terrainMaxLabel2.Location = new System.Drawing.Point(671, 113);
            this.terrainMaxLabel2.Name = "terrainMaxLabel2";
            this.terrainMaxLabel2.Size = new System.Drawing.Size(100, 23);
            this.terrainMaxLabel2.TabIndex = 13;
            this.terrainMaxLabel2.Text = "label1";
            // 
            // terrainMinLabel1
            // 
            this.terrainMinLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criteriaBindingSource, "TerrainMin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.terrainMinLabel1.Location = new System.Drawing.Point(671, 79);
            this.terrainMinLabel1.Name = "terrainMinLabel1";
            this.terrainMinLabel1.Size = new System.Drawing.Size(100, 23);
            this.terrainMinLabel1.TabIndex = 15;
            this.terrainMinLabel1.Text = "label1";
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
            this.annonceGridControl.DataSource = this.annonceBindingSource;
            gridLevelNode1.RelationName = "Attributs";
            this.annonceGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.annonceGridControl.Location = new System.Drawing.Point(0, 194);
            this.annonceGridControl.MainView = this.gridView1;
            this.annonceGridControl.Name = "annonceGridControl";
            this.annonceGridControl.Size = new System.Drawing.Size(1103, 323);
            this.annonceGridControl.TabIndex = 1;
            this.annonceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1008, 22);
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
            this.lblCount.Location = new System.Drawing.Point(13, 175);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 17;
            this.lblCount.Text = "label1";
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 537);
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
    }
}