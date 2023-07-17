using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace Demo
{
    public partial class OrgChart : Form
    {
      
        public OrgChart()
        {
            InitializeComponent();
            OrgChart1 chart = new OrgChart1();
            diagramOrgChartController1.UpdateItem += diagramOrgChartController1_UpdateItem;
            diagramOrgChartController1.DataSource = chart.Data;
            diagramOrgChartController1.ParentMember = "ParentId";
            diagramOrgChartController1.KeyMember = "Id";

        }
        void diagramOrgChartController1_UpdateItem(object sender, DevExpress.XtraDiagram.DiagramUpdateItemEventArgs e)
        {
            Employee contact = e.Item.DataContext as Employee;

            if (contact != null)
            {
                switch (contact.Level)
                {
                    case 0:
                        e.Item.Appearance.BackColor = Color.Green;
                        break;
                    case 1:
                        e.Item.Appearance.BackColor = Color.Gray;
                        break;
                    case 2:
                        e.Item.Appearance.BackColor = Color.Orange;
                        break;
                    case 3:
                        e.Item.Appearance.BackColor = Color.Thistle;
                        break;
                    case 4:
                        e.Item.Appearance.BackColor = Color.Blue;
                        break;
                    case 5:
                        e.Item.Appearance.BackColor = Color.Red;
                        break;

                }
            }
        }
    }
    public class OrgChart1
    {
        public List<Employee> Data { get; set; }
        public OrgChart1()
        {
            Data = new List<Employee>();
            Data.Add(new Employee() { Id = 0, Title = "Sale Key",Name = "Mr. Bính " ,Level=1});
            Data.Add(new Employee() { Id = 1, ParentId = 0,Title= "Giám đốc, Các phòng ban, PM dự án... tham mưu đưa ra MAP dự án khi làm phiếu tiếp nhận thông tin", Name = "", Level = 2 });
            Data.Add(new Employee() { Id = 2, ParentId = 0, Title = "Project Department", Level = 2 });
            Data.Add(new Employee() { Id = 3, ParentId = 2, Title = "Chief  Electrical Engineer",  Level = 3  });
            Data.Add(new Employee() { Id = 4, ParentId = 3, Name = "Engineer 1", Level = 4 });
            Data.Add(new Employee() { Id = 5, ParentId = 3, Name = "Engineer 1", Level = 4 });
            Data.Add(new Employee() { Id = 6, ParentId = 2, Name = "Chief  Mechanical Engineer", Level = 3 });
            Data.Add(new Employee() { Id = 7, ParentId =6, Name = "Engineer 1", Level = 4 });
            Data.Add(new Employee() { Id = 8, ParentId = 6, Name = "Engineer 1", Level = 4 });
            Data.Add(new Employee() { Id = 9, ParentId = 2, Name = "Chief  Mechanical Engineer", Level = 3 });
            Data.Add(new Employee() { Id = 10, ParentId = 9, Name = "Engineer 1", Level = 4 });
            Data.Add(new Employee() { Id = 11, ParentId = 9, Name = "Engineer 1", Level = 4 });
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
    
}
