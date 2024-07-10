//User instruções if e else em vez de duas instruções if separadas.

Random dice = new Random(); //dice = objeto.

int roll0 = dice.Next(1, 7);
int roll1 =  dice.Next(1, 7);
int roll2 = dice.Next(1, 7);

int total = roll0 + roll1 + roll2;

Console.WriteLine($"Dice roll results: {roll0} + {roll1} + {roll2} = {total}");

    if ((roll0 == roll1) || (roll1 == roll2) || (roll0 == roll2)) 
    {
        if ((roll0 == roll1) && (roll1 == roll2))
        {
            Console.WriteLine("You rollled triples! +6 bonus to total!");
            total += 6;
        }
        else 
        {
            Console.WriteLine("you rolled double! +2 bonus to total!");
            total += 2;
        }

        Console.WriteLine($"Your total including the bonus: {total}");
    }

    if (total >= 16)
    {
        Console.WriteLine("You win a new car!");
    }
    else if (total >= 10)
    {
        Console.WriteLine("You win a new laptop!");
    }
    else if (total == 7)
    {
        Console.WriteLine("You win anew trip for two!");
    }
    else 
    {
        Console.WriteLine("You win a kitten!");
    }
