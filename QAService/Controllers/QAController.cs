using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QAService.Application.Commands;
using QAService.Application.Models;

namespace QAService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QAController : ControllerBase
    {
        private IMediator _mediatr;
        private readonly ILogger<QAController> _logger;

        public QAController(IMediator mediatr, ILogger<QAController> logger)
        {
            _mediatr = mediatr ?? throw new ArgumentNullException(nameof(mediatr));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: api/QA
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/QA/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/QA
        [HttpPost]
        public async Task<ActionResult<bool>> RecordQAResults([FromBody] QAExecution dto)
        {
            bool commandResult = false;

            var command = new RecordQAResultsCommand(dto.ClientId, dto.AccountId, dto.Event, dto.RuleErrors);

            _logger.LogInformation("-----Sending command: RegistrationCommand");

            commandResult = await _mediatr.Send(command);

            if (!commandResult)
            {
                return BadRequest();
            }

            return Ok();


        }


        [Route("RunRegistrationRules")]
        [HttpPost]
        public async Task<ActionResult<bool>> RunRegistrationRules([FromBody] PatientDTO registrationDTO )
        {
            bool commandResult = false;

            var command = new RunRegistrationRulesCommand(registrationDTO.FirstName, registrationDTO.LastName, registrationDTO.BirthDate, registrationDTO.Gender);

            _logger.LogInformation("-----Sending command: RunRegistrationRulesCommand");

            commandResult = await _mediatr.Send(command);

            if (!commandResult)
            {
                return BadRequest();
            }

            return Ok();


        }

        // PUT: api/QA/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
