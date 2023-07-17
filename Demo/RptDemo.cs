using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;

namespace Demo
{
    public partial class RptDemo : DevExpress.XtraReports.UI.XtraReport
    {
        readonly AccessData _ac = new AccessData("Data Source=172.16.0.235;Initial Catalog=CNY_TDG;Persist Security Info=True;User ID=vuda;Password=VTStek@123");
        DataTable dt;
        public RptDemo()
        {
            InitializeComponent();
            LoadData();
        }
        public DataTable sp_Survey_Report(Int32 PK)
        {
            var arrpara = new SqlParameter[1];
            arrpara[0] = new SqlParameter("Project_PK", SqlDbType.BigInt) { Value = PK };
            return _ac.TblReadDataSP("sp_User_In_WorkAllocation_SelectForSurvey", arrpara);
        }
        void LoadData()
        {
            dt = sp_Survey_Report(4030);
            setLabel(lblKeySale, "KeySale");
            setLabel(lblProjectDepartment, "ProjectDepartment");

            setLabel(lblChiefElectricalEngineer, "ChiefElectricalEngineer");
            setLabel(lblChiefElectricalEngineerEngineer1, "ChiefElectricalEngineerEngineer1");
            setLabel(lblChiefElectricalEngineerEngineer2, "ChiefElectricalEngineerEngineer2");

            setLabel(lblChiefMechanicalEngineer, "ChiefMechanicalEngineer");
            setLabel(lblChiefMechanicalEngineerEngineer1, "ChiefMechanicalEngineerEngineer1");
            setLabel(lblChiefMechanicalEngineerEngineer2, "ChiefMechanicalEngineerEngineer2");

            setLabel(lblProductionDepartment, "ProductionDepartment");
            setLabel(lblProductiondepartmentEngineer1, "ProductionDepartmentEngineer1");
            setLabel(lblProductiondepartmentEngineer2, "ProductionDepartmentEngineer2");
        }
        void setLabel(XRLabel lbl, string columnName)
        {
            var a = dt.AsEnumerable().FirstOrDefault(r => ((string)r["RoleCode"]) == columnName)["FullName"];
            lbl.Text = a.ToString();
        }

    }
}
