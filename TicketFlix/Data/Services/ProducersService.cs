using TicketFlix.Data.Base;
using TicketFlix.Models;

namespace TicketFlix.Data.Services
{

    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(MyDbContext context) : base(context) { }
    }
}