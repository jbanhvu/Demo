using DevExpress.Diagram.Core;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ViewModel viewModel = new ViewModel();
            diagramDataBindingController1.GenerateItem += DiagramDataBindingController1_GenerateItem;
            diagramDataBindingController1.DataSource = viewModel.Items;
            diagramDataBindingController1.KeyMember = "Id";
            diagramDataBindingController1.ConnectorsSource = viewModel.Connections;
            diagramDataBindingController1.ConnectorFromMember = "From";
            diagramDataBindingController1.ConnectorToMember = "To";
            diagramDataBindingController1.LayoutKind = DiagramLayoutKind.Circular;
        }
        private void DiagramDataBindingController1_GenerateItem(object sender, DiagramGenerateItemEventArgs e)
        {
            var item = new DiagramShape
            {
                X = 27,
                Width = 175,
                Height = 150,
                Shape = BasicShapes.Rectangle
            };
            item.Bindings.Add(new DiagramBinding("Content", "Name"));
            e.Item = item;
        }
    }
}
