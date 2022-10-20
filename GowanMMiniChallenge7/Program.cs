//Maddie Gowan
//09-16-2022
//Mini Challenge #7 - Reverse It
//
//Peer reviewed by: Kenneth Fujimura
//I really liked how your program was formatted, to both acknowledge
//when a number was given and something not a number. You could have probably
//further simplified your code by making the for loop its own function that
//you could call like they demo’d to us in yesterday’s lecture, but as is -
//everything runs perfectly! Great job!

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