namespace Items;
 
public interface IItem  
{
    string Name { get; set; }  // Lo minimo que todos los items deben tener  
}

public interface IDamageable
{
    int DamageValue { get; set; } // Solo si el item inflige daño
}

public interface IDefensible
{
    int DefenceValue { get; set; } // Solo si el item puede defender 
}

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

// Items de ataque:

public class Axe : IItem, IDamageable // Hacha tiene daño, pero no defensa
{
    public string Name  { get; set; }
    public int DamageValue { get; set; }

    public Axe(string Name, int DamageValue)  // Inicializo constructor
    {
        this.Name = Name;
        this.DamageValue = DamageValue;
    }
}

public class Bow : IItem, IDamageable // Arco tiene daño, pero no defensa
{
    public string Name  { get; set; }
    public int DamageValue { get; set; }

    public Bow(string Name, int DamageValue)  // Inicializo constructor
    {
        this.Name = Name;
        this.DamageValue = DamageValue;
    }
}

public class Sword : IItem, IDamageable // Espada tiene daño, pero no defensa
{
    public string Name  { get; set; }
    public int DamageValue { get; set; }

    public Sword(string Name, int DamageValue)  // Inicializo constructor
    {
        this.Name = Name;
        this.DamageValue = DamageValue;
    }
}

// Items mágicos (daño y defensa)

public class Staff : IItem, IDamageable, IDefensible // Bastón mágico tiene ambos: defensa y ataque 
{
    public string Name  { get; set; }
    public int DamageValue { get; set; }
    public int DefenceValue { get; set; }

    public Staff(string Name, int DamageValue, int DefenceValue) // Inicializo constructor
    {
        this.Name = Name;
        this.DamageValue = DamageValue;
        this.DefenceValue = DefenceValue;
    }
}

// Spell y Spellbook:

public class Spell 
{
    public string Name { get; set; }  // Nombre del hechizo 
    public int DamageValue { get; set; } // Daño que inflige el hechizo 
    
    public Spell(string Name, int DamageValue) // Inicializo el constructor 
    {
        this.Name = Name;  // Inicializa el nombre del hechizo 
        this.DamageValue = DamageValue; // Inicializa el daño del hechizo 
    }
}

public class SpellBook
{
    // Aplico getters y setters
    public List<Spell> spells { get; set; } // Lista de hechizos que contiene el libro  

    public SpellBook() // Inicializo el constructor
    {
        this.spells = new List<Spell>(); // Inicializo la lista de hechizos 
    }

    public void LearnSpell(Spell spell) // Método para agregar un hechizo nuevo 
    {
        this.spells.Add(spell); // Agrego el hechizo a la lista
    }

    public List<Spell> GetSpells() // Método para obtener la lista de hechizos 
    {
        return this.spells; // Devuelvo la lista de hechizos
    }
}