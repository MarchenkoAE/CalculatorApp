using Data.Entities;

namespace Data.Repos
{
    public interface IUserRepos : IReposBase<User>
    {
    }

    public interface IHistoryRepos : IReposBase<History>
    {
    }

    public interface ICinemaRepos : IReposBase<Cinema>
    {
    }

    public interface IMovieRepos : IReposBase<Movie>
    {
    }
    public interface IRoomRepos : IReposBase<Room>
    {
    }

    public interface ISeatRepos : IReposBase<Seat>
    {
    }
    public interface ITicketRepos : IReposBase<Ticket>
    {
    }

    public interface ITimetableRepos : IReposBase<Timetable>
    {
    }

}
