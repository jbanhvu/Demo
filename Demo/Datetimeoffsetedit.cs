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
    public partial class Datetimeoffsetedit : Form
    {
        public Datetimeoffsetedit()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dateEdit1.DateTime.Year,dateEdit1.DateTime.Month,dateEdit1.DateTime.Day,
                timeEdit1.Time.Hour,timeEdit1.Time.Minute,timeEdit1.Time.Second);
            
            MessageBox.Show(dt.ToString());
        }
    }
}
