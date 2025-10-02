namespace Ucu.Poo.RoleplayGame;

public class Axe : IItem, IDamageable // Hacha tiene daño, pero no defensa
{
    public string Name  { get; set; }
    public int AttackValue { get; set; }

    public Axe(string Name, int AttackValue)  // Inicializo constructor
    {
        this.Name = Name;
        this.AttackValue = AttackValue;
    }
}