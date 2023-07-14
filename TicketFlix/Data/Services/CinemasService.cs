using Microsoft.EntityFrameworkCore;
using TicketFlix.Data.Base;
using TicketFlix.Models;

namespace TicketFlix.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(MyDbContext context) : base(context)
        {
        }
    }
}