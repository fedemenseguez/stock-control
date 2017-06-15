
namespace LihueDev.StockControl.Models
{
    public class Product : IModel
    {
        public int Id { get; set; }
        public string BarCode { get; set; }
        public string Name { get; set; }
    }
}
