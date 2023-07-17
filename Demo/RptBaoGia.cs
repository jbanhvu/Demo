using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Demo
{
    public partial class RptBaoGia : DevExpress.XtraReports.UI.XtraReport
    {
        readonly AccessData _ac = new AccessData("Data Source=172.16.0.235;Initial Catalog=CNY_TDG;Persist Security Info=True;User ID=vuda;Password=VTStek@123");
        DataTable dt;
        public DataTable sp_Quotation_SelectReport()
        {
            var arrpara = new SqlParameter[1];
            arrpara[0] = new SqlParameter("@PK", SqlDbType.BigInt) { Value = 10 };
            return _ac.TblReadDataSP("sp_Quotation_SelectReport", arrpara);
        }
        public DataTable sp_Quotation_Detail_Select()
        {
            var arrpara = new SqlParameter[1];
            arrpara[0] = new SqlParameter("@Quotation_PK", SqlDbType.BigInt) { Value = 10 };
            return _ac.TblReadDataSP("sp_Quotation_Detail_Select ", arrpara);
        }
        public RptBaoGia()
        {
            InitializeComponent();
            dt = sp_Quotation_SelectReport();
            lblTenKhachHang.Text = lblTenKhachHang.Text+ dt.Rows[0]["Customer"].ToString();
            lblNguoiLienHe.Text = lblNguoiLienHe.Text + dt.Rows[0]["Contact_Name"].ToString();
            lblSĐTKhach.Text = lblSĐTKhach.Text + dt.Rows[0]["Contact_Phone"].ToString();
            lblEmailKhach.Text = lblEmailKhach.Text + dt.Rows[0]["Contact_Email"].ToString();
            lblNguoiBaoGia.Text = lblNguoiBaoGia.Text + dt.Rows[0]["User_FullName"].ToString();
            lblNgayBao.Text = lblNgayBao.Text + dt.Rows[0]["Created_Date"].ToString();
            lblSoBaoGia.Text = lblSoBaoGia.Text + dt.Rows[0]["Quotation_No"].ToString();
            lblSĐTNguoiBaoGia.Text = lblSĐTNguoiBaoGia.Text + dt.Rows[0]["User_Phone"].ToString();
            lblEmailNguoiBaoGia.Text = lblEmailNguoiBaoGia.Text + dt.Rows[0]["User_Email"].ToString();
            lblDiDong.Text = lblDiDong.Text + dt.Rows[0]["User_Fax"].ToString();


            //Detail
            DataSet ds = new DataSet();
            dt = sp_Quotation_Detail_Select();
            ds.Tables.Add(dt);
            this.DataSource = ds;
        }


    }
}
