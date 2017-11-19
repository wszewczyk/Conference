using Conf.Core.Abstract.Repositories;
using Conf.Core.Abstract.Services;
using Conf.Core.Model.Domain;

namespace Conf.Application.Services
{
    public class ConferenceService : IConferenceService
    {
        private IConferenceRepository _conferenceRepository;

        public ConferenceService(IConferenceRepository conferenceRepository)
        {
            _conferenceRepository = conferenceRepository;
        }
    }
}
