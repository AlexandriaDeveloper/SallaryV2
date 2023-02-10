using NPOI.SS.UserModel;
using System.Data;

namespace Application.Services
{
    public class NPOIService
    {
        IWorkbook _workbook;
        ISheet _sheet;
        DataTable dt;
        public NPOIService()
        {

        }
        public DataTable ReadFile(string filePath, string sheetName)
        {
            string ext = Path.GetExtension(filePath).ToLower();
            _workbook = WorkbookFactory.Create(filePath);
            ISheet sheet = _workbook.GetSheet(sheetName);
            if (dt == null)
            {
                dt = new DataTable();
                CreateTableHeader(sheet);
            }

            SheetToDataTable(sheet);

            return dt;
        }

        private void CreateTableHeader(ISheet sheet)
        {


            IRow headerRow = sheet.GetRow(sheet.FirstRowNum);
            for (int i = 0; i < headerRow.LastCellNum; i++)
            {
                ICell headerCell = headerRow.GetCell(i);

                // int colIndex = headerCell.ColumnIndex;
                if (headerCell == null)
                {
                    headerCell = headerRow.CreateCell(i);
                    headerCell.SetCellValue("Blank_" + i);
                }
                if (headerCell.CellType == CellType.String)
                    dt.Columns.Add(headerCell.StringCellValue.Trim());
            }
            //return dt;

        }

        private DataTable SheetToDataTable(ISheet sheet)
        {

            if (dt == null)
            {
                dt = new DataTable();
            }
            int rowIndex = 0;
            foreach (IRow row in sheet)
            {
                // skip header row 
                if (rowIndex++ == 0) continue;
                DataRow dataRow = dt.NewRow();

                for (int i = 0; i < row.LastCellNum; i++)
                {

                    var currentCell = row.GetCell(i);
                    if (currentCell == null)
                    {
                        currentCell = row.CreateCell(i);
                    }
                    if (currentCell.CellType == CellType.String)
                    {


                        dataRow[i] = currentCell.StringCellValue;
                    }
                    if (currentCell.CellType == CellType.Numeric)
                        dataRow[i] = currentCell.NumericCellValue.ToString();
                    if (currentCell.CellType == CellType.Formula)
                    {
                        // dataRow[i] = this.helper.EvaluateInCell(currentCell);

                    }
                }

                dt.Rows.Add(dataRow);
            }
            return dt;
        }
    }
}
