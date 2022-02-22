using eCommerceApp.Data.Base;
using eCommerceApp.Models;

namespace eCommerceApp.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(SqlContext context) : base(context)
        {
        }
    }
}
