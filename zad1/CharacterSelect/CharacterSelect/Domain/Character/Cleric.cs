using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Cleric : Entity.Character
{
    public Cleric(string name) : base(name, CharacterClass.Cleric)
    {
        Health = 40;
        Strength = 7;
        Intelligence = 17;
        Agility = 5;
        Speed = 13;
        Lucky = 1;
    }
}
