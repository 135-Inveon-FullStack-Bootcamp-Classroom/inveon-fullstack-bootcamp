using FootballManagerApi.ServiceAbstracts;

namespace FootballManagerApi.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ITeamService teamService, IFootballerService footballerService)
        {
            this.FootballerService = footballerService;
            this.TeamService = teamService;
        }

        public ITeamService TeamService { get; set; }
        public IFootballerService FootballerService { get; set; }
    }
}
