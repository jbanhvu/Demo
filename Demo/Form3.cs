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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            diagramConnector2.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            diagramShape3.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            diagramShape3.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Accent1;
        }
    }
}
