namespace Ucu.Poo.RoleplayGame;

// Items de defensa:
public class Armor : IItem, IDefensible  // Armadura tiene defensa, pero no daño
{
    public string Name  { get; set; }
    public int DefenceValue { get; set; }

    public Armor(string Name, int DefenceValue) // Inicializo constructor
    {
        this.Name = Name;
        this.DefenceValue = DefenceValue;
    }
}