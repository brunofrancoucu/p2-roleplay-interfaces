namespace Ucu.Poo.RoleplayGame;

public class Spell 
{
    public string Name { get; set; }  // Nombre del hechizo 
    public int AttackValue { get; set; }
    public int DefenceValue { get; set; } // Daño que inflige el hechizo 
    
    public Spell(string Name, int DefenceValue, int AttackValue) // Inicializo el constructor 
    {
        this.AttackValue = AttackValue; // Inicializa el valor de ataque del hechizo
        this.Name = Name;  // Inicializa el nombre del hechizo 
        this.DefenceValue = DefenceValue; // Inicializa el daño del hechizo 
    }
}