using UyariSoftBk.Configuration.Context;
using UyariSoftBk.Configuration.Context.Repository;
using UyariSoftBk.Modules.Event.Domain.IRepository;
using UyariSoftBk.Modules.Student.Domain.IRepository;
using UyariSoftBk.Modules.Teacher.Domain.IRepository;

namespace UyariSoftBk.Modules.Product.Infraestructure.Repository;

public class ProductRepository : BaseRepository<MySqlContext>, IProductRepository
{
    public ProductRepository(MySqlContext context) : base(context)
    {
    }
}