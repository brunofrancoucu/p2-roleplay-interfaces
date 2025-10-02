namespace Ucu.Poo.RoleplayGame;

public class Wizard:ICharacter
{
    private int health = 100;

    public Wizard(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public SpellsBook SpellsBook { get; set; }

    public Staff Staff { get; set; }

    public int AttackValue
    {
        get
        {
            return SpellsBook.AttackValue + Staff.AttackValue;
        }
    }

    public int DefenceValue
    {
        get
        {
            return SpellsBook.DefenceValue + Staff.DefenceValue;
        }
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        private set
        {
            this.health = value < 0 ? 0 : value;
        }
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenceValue < power)
        {
            this.Health -= power - this.DefenceValue;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }
}
