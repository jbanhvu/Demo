using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using System.Drawing.Drawing2D;
using DevExpress.XtraGrid;

namespace Demo
{
    public partial class FrmDownloadTemplate : Form
    {
        public FrmDownloadTemplate()
        {
            InitializeComponent();
            InitGridview(gridControl1, gridView1);
            btnDownload.Click += BtnDownload_Click;
            btnUpload.Click += BtnUpload_Click;
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            ShowData2();
        }
        private void ShowData2()
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls| Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                   using (var stream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader=ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            DataTable dt = result.Tables[0];
                            gridControl1.DataSource = dt;
                        }
                    }
                }
            }
        }
        private void ShowData1()
        {

            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls| Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);

                    var ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    gridControl1.DataSource = ds.Tables[0];
                }
            }
        }


        private void BtnDownload_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string des = folderBrowserDialog1.SelectedPath.ToString();
            if (!String.IsNullOrEmpty(des))
            {
                File.Copy("\\\\192.168.1.245\\cny\\Template\\Template 1.xlsx", des + "\\" + "Template 1.xlsx");
                MessageBox.Show("Downloaded to " + des);
            }
        }
        #region InitGridview
        private void InitGridview(GridControl gc, GridView gv)
        {
            gc.UseEmbeddedNavigator = true;

            gc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            gc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            gc.EmbeddedNavigator.Buttons.Append.Visible = false;
            gc.EmbeddedNavigator.Buttons.Edit.Visible = false;
            gc.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gv.OptionsBehavior.Editable = false;
            gv.OptionsBehavior.AllowAddRows = DefaultBoolean.False;
            gv.OptionsBehavior.AllowDeleteRows = DefaultBoolean.False;
            gv.OptionsCustomization.AllowColumnMoving = false;
            gv.OptionsCustomization.AllowQuickHideColumns = true;

            gv.OptionsCustomization.AllowSort = true;

            gv.OptionsCustomization.AllowFilter = true;

            gv.OptionsView.AllowCellMerge = false;
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsView.ShowIndicator = true;
            gv.OptionsView.ShowHorizontalLines = DefaultBoolean.True;
            gv.OptionsView.ShowVerticalLines = DefaultBoolean.True;
            gv.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            gv.OptionsView.ShowAutoFilterRow = false;
            gv.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            gv.OptionsView.ColumnAutoWidth = false;

            //  gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;

            gv.OptionsNavigation.AutoFocusNewRow = true;
            gv.OptionsNavigation.UseTabKey = true;

            gv.OptionsSelection.MultiSelect = false;
            gv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            gv.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus;
            gv.OptionsSelection.EnableAppearanceFocusedRow = true;
            gv.OptionsSelection.EnableAppearanceFocusedCell = false;

            gv.OptionsView.EnableAppearanceEvenRow = false;
            gv.OptionsView.EnableAppearanceOddRow = false;
            gv.OptionsView.ShowFooter = false;

            gv.OptionsHint.ShowFooterHints = false;
            gv.OptionsHint.ShowCellHints = false;
            //   gridView1.RowHeight = 25;

            gv.OptionsClipboard.CopyColumnHeaders = DefaultBoolean.False;

            gv.OptionsFind.AllowFindPanel = true;

            gv.OptionsFind.AlwaysVisible = false;
            gv.OptionsFind.ShowCloseButton = true;
            gv.OptionsFind.HighlightFindResults = true;
            gv.RowStyle += gv_RowStyle;
            gv.RowCountChanged += gv_RowCountChanged;
            gv.CustomDrawRowIndicator += gv_CustomDrawRowIndicator;
            gc.ForceInitialize();
        }
        #region "gridview event"
        private void gv_RowCountChanged(object sender, EventArgs e)
        {
            var gv = (GridView)sender;
            if (gv == null) return;
            if (!gv.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gv.GridControl.Handle);
            SizeF size = gr.MeasureString(gv.RowCount.ToString(), gv.PaintAppearance.Row.GetFont());
            gv.IndicatorWidth = Convert.ToInt32(size.Width) + 10;
        }
        private void gv_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            var gv = (GridView)sender;
            if (gv == null) return;
            if (!gv.IsDataRow(e.RowHandle)) return;
            if (!e.Info.IsRowIndicator) return;

            e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            e.Info.DisplayText = (e.RowHandle + 1).ToString();
            e.Info.ImageIndex = -1;
            e.Painter.DrawObject(e.Info);
            e.Handled = true;
            bool selected = gv.IsRowSelected(e.RowHandle);
            if (selected)
            {
                Rectangle rect = e.Bounds;
                Brush brush = new LinearGradientBrush(rect, Color.GreenYellow, Color.Azure, 90);
                rect.Inflate(-1, -1);
                e.Graphics.FillRectangle(brush, rect);
            }

            if (selected)
            {
                e.Appearance.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
                e.Appearance.ForeColor = Color.DarkMagenta;
            }
            else
            {
                e.Appearance.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
                e.Appearance.ForeColor = Color.Black;
            }
            e.Graphics.DrawString(e.Info.DisplayText, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), e.Bounds, e.Appearance.GetStringFormat());

        }
        private void gv_RowStyle(object sender, RowStyleEventArgs e)
        {
            var gv = (GridView)sender;
            if (gv == null) return;
            if (gv.FocusedRowHandle == e.RowHandle)
            {
                e.HighPriority = true;
                e.Appearance.BackColor = Color.FromArgb(169, 249, 108);
                e.Appearance.BackColor2 = Color.FromArgb(246, 248, 247);
                e.Appearance.GradientMode = LinearGradientMode.Horizontal;
            }
        }
        #endregion
        #endregion

        #region Gridview event




        

        private void gvDeliveryList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            var gv = sender as GridView;
            if (gv == null) return;
            if (!gv.IsDataRow(e.RowHandle)) return;
            if (!e.Info.IsRowIndicator) return;

            e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            e.Info.DisplayText = (e.RowHandle + 1).ToString();
            e.Info.ImageIndex = -1;
            e.Painter.DrawObject(e.Info);
            e.Handled = true;

            if (gv.IsRowSelected(e.RowHandle))
            {
                e.Appearance.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
                e.Appearance.ForeColor = Color.DarkMagenta;
            }
            else
            {
                e.Appearance.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
                e.Appearance.ForeColor = Color.Black;
            }
            e.Graphics.DrawString(e.Info.DisplayText, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), e.Bounds, e.Appearance.GetStringFormat());
        }

        private void gvDeliveryList_RowCountChanged(object sender, EventArgs e)
        {
            var gv = sender as GridView;
            Graphics gr = Graphics.FromHwnd(gv.GridControl.Handle);
            SizeF size = gr.MeasureString(gv.RowCount.ToString(), gv.PaintAppearance.Row.GetFont());
            gv.IndicatorWidth = Convert.ToInt32(size.Width) + 10;
        }


        #endregion
    }
}
