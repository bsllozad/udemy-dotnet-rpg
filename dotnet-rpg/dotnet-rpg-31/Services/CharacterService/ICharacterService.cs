using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int userId);

        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto character);

        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacter);

        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

        //Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto request);
    }
}
