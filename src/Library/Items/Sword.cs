namespace Ucu.Poo.RoleplayGame;

public class Sword : IItem, IDamageable // Espada tiene daño, pero no defensa
{
    public string Name  { get; set; }
    public int AttackValue { get; set; }

    public Sword(string Name, int AttackValue)  // Inicializo constructor
    {
        this.Name = Name;
        this.AttackValue = AttackValue;
    }
}