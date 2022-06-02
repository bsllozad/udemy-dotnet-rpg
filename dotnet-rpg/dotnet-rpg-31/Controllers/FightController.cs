using dotnet_rpg.Dtos.Fight;
using dotnet_rpg.Model;
using dotnet_rpg.Services.FightService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnet_rpg.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {

        private readonly IFightService fightService;


        public FightController(IFightService fightService)
        {
            this.fightService = fightService;
        }


        [HttpPost("weapon")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await fightService.WeaponAttack(request));
        }


        [HttpPost("skill")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttack(SkillAttackDto request)
        {
            return Ok(await fightService.SkillAttack(request));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<FightResultDto>>> Fight(FightRequestDto request)
        {
            return Ok(await fightService.Fight(request));
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<HighScoreDto>>>> GetHighScore()
        {
            return Ok(await fightService.GetHighScore());
        }

    }
}
