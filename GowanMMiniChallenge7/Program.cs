//Maddie Gowan
//10-20-2022
//Mini Challenge #7 - Redo
//In this program the user input must be reversed. It should reverse whether it's
//a string or a number.

//Peer Review: Brandon Le - overall the program did what it was meant to do and it
//reversed the strings and numbers. Play again function worked as intended I was
//able to hit yes to play again and any other typing, no or anything other than yes
//will end the program. Good job! If there was one small thing to add I would do
//data validation for the "If you would like to play again" at the end. So if user
//accidentally types ys ye or some other typo instead of yes, it won't end the program
//and it would allow them to properly input yes. But very good job :)

Console.Clear();

string playAgain = "yes";

while (playAgain == "yes" || playAgain == "Yes" || playAgain == "YES")
{

    long num;
    Console.WriteLine("Please type a number here, and I will reverse it for you!");
    string userInput = Console.ReadLine();
    bool validNum = long.TryParse(userInput, out num);

    if (validNum)
    {

        string reverseNum = "";

        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            reverseNum = reverseNum + userInput[i];
        }

        Console.WriteLine("The reverse of " + userInput + " is " + reverseNum);

        //Console.WriteLine("If you would like to play again, type yes");
        //playAgain = Console.ReadLine();
    }else{
        Console.WriteLine("That is not a valid number, but I will reverse it anyway :)");
        string reverseInput = "";
        for (int i = userInput.Length - 1; i>= 0; i--)
        {
            reverseInput = reverseInput + userInput[i];
        }
        Console.WriteLine("The reverse of " + userInput + " is " + reverseInput);
        //Console.WriteLine("If you would like to play again, type yes");
        //playAgain = Console.ReadLine();
   
    }
    Console.WriteLine("If you would like to play again, type yes");
    playAgain = Console.ReadLine();
}