namespace Demo
{
    partial class Form3
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
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector2 = new DevExpress.XtraDiagram.DiagramConnector();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2,
            this.diagramConnector1,
            this.diagramShape3,
            this.diagramConnector2});
            this.diagramControl1.Location = new System.Drawing.Point(0, 0);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl1.Size = new System.Drawing.Size(800, 450);
            this.diagramControl1.TabIndex = 0;
            this.diagramControl1.Text = "diagramControl1";
            // 
            // diagramShape1
            // 
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(50F, 200F);
            this.diagramShape1.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape1.Size = new System.Drawing.SizeF(150F, 100F);
            this.diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2;
            // 
            // diagramShape2
            // 
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(400F, 200F);
            this.diagramShape2.Size = new System.Drawing.SizeF(200F, 75F);
            this.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2;
            // 
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(200F, 250F);
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(400F, 250F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            // 
            // diagramShape3
            // 
            this.diagramShape3.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(800F, 200F);
            this.diagramShape3.Size = new System.Drawing.SizeF(200F, 75F);
            this.diagramShape3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2;
            // 
            // diagramConnector2
            // 
            this.diagramConnector2.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector2.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.diagramConnector2.BeginPoint = new DevExpress.Utils.PointFloat(600F, 250F);
            this.diagramConnector2.EndPoint = new DevExpress.Utils.PointFloat(800F, 250F);
            this.diagramConnector2.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diagramControl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape2;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape3;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector2;
    }
}