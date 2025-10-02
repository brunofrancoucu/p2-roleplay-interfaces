namespace Ucu.Poo.RoleplayGame;

public class Shield : IItem, IDefensible  // Escudo tiene defensa, pero no daño
{
    public string Name  { get; set; }
    public int DefenceValue { get; set; }
    
    public Shield(string Name, int DefenceValue) // Inicializo constructor
    {
        this.Name = Name;
        this.DefenceValue = DefenceValue;
    }
}