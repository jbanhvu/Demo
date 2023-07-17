namespace Demo
{
    partial class Form2
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
            this.diagram = new DevExpress.XtraDiagram.DiagramControl();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // diagram
            // 
            this.diagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram.Location = new System.Drawing.Point(0, 0);
            this.diagram.Name = "diagram";
            this.diagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagram.Size = new System.Drawing.Size(800, 450);
            this.diagram.TabIndex = 0;
            this.diagram.Text = "diagramControl1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diagram);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagram;
    }
}