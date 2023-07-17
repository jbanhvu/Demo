using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using System.Drawing;
using DevExpress.XtraPrinting.Shape;
using System.Drawing.Drawing2D;
using DevExpress.Utils;

namespace Demo
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
            ShowRptBaoGia();
        }
        void ShowRptBaoGia()
        {
            ReportPrintTool printTool = new ReportPrintTool(new RptTest());
            printTool.ShowPreview();
            // Xuất báo cáo
            printTool.ShowPreview();
        }
        public void Show4()
        {
            ReportPrintTool printTool = new ReportPrintTool(new RptDemo());
            printTool.ShowPreview();
            // Xuất báo cáo
            printTool.ShowPreview();

        }
    }
}
