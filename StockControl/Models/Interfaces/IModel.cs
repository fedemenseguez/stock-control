using LiteDB;

namespace LihueDev.StockControl.Models
{
    public interface IModel
    {
        [BsonId]
        int Id { get; set; }
    }
}
