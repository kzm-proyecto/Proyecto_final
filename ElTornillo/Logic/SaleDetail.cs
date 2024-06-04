namespace Logic
{
    public class SaleDetail
    {

        int detailId, saleId, productId, quantity;
        double unitPrice;

        public SaleDetail() { }

        public SaleDetail(int detailId, int saleId, int productId, int quantity, double unitPrice)
        {
            this.detailId = detailId;
            this.saleId = saleId;
            this.productId = productId;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public int DetailId { get => detailId; set => detailId = value; }
        public int SaleId { get => saleId; set => saleId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }

        public override string ToString()
        {
            return $"Detalle venta ID: {DetailId}, Venta ID: {SaleId}, Producto ID: {ProductId}, Cantidad: {Quantity}, Precio por unidad: {UnitPrice}";
        }
    }
}
