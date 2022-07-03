using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
        //Stores product collection of MongoDB
        IMongoCollection<Product> Products { get; }
    }
}
