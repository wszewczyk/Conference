using System.Collections.Generic;
using Conf.Core.Abstract.Repositories;
using Conf.Core.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Conf.Controllers
{
    [Route("api/[controller]")]
    public class ConferenceController : Controller
    {
        private IConferenceRepository _conferenceRepository;
        private IConferenceService _conferenceService;

        public ConferenceController(IConferenceRepository conferenceRepository, IConferenceService conferenceService)
        {
            _conferenceRepository = conferenceRepository;
            _conferenceService = conferenceService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            var res = this._conferenceRepository.Get(id);
            return $"Id: {id}";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
