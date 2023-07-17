namespace Demo
{
    partial class Form1
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
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.diagramDataBindingController1 = new DevExpress.XtraDiagram.DiagramDataBindingController(this.components);
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2,
            this.diagramConnector1});
            this.diagramControl1.Location = new System.Drawing.Point(1, 1);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl1.Size = new System.Drawing.Size(593, 430);
            this.diagramControl1.TabIndex = 0;
            this.diagramControl1.Text = "diagramControl1";
            // 
            // diagramDataBindingController1
            // 
            this.diagramDataBindingController1.ConnectorsSource = null;
            this.diagramDataBindingController1.Diagram = this.diagramControl1;
            // 
            // 
            // 
            this.diagramDataBindingController1.TemplateDiagram.Location = new System.Drawing.Point(0, 0);
            this.diagramDataBindingController1.TemplateDiagram.Name = "";
            this.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "TemplateDesigner"});
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = false;
            this.diagramDataBindingController1.TemplateDiagram.TabIndex = 0;
            // 
            // diagramShape1
            // 
            this.diagramShape1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.diagramShape1.Content = "sdasd";
            this.diagramShape1.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(150F, 250F);
            this.diagramShape1.Shape = DevExpress.Diagram.Core.BasicFlowchartShapes.Process;
            this.diagramShape1.Size = new System.Drawing.SizeF(100F, 75F);
            this.diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2;
            // 
            // diagramShape2
            // 
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(700F, 250F);
            this.diagramShape2.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape2.Size = new System.Drawing.SizeF(100F, 75F);
            // 
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginItem = this.diagramShape1;
            this.diagramConnector1.BeginItemPointIndex = 2;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(250F, 175F);
            this.diagramConnector1.EndItem = this.diagramShape2;
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(700F, 287.5F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(200F, 342F),
            new DevExpress.Utils.PointFloat(683F, 342F),
            new DevExpress.Utils.PointFloat(683F, 287.5F)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 431);
            this.Controls.Add(this.diagramControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
        private DevExpress.XtraDiagram.DiagramDataBindingController diagramDataBindingController1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape2;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector1;
    }
}

