using Conf.Core.Abstract.Repositories;
using Conf.Core.Model.Domain;

namespace Conf.Infrastructure.Repositories
{
    public class ConferenceRepository : Repository<Conference>, IConferenceRepository
    {
    }
}
