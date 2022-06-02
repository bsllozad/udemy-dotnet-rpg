using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Model;
using System.Threading.Tasks;

namespace dotnet_rpg_31.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}
