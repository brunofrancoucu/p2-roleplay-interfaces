namespace Ucu.Poo.RoleplayGame;

public interface IItem  
{
    string Name { get; set; }  // Lo minimo que todos los items deben tener  
}

public interface IDamageable
{
    int AttackValue { get; set; } // Solo si el item inflige daño
}

public interface IDefensible
{
    int DefenceValue { get; set; } // Solo si el item puede defender 
}