namespace HumanAssignment;

public class Ninja : Human {

    public Ninja(string name, int strength, int intelligence, int health, int dexterity = 175) : base(name, strength, dexterity, intelligence, health) {

    }

    public override int Attack(Human target) {
        int damage = 5*Dexterity;
        Random rand = new Random();
        int chance = rand.Next(1,6);

        if (chance == 3) {
            damage += 10;
        }
        target.Health -= damage;
        return target.Health;

    }

    public void Steal(Human target) {
        target.Health -= 5;
        Health += 5;
    }
}