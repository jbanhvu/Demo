using DevExpress.Diagram.Core;
using DevExpress.XtraCharts;
using DevExpress.XtraDiagram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DiagramShape diagramItem = new DiagramShape();
            diagramItem.Height = 50;
            diagramItem.Width = 100;
            diagramItem.Position = new DevExpress.Utils.PointFloat(300, 300);
            diagramItem.Shape = BasicShapes.Ellipse;
            diagram.Items.Add(diagramItem);

            DiagramShape diagramItem2 = new DiagramShape();
            diagramItem2.Height = 100;
            diagramItem2.Width = 100;
            diagramItem2.Position = new DevExpress.Utils.PointFloat(500, 275);
            diagramItem2.Shape = BasicShapes.Rectangle;
            diagram.Items.Add(diagramItem2);

            DiagramConnector connector = new DiagramConnector();
            connector.BeginItem = diagramItem;
            connector.EndItem = diagramItem2;
            diagram.Items.Add(connector);



            DiagramShape diagramItem3= new DiagramShape();
            diagramItem3.Height = 100;
            diagramItem3.Width = 100;
            diagramItem3.Position = new DevExpress.Utils.PointFloat(700, 275);
            diagramItem3.Shape = BasicShapes.Rectangle;
            diagram.Items.Add(diagramItem3);

            DiagramConnector connector2 = new DiagramConnector();
            connector2.BeginItem = diagramItem2;
            connector2.EndItem = diagramItem3;
            diagram.Items.Add(connector2);
        }
    }
}
