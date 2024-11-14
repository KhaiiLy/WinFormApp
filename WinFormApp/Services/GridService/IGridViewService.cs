namespace WinFormApp.Services.GridService
{
    // Rozhrani pro implementaci metod, potrebnych k pristupu Grid elementu a vlastnosti
    public interface IGridViewService
    {
        object GetRow(int rowHandle);
        object GetCellValue(int rowHandle, string fieldName);
        string GetFocusedColumnFieldName();
        Int32[] GetSelectedRows();
        void DeleteSelectedRows();
        void SetColumnError(int rowHandle, DevExpress.XtraGrid.Columns.GridColumn column, string errorMessage);
        int DataRowCount { get; }
    }
}
