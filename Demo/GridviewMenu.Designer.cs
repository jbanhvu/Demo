
namespace Demo
{
    partial class GridviewMenu
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
            this.gc1 = new DevExpress.XtraGrid.GridControl();
            this.gv1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc1
            // 
            this.gc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc1.Location = new System.Drawing.Point(0, 0);
            this.gc1.MainView = this.gv1;
            this.gc1.Name = "gc1";
            this.gc1.Size = new System.Drawing.Size(1180, 721);
            this.gc1.TabIndex = 0;
            this.gc1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv1});
            // 
            // gv1
            // 
            this.gv1.GridControl = this.gc1;
            this.gv1.Name = "gv1";
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(12, 210);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(1156, 499);
            this.pdfViewer1.TabIndex = 1;
            // 
            // GridviewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 721);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.gc1);
            this.Name = "GridviewMenu";
            this.Text = "GridviewMenu";
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc1;
        private DevExpress.XtraGrid.Views.Grid.GridView gv1;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
    }
}