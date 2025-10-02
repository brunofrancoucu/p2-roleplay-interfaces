namespace Ucu.Poo.RoleplayGame;

public class Archer : ICharacter
{
    private int health = 100;

    public Archer(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
    
    public Bow Bow { get; set; }

    public Helmet Helmet { get; set; }

    public int AttackValue
    {
        get
        {
            return Bow.AttackValue;
        }
    }

    public int DefenceValue
    {
        get
        {
            return Helmet.DefenceValue;
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
