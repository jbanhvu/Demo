using DevExpress.XtraMap;
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
    public partial class FrmMapControl : Form
    {
        public FrmMapControl()
        {
            InitializeComponent();
            mapControl1.CenterPoint = new CartesianPoint(-100, -50);
        }
    }
}
