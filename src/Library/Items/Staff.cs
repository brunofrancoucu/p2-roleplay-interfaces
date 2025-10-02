namespace Ucu.Poo.RoleplayGame;

public class Staff : IItem, IDamageable, IDefensible // Bastón mágico tiene ambos: defensa y ataque 
{
    public string Name  { get; set; }
    public int AttackValue { get; set; }
    public int DefenceValue { get; set; }

    public Staff(string Name, int AttackValue, int DefenceValue) // Inicializo constructor
    {
        this.Name = Name;
        this.AttackValue = AttackValue;
        this.DefenceValue = DefenceValue;
    }
}
