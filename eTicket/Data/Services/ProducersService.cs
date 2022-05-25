﻿using eTicket.Data.Base;
using eTicket.Models;

namespace eTicket.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
