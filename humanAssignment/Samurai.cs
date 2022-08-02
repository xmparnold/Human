namespace HumanAssignment;

public class Samurai : Human {

    

    public Samurai(string name, int strength, int dexterity, int intelligence, int health = 200) : base(name, strength, dexterity, intelligence, health) {

    }

    public override int Attack(Human target) {
        base.Attack(target);
        if(target.Health <= 50) {
            target.Health = 0;
        }
        return target.Health;

    }

    public void Meditate() {
        Health = 200;
    }
}