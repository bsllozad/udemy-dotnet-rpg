using dotnet_rpg.Model;

namespace dotnet_rpg_31.Model
{
    public class CharacterSkill
    {

        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }

    }
}
