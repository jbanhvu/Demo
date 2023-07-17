using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPdfViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class GridviewMenu : Form
    {

        List<Product> Products = new List<Product>();
        List<Category> Categories = new List<Category>();
        string _value="";
        public GridviewMenu()
        {
            InitializeComponent();
            InitData();
            DataTable dt = new DataTable();
            DataColumn col = new DataColumn("Test", typeof(string));
            DataColumn col2 = new DataColumn("File", typeof(string));
            DataColumn col3 = new DataColumn("UploadTo", typeof(string));
            DataColumn col4 = new DataColumn("Type", typeof(string));
            dt.Columns.Add(col);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            DataRow row = dt.NewRow();
            row["Test"] = "Project 1";
            dt.Rows.Add(row);

            DataRow row1 = dt.NewRow();
            row1["Test"] = "Project 2";
            dt.Rows.Add(row1);

            DataRow row2 = dt.NewRow();
            row2["Test"] = "Project 3";
            dt.Rows.Add(row2);
            gc1.DataSource = dt;
            gv1.PopupMenuShowing += Gv1_PopupMenuShowing;
            gv1.DoubleClick += Gv1_DoubleClick;
            gv1.ShowingEditor += Gv1_ShowingEditor;
            gv1.FocusedRowChanged += Gv1_FocusedRowChanged;
            pdfViewer1.PopupMenuShowing += PdfViewer1_PopupMenuShowing;

            RepositoryItemLookUpEdit riLookup = new RepositoryItemLookUpEdit();
            riLookup.DataSource = Categories;
            riLookup.ValueMember = "ID";
            riLookup.DisplayMember = "CategoryName";
            riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup.DropDownRows = Categories.Count;
            riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup.DropDownRows = Categories.Count;
            riLookup.AutoSearchColumnIndex = 1;
            gc1.RepositoryItems.Add(riLookup);
            gv1.Columns["Type"].ColumnEdit = riLookup;
            gv1.BestFitColumns();

        }

        private void PdfViewer1_PopupMenuShowing(object sender, PdfPopupMenuShowingEventArgs e)
        {
        }

        private void Gv1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;

        }

        private void Gv1_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName!= "Type")
            {
                e.Cancel = true;
            }
        }

        private void Gv1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "File")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    string UploadTo = "\\\\172.16.0.235\\cny\\Upload File\\Contract\\" + ofd.SafeFileName;
                    File.Copy(ofd.FileName, UploadTo,true);
                    MessageBox.Show("Upload Successfully ");
                    view.SetFocusedRowCellValue("File", ofd.FileName);
                    view.SetFocusedRowCellValue("UploadTo", UploadTo);
                    view.PostEditor();
                    view.CloseEditor();
                    view.RefreshRow(view.FocusedRowHandle);
                }
            }
            else if (view.FocusedColumn.FieldName == "UploadTo")
            {
                string filename = (string)view.GetRowCellValue(view.FocusedRowHandle, "UploadTo");
                this.pdfViewer1.LoadDocument(filename);
                //FileStream stream = new FileStream(filename, FileMode.Open);
                //pdfViewer1.LoadDocument(stream);
            }
        }
        private void Gv1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            _value=view.GetRowCellValue(gv1.FocusedRowHandle, "Test").ToString();
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                DXMenuItem item = new DXMenuItem("Project");
                item.Click += Item_Click;
                DXMenuItem item1 = new DXMenuItem("Meeting");
                item.Click += Item_Click;
                DXMenuItem item3 = new DXMenuItem("Survey");
                item.Click += Item_Click;

                DXSubMenuItem sItem = new DXSubMenuItem("New");
                sItem.Items.Add(item);
                sItem.Items.Add(item1);
                sItem.Items.Add(item3);
                e.Menu.Items.Add(sItem);

                DXMenuItem item2 = new DXMenuItem("Confirm");
                item.Click += Item_Click;
                e.Menu.Items.Add(item2);
            }
        }
        private DXPopupMenu CreatePopupMenu()
        {
            DXPopupMenu menu = new DXPopupMenu();
            //sub items
            DXMenuItem mItem1 = new DXMenuItem("Menu Item 1");
            DXMenuItem mItem2 = new DXMenuItem("Menu Item 2");
            //main item
            DXSubMenuItem sItem = new DXSubMenuItem("Items");
            sItem.Items.Add(mItem1);
            sItem.Items.Add(mItem2);
            menu.Items.Add(sItem);
            return menu;
        }
        private void SubItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Project" + _value);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New "+ _value);
        }
        private void InitData()
        {
            Products.Add(new Product() { ProductName = "Sir Rodney's Scones", CategoryID = 3, UnitPrice = 10 });
            Products.Add(new Product() { ProductName = "Gustaf's Knäckebröd", CategoryID = 5, UnitPrice = 21 });
            Products.Add(new Product() { ProductName = "Tunnbröd", CategoryID = 5, UnitPrice = 9 });
            Products.Add(new Product() { ProductName = "Guaraná Fantástica", CategoryID = 1, UnitPrice = 4.5m });
            Products.Add(new Product() { ProductName = "NuNuCa Nuß-Nougat-Creme", CategoryID = 3, UnitPrice = 14 });
            Products.Add(new Product() { ProductName = "Gumbär Gummibärchen", CategoryID = 3, UnitPrice = 31.23m });
            Products.Add(new Product() { ProductName = "Rössle Sauerkraut", CategoryID = 7, UnitPrice = 45.6m });
            Products.Add(new Product() { ProductName = "Thüringer Rostbratwurst", CategoryID = 6, UnitPrice = 123.79m });
            Products.Add(new Product() { ProductName = "Nord-Ost Matjeshering", CategoryID = 8, UnitPrice = 25.89m });
            Products.Add(new Product() { ProductName = "Gorgonzola Telino", CategoryID = 4, UnitPrice = 12.5m });

            Categories.Add(new Category() { ID = 1, CategoryName = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales" });
            Categories.Add(new Category() { ID = 2, CategoryName = "Condiments", Description = "Sweet and savory sauces, relishes, spreads, and seasonings" });
            Categories.Add(new Category() { ID = 3, CategoryName = "Confections", Description = "Desserts, candies, and sweet breads" });
            Categories.Add(new Category() { ID = 4, CategoryName = "Dairy Products", Description = "Cheeses" });
            Categories.Add(new Category() { ID = 5, CategoryName = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal" });
            Categories.Add(new Category() { ID = 6, CategoryName = "Meat/Poultry", Description = "Prepared meats" });
            Categories.Add(new Category() { ID = 7, CategoryName = "Produce", Description = "Dried fruit and bean curd" });
            Categories.Add(new Category() { ID = 8, CategoryName = "Seafood", Description = "Seaweed and fish" });
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}

