using AutoMapper;
using dotnet_rpg.Data;
using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Model;
using dotnet_rpg_31.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace dotnet_rpg_31.Services.CharacterSkillService
{
    public class CharacterSkillService : ICharacterSkillService
    {

        private readonly DataContext context;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IMapper mapper;


        public CharacterSkillService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.context = context;
        }

        public async Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill)
        {
            ServiceResponse<GetCharacterDto> response = new ServiceResponse<GetCharacterDto>();
            try
            {
                Character character = await context.Characters
                    .Include(c => c.Weapon)
                    .Include(c => c.CharacterSkills).ThenInclude(cs => cs.Skill)
                    .FirstOrDefaultAsync(c => c.Id == newCharacterSkill.CharacterId &&
                    c.User.Id == int.Parse(httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)));

                if (character == null)
                {
                    response.Success = false;
                    response.Message = "Character not found.";
                    return response;
                }

                Skill skill = await context.Skills
                    .FirstOrDefaultAsync(s => s.Id == newCharacterSkill.SkillId);

                if (skill == null)
                {
                    response.Success = false;
                    response.Message = "Skill not found";
                    return response;
                }

                CharacterSkill characterSkill = new CharacterSkill
                {
                    Character = character,
                    Skill = skill
                };

                await context.CharacterSkills.AddAsync(characterSkill);
                await context.SaveChangesAsync();

                response.Data = mapper.Map<GetCharacterDto>(character);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

    }
}
