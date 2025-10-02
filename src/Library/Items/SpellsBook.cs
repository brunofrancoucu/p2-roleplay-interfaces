namespace Ucu.Poo.RoleplayGame;

public class SpellsBook
{
    // Aplico getters y setters
    public List<Spell> Spells { get; set; } // Lista de hechizos que contiene el libro  

    public int DefenceValue // Valor de defensa total del libro
    {
        get
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.DefenceValue; // Sumo el valor de defensa de cada hechizo
            }
            return value;
        }
    }

    public int AttackValue // Valor de ataque total del libro
    {
        get
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.AttackValue; // Sumo el valor de ataque de cada hechizo
            }
            return value;
        }
    }

    public SpellsBook() // Inicializo el constructor
    {
        this.Spells = new List<Spell>(); // Inicializo la lista de hechizos 
    }



    public void LearnSpell(Spell spell) // Método para agregar un hechizo nuevo 
    {
        this.Spells.Add(spell); // Agrego el hechizo a la lista
    }

    public List<Spell> GetSpells() // Método para obtener la lista de hechizos 
    {
        return this.Spells; // Devuelvo la lista de hechizos
    }
}