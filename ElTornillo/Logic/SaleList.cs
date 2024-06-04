using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class SaleList
    {

        private List<Sale> saleList;

        public SaleList()
        {
            saleList = new List<Sale>();
        }

        public void AddSale(Sale sale)
        {
            saleList.Add(sale);
        }

        public List<Sale> GetSaleList()
        {
            return saleList;
        }

        public Sale GetSaleById(int id)
        {
            return saleList.Find(s => s.SaleId == id);
        }

        public StringBuilder GetSales()
        {
            StringBuilder sales = new StringBuilder();
            foreach (Sale s in saleList)
                sales.Append($"[{s.ToString()}]\n");
            return sales;
        }
    }
}
