using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Druid : Entity.Character
{
    public Druid(string name) : base(name, CharacterClass.Druid)
    {
        Health = 70;
        Strength = 6;
        Intelligence = 7;
        Agility = 20;
        Speed = 15;
        Lucky = 0;
    }
}
