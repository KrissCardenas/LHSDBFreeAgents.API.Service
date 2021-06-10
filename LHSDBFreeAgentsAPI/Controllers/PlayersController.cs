using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using LHSDBFreeAgentsAPI.Models;
using LHSDBFreeAgentsAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ILogger = Microsoft.Extensions.Logging.ILogger;

// For more information on enabling Web API for empty projects,  visit https://go.microsoft.com/fwlink/?LinkID=397860
 
namespace LHSDBFreeAgentsAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        // hello 2 wtf
        private readonly IPlayerService _playerService;
        private readonly ILogger _logger;

        public PlayersController(IPlayerService pPlayerService, ILogger<PlayersController> logger)
        {
            _playerService = pPlayerService;
            _logger = logger;
        }

        [HttpGet]
        [Route("freeagents")]
        public async Task<IActionResult> GetFreeAgents()
        {
            _logger.LogInformation("Get Free Agents");
            try
            {
                // unuseful comment
                var results = await _playerService.GetAllFreeAgents();
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound(ex.Message);
            }
        }

        // GET: api/<PlayersController>
        [HttpGet]
        [Route("teams/{teamId}")]
        public async Task<IActionResult> GetAllTeamPlayers(int teamId, [FromQuery(Name = "faOnly")] bool faOnly)
        {
            try
            {
                if (teamId <= 0)
                {
                    return BadRequest("Missing team ID");
                }

                var results = await _playerService.GetAllTeamPlayers(teamId, faOnly);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        // GET api/<PlayersController>/
        [HttpGet]
        public string Get()
        {
            return "Service is running";
        }
    }
}
