namespace Ucu.Poo.RoleplayGame;
public class Knight:ICharacter

{
    private int _health = 100;

    public Knight(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public Sword Sword { get; set; }

    public Shield Shield { get; set; }

    public Armor Armor { get; set; }

    public int AttackValue
    {
        get
        {
            return Sword.AttackValue;
        }
    }

    public int DefenceValue
    {
        get
        {
            return Armor.DefenceValue + Shield.DefenceValue;
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
