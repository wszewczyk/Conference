using Conf.Core.Abstract.Repositories;
using Conf.Core.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace Conf.Infrastructure.Repositories
{
    public class ConferenceRepository : Repository<Conference>, IConferenceRepository
    {
        public ConferenceRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
