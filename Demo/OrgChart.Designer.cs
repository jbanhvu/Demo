
namespace Demo
{
    partial class OrgChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrgChart));
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.diagramOrgChartController1 = new DevExpress.XtraDiagram.DiagramOrgChartController(this.components);
            this.diagramContainer1 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.standardReportDesigner1 = new DevExpress.XtraReports.UserDesigner.Native.StandardReportDesigner();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl1.Location = new System.Drawing.Point(21, 71);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl1.Size = new System.Drawing.Size(404, 157);
            this.diagramControl1.TabIndex = 0;
            this.diagramControl1.Text = "diagramControl1";
            // 
            // diagramOrgChartController1
            // 
            this.diagramOrgChartController1.Diagram = this.diagramControl1;
            this.diagramOrgChartController1.ExpandSubordinatesButtonMode = DevExpress.Diagram.Core.ExpandSubordinatesButtonMode.LookupChildrenInSource;
            this.diagramOrgChartController1.KeyMember = "";
            this.diagramOrgChartController1.ParentMember = "";
            // 
            // 
            // 
            this.diagramOrgChartController1.TemplateDiagram.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramContainer1});
            this.diagramOrgChartController1.TemplateDiagram.Location = new System.Drawing.Point(0, 0);
            this.diagramOrgChartController1.TemplateDiagram.Name = "";
            this.diagramOrgChartController1.TemplateDiagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "TemplateDesigner"});
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.ShowPageBreaks = false;
            this.diagramOrgChartController1.TemplateDiagram.TabIndex = 0;
            // 
            // diagramContainer1
            // 
            this.diagramContainer1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramContainer1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramContainer1.Appearance.BorderSize = 0;
            this.diagramContainer1.CanAddItems = false;
            this.diagramContainer1.CanCopyWithoutParent = true;
            this.diagramContainer1.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F),
            new DevExpress.Utils.PointFloat(0F, 0.5F)});
            this.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2});
            this.diagramContainer1.ItemsCanAttachConnectorBeginPoint = false;
            this.diagramContainer1.ItemsCanAttachConnectorEndPoint = false;
            this.diagramContainer1.ItemsCanChangeParent = false;
            this.diagramContainer1.ItemsCanCopyWithoutParent = false;
            this.diagramContainer1.ItemsCanDeleteWithoutParent = false;
            this.diagramContainer1.ItemsCanEdit = false;
            this.diagramContainer1.ItemsCanMove = false;
            this.diagramContainer1.ItemsCanResize = false;
            this.diagramContainer1.ItemsCanRotate = false;
            this.diagramContainer1.ItemsCanSelect = false;
            this.diagramContainer1.ItemsCanSnapToOtherItems = false;
            this.diagramContainer1.ItemsCanSnapToThisItem = false;
            this.diagramContainer1.MoveWithSubordinates = true;
            this.diagramContainer1.Position = new DevExpress.Utils.PointFloat(370F, 120F);
            this.diagramContainer1.Size = new System.Drawing.SizeF(200F, 200F);
            this.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramShape1
            // 
            this.diagramShape1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape1.Appearance.BorderSize = 0;
            this.diagramShape1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.diagramShape1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diagramShape1.CanAttachConnectorBeginPoint = false;
            this.diagramShape1.CanAttachConnectorEndPoint = false;
            this.diagramShape1.CanChangeParent = false;
            this.diagramShape1.CanCopyWithoutParent = false;
            this.diagramShape1.CanDeleteWithoutParent = false;
            this.diagramShape1.CanEdit = false;
            this.diagramShape1.CanMove = false;
            this.diagramShape1.CanResize = false;
            this.diagramShape1.CanRotate = false;
            this.diagramShape1.CanSelect = false;
            this.diagramShape1.Content = "";
            this.diagramShape1.MoveWithSubordinates = true;
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(0F, 60F);
            this.diagramShape1.Size = new System.Drawing.SizeF(200F, 60F);
            // 
            // diagramShape2
            // 
            this.diagramShape2.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape2.Appearance.BorderSize = 0;
            this.diagramShape2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diagramShape2.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Name"));
            this.diagramShape2.CanAttachConnectorBeginPoint = false;
            this.diagramShape2.CanAttachConnectorEndPoint = false;
            this.diagramShape2.CanChangeParent = false;
            this.diagramShape2.CanCopyWithoutParent = false;
            this.diagramShape2.CanDeleteWithoutParent = false;
            this.diagramShape2.CanEdit = false;
            this.diagramShape2.CanMove = false;
            this.diagramShape2.CanResize = false;
            this.diagramShape2.CanRotate = false;
            this.diagramShape2.CanSelect = false;
            this.diagramShape2.MoveWithSubordinates = true;
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(50F, 70F);
            this.diagramShape2.Size = new System.Drawing.SizeF(100F, 50F);
           
            this.Name = "OrgChart";
            this.Text = "OrgChart";
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
        private DevExpress.XtraDiagram.DiagramOrgChartController diagramOrgChartController1;
        private DevExpress.XtraDiagram.DiagramContainer diagramContainer1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape2;
        private DevExpress.XtraReports.UserDesigner.Native.StandardReportDesigner standardReportDesigner1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem msiFile;
        private DevExpress.XtraBars.BarSubItem msiEdit;
        private DevExpress.XtraBars.BarSubItem msiTabButtons;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem msiFormat;
        private DevExpress.XtraBars.BarSubItem msiFont;
        private DevExpress.XtraBars.BarSubItem msiJustify;
        private DevExpress.XtraBars.BarSubItem msiAlign;
        private DevExpress.XtraBars.BarSubItem msiSameSize;
        private DevExpress.XtraBars.BarSubItem msiHorizontalSpacing;
        private DevExpress.XtraBars.BarSubItem msiVerticalSpacing;
    }
}