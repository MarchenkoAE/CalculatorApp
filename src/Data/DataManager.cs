using Data.Repos;

namespace Data
{
    public class DataManager
    {
        public IUserRepos Users
        {
            get;
        }
        public ICinemaRepos Cinemas
        {
            get;
        }
        public IMovieRepos Movies
        {
            get;
        }
        public IRoomRepos Rooms
        {
            get;
        }
        public ISeatRepos Seats
        {
            get;
        }
        public ITicketRepos Tickets
        {
            get;
        }
        public ITimetableRepos Timetables
        {
            get;
        }
        public DataManager(IUserRepos users, IHistoryRepos history, ICinemaRepos cinemas, IMovieRepos movies, IRoomRepos rooms, ISeatRepos seats)
        {
            Users = users;
            History = history;
            Cinemas = cinemas;
            Movies = movies;
            Rooms = rooms;
            Seats = seats;
        }

        public IHistoryRepos History
        {
            get;
        }
    }
}
