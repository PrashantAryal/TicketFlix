using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using TicketFlix.Data.Base;
using TicketFlix.Models;
namespace TicketFlix.Data.Services
{

    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(MyDbContext context) : base(context) { }
    }
}