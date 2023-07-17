
namespace Demo
{
    partial class BandGridview
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProduct_Code = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSpecification = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDelivery_Date_1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDelivery_Qty_3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDelivery_Date_3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDelivery_Qty_2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDelivery_Date_2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDelivery_Qty_1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colQutsource = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colBudget = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNote = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(33, 30);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1049, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand6,
            this.gridBand7,
            this.gridBand9});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colProduct_Code,
            this.colProduct_Name,
            this.colSpecification,
            this.colUnit,
            this.colQuantity,
            this.colDelivery_Date_1,
            this.colDelivery_Qty_1,
            this.colDelivery_Date_2,
            this.colDelivery_Qty_2,
            this.colDelivery_Date_3,
            this.colDelivery_Qty_3,
            this.colQutsource,
            this.colBudget,
            this.colNote});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colProduct_Code);
            this.gridBand1.Columns.Add(this.colProduct_Name);
            this.gridBand1.Columns.Add(this.colSpecification);
            this.gridBand1.Columns.Add(this.colUnit);
            this.gridBand1.Columns.Add(this.colQuantity);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 469;
            // 
            // colProduct_Code
            // 
            this.colProduct_Code.Caption = "Product Code";
            this.colProduct_Code.Name = "colProduct_Code";
            this.colProduct_Code.Visible = true;
            this.colProduct_Code.Width = 106;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Product Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.Width = 97;
            // 
            // colSpecification
            // 
            this.colSpecification.Caption = "Specification";
            this.colSpecification.Name = "colSpecification";
            this.colSpecification.Visible = true;
            this.colSpecification.Width = 97;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.Width = 71;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.Width = 98;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Delivery Time";
            this.gridBand2.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3,
            this.gridBand4,
            this.gridBand5});
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 342;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Phrase 1";
            this.gridBand3.Columns.Add(this.colDelivery_Date_1);
            this.gridBand3.Columns.Add(this.colDelivery_Qty_3);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 0;
            this.gridBand3.Width = 133;
            // 
            // colDelivery_Date_1
            // 
            this.colDelivery_Date_1.Caption = "Date";
            this.colDelivery_Date_1.Name = "colDelivery_Date_1";
            this.colDelivery_Date_1.Visible = true;
            this.colDelivery_Date_1.Width = 61;
            // 
            // colDelivery_Qty_3
            // 
            this.colDelivery_Qty_3.Caption = "Qty";
            this.colDelivery_Qty_3.Name = "colDelivery_Qty_3";
            this.colDelivery_Qty_3.Visible = true;
            this.colDelivery_Qty_3.Width = 72;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Phrase 2";
            this.gridBand4.Columns.Add(this.colDelivery_Date_3);
            this.gridBand4.Columns.Add(this.colDelivery_Qty_2);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 1;
            this.gridBand4.Width = 116;
            // 
            // colDelivery_Date_3
            // 
            this.colDelivery_Date_3.Caption = "Date";
            this.colDelivery_Date_3.Name = "colDelivery_Date_3";
            this.colDelivery_Date_3.Visible = true;
            this.colDelivery_Date_3.Width = 54;
            // 
            // colDelivery_Qty_2
            // 
            this.colDelivery_Qty_2.Caption = "Qty";
            this.colDelivery_Qty_2.Name = "colDelivery_Qty_2";
            this.colDelivery_Qty_2.Visible = true;
            this.colDelivery_Qty_2.Width = 62;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Phrase 3";
            this.gridBand5.Columns.Add(this.colDelivery_Date_2);
            this.gridBand5.Columns.Add(this.colDelivery_Qty_1);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 2;
            this.gridBand5.Width = 93;
            // 
            // colDelivery_Date_2
            // 
            this.colDelivery_Date_2.Caption = "Date";
            this.colDelivery_Date_2.Name = "colDelivery_Date_2";
            this.colDelivery_Date_2.Visible = true;
            this.colDelivery_Date_2.Width = 43;
            // 
            // colDelivery_Qty_1
            // 
            this.colDelivery_Qty_1.Caption = "Qty";
            this.colDelivery_Qty_1.Name = "colDelivery_Qty_1";
            this.colDelivery_Qty_1.Visible = true;
            this.colDelivery_Qty_1.Width = 50;
            // 
            // gridBand6
            // 
            this.gridBand6.Columns.Add(this.colQutsource);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 2;
            this.gridBand6.Width = 114;
            // 
            // colQutsource
            // 
            this.colQutsource.Caption = "Qutsource";
            this.colQutsource.Name = "colQutsource";
            this.colQutsource.Visible = true;
            this.colQutsource.Width = 114;
            // 
            // gridBand7
            // 
            this.gridBand7.Caption = "Document";
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 3;
            this.gridBand7.Width = 51;
            // 
            // gridBand9
            // 
            this.gridBand9.Caption = "gridBand9";
            this.gridBand9.Columns.Add(this.colBudget);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.VisibleIndex = 4;
            this.gridBand9.Width = 27;
            // 
            // colBudget
            // 
            this.colBudget.Caption = "Budget";
            this.colBudget.Name = "colBudget";
            this.colBudget.Visible = true;
            this.colBudget.Width = 27;
            // 
            // colNote
            // 
            this.colNote.Caption = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.Width = 55;
            // 
            // BandGridview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 492);
            this.Controls.Add(this.gridControl1);
            this.Name = "BandGridview";
            this.Text = "BandGridview";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Code;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDelivery_Date_3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDelivery_Qty_3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSpecification;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDelivery_Date_2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDelivery_Qty_2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDelivery_Date_1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDelivery_Qty_1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQutsource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBudget;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNote;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
    }
}