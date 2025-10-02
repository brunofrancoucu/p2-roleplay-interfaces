namespace Ucu.Poo.RoleplayGame;

public class Helmet : IItem, IDefensible   // Casco tiene defensa, pero no daño
{
    public string Name  { get; set; }
    public int DefenceValue { get; set; }

    public Helmet(string Name, int DefenceValue)  // Inicializo constructor
    {
        this.Name = Name;
        this.DefenceValue = DefenceValue;
    }
}