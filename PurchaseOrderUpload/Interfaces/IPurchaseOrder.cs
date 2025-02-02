﻿namespace InventoryBeginners.Interfaces
{
    public interface IPurchaseOrder
    {
        public string GetErrors();

        PaginatedList<PoHeader> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5);
        PoHeader GetItem(int id); // read particular item

        bool Create(PoHeader poHeader);
        bool Edit(PoHeader poHeader);
        bool Delete(PoHeader poHeader);

        public bool IsPoNumberExists(string poNumber);
        public bool IsPoNumberExists(string poNumber, int Id);

        public bool IsQuotationNoExists(string quoNumber);
        public bool IsQuotationNoExists(string quoNumber, int Id);

        public string GetNewPONumber();

    }
}
