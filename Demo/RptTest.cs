using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Demo
{
    public partial class RptTest : DevExpress.XtraReports.UI.XtraReport
    {
    readonly AccessData _ac = new AccessData("Data Source=172.16.0.235;Initial Catalog=CNY_TDG;Persist Security Info=True;User ID=vuda;Password=VTStek@123");
    DataTable dt;
        public RptTest()
        {
            InitializeComponent();

            //Detail
            DataSet ds = new DataSet();
            dt = sp_Quotation_Detail_Select();
            ds.Tables.Add(dt);
            this.DataSource = ds;
        }
        public DataTable sp_Quotation_Detail_Select()
        {
            var arrpara = new SqlParameter[1];
            arrpara[0] = new SqlParameter("@Quotation_PK", SqlDbType.BigInt) { Value = 11 };
            return _ac.TblReadDataSP("sp_Quotation_Detail_Select ", arrpara);
        }

    }
}
