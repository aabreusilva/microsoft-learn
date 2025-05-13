Random random = new Random();

int hpHero = 10;
int hpMonster = 10;


do
{
    int roll = random.Next(1, 11);
    hpMonster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {hpMonster} health.");
    if (hpMonster <= 0) continue;

    roll = random.Next(1, 11);
    hpHero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hpHero} health.");
}
while (hpHero > 0 && hpMonster > 0);

Console.WriteLine(hpHero > hpMonster ? "Hero wins!" : "Monster wins!");