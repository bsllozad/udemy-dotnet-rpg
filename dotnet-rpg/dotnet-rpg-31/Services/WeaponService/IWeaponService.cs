using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Dtos.Weapon;
using dotnet_rpg.Model;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.WeaponService
{
    public interface IWeaponService
    {

        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto weapon);

    }
}
