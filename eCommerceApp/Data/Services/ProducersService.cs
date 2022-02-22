using eCommerceApp.Data.Base;
using eCommerceApp.Models;

namespace eCommerceApp.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(SqlContext context) : base(context)
        {
        }
    }
}
