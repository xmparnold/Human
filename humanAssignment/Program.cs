using HumanAssignment;

Human george = new Human("George");

Human bruce = new Human("Bruce", 5, 5, 5, 120);

bruce.Attack(george);

Console.WriteLine(george.Health);

Wizazrd wizard = new Wizazrd("wizard", 5, 25);

Console.WriteLine(wizard.Health);