using System;
using System.Collections.Generic;

namespace Logic
{
    public class Sale
    {

        int saleId;
        DateTime date;
        double total;
        string paymentType;


        public Sale() { }

        public Sale(int saleId, DateTime date, double total, string paymentType)
        {
            this.saleId = saleId;
            this.date = date;
            this.total = total;
            this.paymentType = paymentType;
        }

        public int SaleId { get => saleId; set => saleId = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Total { get => total; set => total = value; }
        public string PaymentType { get => paymentType; set => paymentType = value; }

        public override string ToString()
        {
            return $"Venta ID: {SaleId}, Fecha: {Date}, Total: {Total}, Metodo de pago: {PaymentType}";
        }
    }
}
