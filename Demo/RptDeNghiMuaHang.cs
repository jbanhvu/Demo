using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Demo
{
    public partial class RptDeNghiMuaHang : DevExpress.XtraReports.UI.XtraReport
    {
        readonly AccessData _ac = new AccessData("Data Source=172.16.0.235;Initial Catalog=CNY_TDG;Persist Security Info=True;User ID=vuda;Password=VTStek@123");
        DataTable dt;

        public DataTable sp_MaterialRequestDetail_Select()
        {
            var arrPara = new SqlParameter[1];
            arrPara[0] = new SqlParameter("@MaterialRequestPK", SqlDbType.BigInt) { Value = 2 };
            return _ac.TblReadDataSP("sp_MaterialRequestDetail_Select", arrPara);
        }
        public RptDeNghiMuaHang()
        {
            InitializeComponent();
            dt = sp_MaterialRequestDetail_Select();


            DataSet ds = new DataSet();
            dt = sp_MaterialRequestDetail_Select();
            ds.Tables.Add(dt);
            this.DataSource = ds;
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
