using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Archer : Entity.Character
{
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 70;
        Strength = 6;
        Intelligence = 7;
        Agility = 20;
        Speed = 22;
        Lucky = 4;
    }
}