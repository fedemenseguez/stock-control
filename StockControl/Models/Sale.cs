using System;

namespace LihueDev.StockControl.Models
{
    public class Sale : IModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ushort Quantity { get; set; }
        public Product Product { get; set; }
    }
}
