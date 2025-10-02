namespace Ucu.Poo.RoleplayGame;

public class Dwarf : ICharacter
{
    private int _health = 100;

    public Dwarf(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public Axe Axe { get; set; }

    public Shield Shield { get; set; }

    public Helmet Helmet { get; set; }

    public int AttackValue
    {
        get
        {
            return Axe.AttackValue;
        }
    }

    public int DefenceValue
    {
        get
        {
            return Shield.DefenceValue + Helmet.DefenceValue;
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
