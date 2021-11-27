using FootballManagerApi.ServiceAbstracts;

namespace FootballManagerApi.UnitOfWork
{
    public interface IUnitOfWork
    {
        public ITeamService TeamService { get; set; }
        public IFootballerService FootballerService { get; set; }
    }
}
