using DevExpress.CodeParser;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Demo
{
    public partial class RptDuTruVatTu : DevExpress.XtraReports.UI.XtraReport
    {
        readonly AccessData _ac = new AccessData("Data Source=172.16.0.235;Initial Catalog=CNY_TDG;Persist Security Info=True;User ID=vuda;Password=VTStek@123");
        DataTable dt;
        DataTable dc;

        public DataTable sp_MaterialRequirement_Select()
        {
            var arrPara = new SqlParameter[1];
            arrPara[0] = new SqlParameter("@PK", SqlDbType.BigInt) { Value = -1};
            return _ac.TblReadDataSP("sp_MaterialRequirement_Select", arrPara);
        }
        public DataTable sp_MaterialRequirementDetail_Select()
        {
            var arrPara = new SqlParameter[1];
            arrPara[0] = new SqlParameter("@MaterialRequirementPK" , SqlDbType.BigInt) { Value = 2};
            return _ac.TblReadDataSP("sp_MaterialRequirementDetail_Select", arrPara);
        }
        public RptDuTruVatTu()
        {
            InitializeComponent();
            dt = sp_MaterialRequirementDetail_Select();
            dc = sp_MaterialRequirement_Select();
            NameRequester.Text = NameRequester.Text + dc.Rows[0]["Requester"].ToString();
            NameProject.Text = NameProject.Text + dc.Rows[0]["ProjectName"].ToString();
            ProjectPK.Text = ProjectPK.Text + dc.Rows[0]["ProjectCode"].ToString();
            ChucVu.Text = ChucVu.Text + dc.Rows[0]["Position"].ToString();
            BoPhan.Text = BoPhan.Text + dc.Rows[0]["Department"].ToString();
            lblMucDoYeuCau.Text = dc.Rows[0]["CriticalLevel"].ToString();


            DataSet ds = new DataSet();
            dt = sp_MaterialRequirementDetail_Select();
            ds.Tables.Add(dt);
            this.DataSource = ds;
        }

    }
}
