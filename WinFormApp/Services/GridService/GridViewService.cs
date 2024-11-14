using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace WinFormApp.Services.GridService
{
    // GridView sluzba pro pristup k vlastnostem a prvkum mimo View
    // Umoznit tyto vlastnosti danemu View Modelu
    public class GridViewService : IGridViewService
    {
        private readonly GridView _gridView = null!;

        public GridViewService(GridView gridView)
        {
            _gridView = gridView;
        }

        public void SetColumnError(int rowHandle, GridColumn column, string errorMessage)
        {
            _gridView.SetColumnError(column, errorMessage);
        }

        public void DeleteSelectedRows()
        {
            _gridView.DeleteSelectedRows();
        }

        public Int32[] GetSelectedRows()
        {
            return _gridView.GetSelectedRows();
        }

        public string GetFocusedColumnFieldName()
        {
            return _gridView.FocusedColumn.FieldName;
        }

        public object GetCellValue(int rowHandle, string fieldName)
        {
            return _gridView.GetRowCellValue(rowHandle, fieldName);
        }

        public object GetRow(int rowHandle)
        {
            return _gridView.GetRow(rowHandle);
        }

        public int DataRowCount => _gridView.RowCount;
    }
}
