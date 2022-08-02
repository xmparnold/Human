namespace HumanAssignment;

public class Wizazrd : Human {

    public Wizazrd(string name, int strength, int dexterity, int intelligence = 25, int health = 50) : base(name, strength, dexterity, intelligence, health) {

    }

    public override int Attack(Human target) {
        int damage = 5*Intelligence;
        target.Health -= damage;
        Health += damage;
        return target.Health;

    }

    public void Heal(Human target) {
        target.Health += 10*Intelligence;
    }
}