namespace Ucu.Poo.RoleplayGame;

public interface ICharacter
{
    string Name { get; set; }
    int Health { get;}
    int AttackValue{get;}
    int DefenceValue { get; }
    void ReceiveAttack(int power);
    void Cure();
}
