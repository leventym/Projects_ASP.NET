using System;
namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }

        ICoverTypeRepository CoverType { get; }

        IProductRepository Product { get; }

        ICompanyRepository Company { get; }

        public IShoppingCartRepository ShoppingCart { get; }

        public IApplicationUserRepository ApplicationUser { get; }

        void Save();
    }
}

