using TicketFlix.Data.Base;
using TicketFlix.Data.ViewModels;
using TicketFlix.Models;



namespace TicketFlix.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {

        Task<Movie>? GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
