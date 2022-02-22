using eCommerceApp.Data.Base;
using eCommerceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceApp.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(SqlContext context) : base(context) { }
    }
}
