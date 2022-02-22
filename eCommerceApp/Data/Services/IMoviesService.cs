using eCommerceApp.Data.Base;
using eCommerceApp.Data.ViewModels;
using eCommerceApp.Models;

namespace eCommerceApp.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
    }
}
