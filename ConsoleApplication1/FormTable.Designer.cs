using ConsoleApplication1.DataAccess;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.annonceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.annonceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.annonceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.annonceGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVillage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConstructionYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurface = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerrain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPiscine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerrasse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChambres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPieces = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParkings = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrixM2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.annonceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annonceBindingNavigator)).BeginInit();
            this.annonceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.annonceGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // annonceBindingSource
            // 
            this.annonceBindingSource.DataSource = typeof(Annonce);
            // 
            // annonceBindingNavigator
            // 
            this.annonceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.annonceBindingNavigator.BindingSource = this.annonceBindingSource;
            this.annonceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.annonceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.annonceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.annonceBindingNavigatorSaveItem});
            this.annonceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.annonceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.annonceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.annonceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.annonceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.annonceBindingNavigator.Name = "annonceBindingNavigator";
            this.annonceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.annonceBindingNavigator.Size = new System.Drawing.Size(756, 25);
            this.annonceBindingNavigator.TabIndex = 0;
            this.annonceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // annonceBindingNavigatorSaveItem
            // 
            this.annonceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.annonceBindingNavigatorSaveItem.Enabled = false;
            this.annonceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("annonceBindingNavigatorSaveItem.Image")));
            this.annonceBindingNavigatorSaveItem.Name = "annonceBindingNavigatorSaveItem";
            this.annonceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.annonceBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // annonceGridControl
            // 
            this.annonceGridControl.DataSource = this.annonceBindingSource;
            this.annonceGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Attributs";
            this.annonceGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.annonceGridControl.Location = new System.Drawing.Point(0, 25);
            this.annonceGridControl.MainView = this.gridView1;
            this.annonceGridControl.Name = "annonceGridControl";
            this.annonceGridControl.Size = new System.Drawing.Size(756, 492);
            this.annonceGridControl.TabIndex = 1;
            this.annonceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTitle,
            this.colVillage,
            this.colPrice,
            this.colConstructionYear,
            this.colSurface,
            this.colTerrain,
            this.colPiscine,
            this.colTerrasse,
            this.colChambres,
            this.colPieces,
            this.colParkings,
            this.colPrixM2});
            this.gridView1.GridControl = this.annonceGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            // 
            // colVillage
            // 
            this.colVillage.FieldName = "Village";
            this.colVillage.Name = "colVillage";
            this.colVillage.Visible = true;
            this.colVillage.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // colConstructionYear
            // 
            this.colConstructionYear.FieldName = "ConstructionYear";
            this.colConstructionYear.Name = "colConstructionYear";
            this.colConstructionYear.Visible = true;
            this.colConstructionYear.VisibleIndex = 4;
            // 
            // colSurface
            // 
            this.colSurface.FieldName = "Surface";
            this.colSurface.Name = "colSurface";
            this.colSurface.Visible = true;
            this.colSurface.VisibleIndex = 5;
            // 
            // colTerrain
            // 
            this.colTerrain.FieldName = "Terrain";
            this.colTerrain.Name = "colTerrain";
            this.colTerrain.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "Terrain", "{0:n2}")});
            this.colTerrain.Visible = true;
            this.colTerrain.VisibleIndex = 6;
            // 
            // colPiscine
            // 
            this.colPiscine.FieldName = "Piscine";
            this.colPiscine.Name = "colPiscine";
            this.colPiscine.Visible = true;
            this.colPiscine.VisibleIndex = 7;
            // 
            // colTerrasse
            // 
            this.colTerrasse.FieldName = "Terrasse";
            this.colTerrasse.Name = "colTerrasse";
            this.colTerrasse.Visible = true;
            this.colTerrasse.VisibleIndex = 8;
            // 
            // colChambres
            // 
            this.colChambres.FieldName = "Chambres";
            this.colChambres.Name = "colChambres";
            this.colChambres.Visible = true;
            this.colChambres.VisibleIndex = 9;
            // 
            // colPieces
            // 
            this.colPieces.FieldName = "Pieces";
            this.colPieces.Name = "colPieces";
            this.colPieces.Visible = true;
            this.colPieces.VisibleIndex = 10;
            // 
            // colParkings
            // 
            this.colParkings.FieldName = "Parkings";
            this.colParkings.Name = "colParkings";
            this.colParkings.Visible = true;
            this.colParkings.VisibleIndex = 11;
            // 
            // colPrixM2
            // 
            this.colPrixM2.FieldName = "PrixM2";
            this.colPrixM2.Name = "colPrixM2";
            this.colPrixM2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average)});
            this.colPrixM2.Visible = true;
            this.colPrixM2.VisibleIndex = 12;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 517);
            this.Controls.Add(this.annonceGridControl);
            this.Controls.Add(this.annonceBindingNavigator);
            this.Name = "FormTable";
            this.Text = "FormTable";
            ((System.ComponentModel.ISupportInitialize)(this.annonceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annonceBindingNavigator)).EndInit();
            this.annonceBindingNavigator.ResumeLayout(false);
            this.annonceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.annonceGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource annonceBindingSource;
        private System.Windows.Forms.BindingNavigator annonceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton annonceBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl annonceGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colVillage;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colConstructionYear;
        private DevExpress.XtraGrid.Columns.GridColumn colSurface;
        private DevExpress.XtraGrid.Columns.GridColumn colTerrain;
        private DevExpress.XtraGrid.Columns.GridColumn colPiscine;
        private DevExpress.XtraGrid.Columns.GridColumn colTerrasse;
        private DevExpress.XtraGrid.Columns.GridColumn colChambres;
        private DevExpress.XtraGrid.Columns.GridColumn colPieces;
        private DevExpress.XtraGrid.Columns.GridColumn colParkings;
        private DevExpress.XtraGrid.Columns.GridColumn colPrixM2;
    }
}