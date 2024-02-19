

/*
Første forsøg mislykkedes, så jeg måtte prøve en anden løsning

int[] boxes = {1,2,3,4,5};
string cat = "Cat";
bool start = true;

Random random = new Random();

int catInTheBox = random.Next(1,6);


Console.WriteLine("Guess which of the boxes, the cat is in");
Console.WriteLine("[1] [2] [3] [4] [5]");


//Gæt hvilken kasse katten er i
string? input = Console.ReadLine();
int.TryParse(input, out int result);


if (result == boxes[0] && catInTheBox == 1){
    Console.WriteLine($"The {cat} was in the box. Congratulations.");
} else {
    Console.WriteLine($"The {cat} was not in the box. Try again.");
    Console.WriteLine("[1] [2] [3] [4] [5]");
    string? input2 = Console.ReadLine();
    int.TryParse(input2, out int result2);
    
    if (result2 == boxes[1] && catInTheBox == 2){
        Console.WriteLine($"The {cat} was in the box. Congratulations.");}
        else {Console.WriteLine($"The {cat} was not in the box. Try again.");
              Console.WriteLine("[1] [2] [3] [4] [5]");

              
              
              
              }
    
} 
*/


using System;


        Console.WriteLine("Find katten");
        

        Random random = new Random();
        int catLocation = random.Next(1, 6); 

        bool gameOver = false;

        while (!gameOver)
        {
            Console.Write("Indtast dit gæt [1] [2] [3] [4] [5]");
            int guess;
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess == catLocation)
                {
                    Console.WriteLine($"Korrekt! Katten var i boks {catLocation}!");
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("Katten er ikke i boksen. Katten rykker videre til en anden boks.");

                   
                    int moveLeft = random.Next(0,2);

                    if (moveLeft == 0 && catLocation != 1)
                    {
                        catLocation = Math.Max(1, catLocation - 1); 
                    } 
                    
                    else if (moveLeft == 0 && catLocation == 1){
                        catLocation = Math.Min(5, catLocation + 1);
                    }


                    else if (moveLeft == 1 && catLocation != 5)
                    {
                        catLocation = Math.Min(5, catLocation + 1); 
                    }

                    else if (moveLeft == 5 && catLocation == 5){
                        catLocation = Math.Min(5, catLocation + 1);
                    }
                }
            }
            else
            {
                Console.WriteLine("Forkert input. Indtast et tal");
            }
        }

        
    


