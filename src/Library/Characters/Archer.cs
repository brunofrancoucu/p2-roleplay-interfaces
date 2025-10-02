namespace Ucu.Poo.RoleplayGame;

public class Archer : ICharacter
{
    private int _health = 100;

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
            return this._health + this.DefenceValue;
        }
        private set
        {
            this._health = value < 0 ? 0 : value;
        }
    }

    public void ReceiveAttack(int power)
    {
        this._health -= power;
    }

    public void Cure()
    {
        this._health = 100;
    }
}
