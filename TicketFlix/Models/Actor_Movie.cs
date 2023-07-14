namespace TicketFlix.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }//this MovieId is foreign key for Movie Model
        public Movie? Movie { get; set; }
        public int ActorId { get; set; }
        public Actor? Actor { get; set; }
    }

}