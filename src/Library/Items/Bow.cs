namespace Ucu.Poo.RoleplayGame;

public class Bow : IItem, IDamageable // Arco tiene daño, pero no defensa
{
    public string Name  { get; set; }
    public int AttackValue { get; set; }

    public Bow(string Name, int AttackValue)  // Inicializo constructor
    {
        this.Name = Name;
        this.AttackValue = AttackValue;
    }
}