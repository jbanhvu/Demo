using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;

namespace Demo
{
    public partial class FrmConvertXML : Form
    {
        public FrmConvertXML()
        {
            InitializeComponent();
            // đường dẫn tới file XML
            string filePath = "F:/MISA JSC/MISA SME 2023/Export/Du lieu xuat khau.xml";
            DataSet AuthorsDataSet=new DataSet();
            AuthorsDataSet.ReadXml(filePath);


            // đường dẫn tới file Excel đầu ra
            string excelFilePath = "C:/Users/vufab/Downloads/output.xlsx";

            // tạo một file Excel mới
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(excelFilePath, SpreadsheetDocumentType.Workbook))
            {
                // tạo một WorkbookPart
                WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();

                // tạo một Workbook
                Workbook workbook = new Workbook();

                // tạo các Worksheet và Sheets
                Sheets sheets = new Sheets();
                uint sheetId = 1;
                foreach (DataTable dataTable in AuthorsDataSet.Tables)
                {
                    // tạo một WorksheetPart và một Worksheet cho mỗi DataTable
                    WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                    Worksheet worksheet = new Worksheet();

                    // tạo các cột trong Worksheet
                    Columns columns = new Columns();
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        Column column = new Column() { Min = (uint)i + 1, Max = (uint)i + 1, Width = 20, CustomWidth = true };
                        columns.Append(column);
                    }
                    worksheet.Append(columns);

                    // tạo các hàng và cột dữ liệu trong Worksheet
                    SheetData sheetData = new SheetData();
                    Row headerRow = new Row();
                    foreach (DataColumn dataColumn in dataTable.Columns)
                    {
                        headerRow.Append(CreateCell(dataColumn.ColumnName, CellValues.String));
                    }
                    sheetData.Append(headerRow);
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        Row row = new Row();
                        foreach (DataColumn dataColumn in dataTable.Columns)
                        {
                            row.Append(CreateCell(dataRow[dataColumn.ColumnName].ToString(), CellValues.String));
                        }
                        sheetData.Append(row);
                    }
                    worksheet.Append(sheetData);

                    // đặt tên cho Sheet và thêm nó vào Sheets
                    Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = sheetId, Name = dataTable.TableName };
                    sheets.Append(sheet);

                    // thêm WorksheetPart vào WorkbookPart
                    worksheetPart.Worksheet = worksheet;
                    worksheetPart.Worksheet.Save();

                    sheetId++;
                }

                // thêm Sheets vào Workbook và WorkbookPart
                workbook.Append(sheets);
                workbookPart.Workbook = workbook;
                workbookPart.Workbook.Save();
            }

        }
        // phương thức trợ giúp để tạo một Cell mới
        private static Cell CreateCell(string text, CellValues dataType)
        {
            Cell cell = new Cell();
            cell.DataType = new EnumValue<CellValues>(dataType);
            cell.CellValue = new CellValue(text);
            return cell;
        }


    }
}
