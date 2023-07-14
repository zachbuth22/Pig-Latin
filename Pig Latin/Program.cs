Console.WriteLine("Welcome to the English/Pig Latin Translator!");

bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Please enter the word you would like translated:");
    string input = Console.ReadLine().ToLower().Trim();

    if (input[0] == 'a' || input[0] == 'e' || input[0] == 'i' || input[0] == 'o' || input[0] == 'u')
    {
        Console.WriteLine(input + "way");
    }

    else
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
            {
                string firstHalf = input.Substring(0, i);
                string secondHalf = input.Substring(i);

                Console.WriteLine($"Pig Latin for {input} is: " + secondHalf + firstHalf + "ay");
                break;
            }
        }
        Console.WriteLine("Would you like to enter another word? y/n");
        string choice = Console.ReadLine();
        if (choice == "n")
        {
            runProgram = false;
            Console.WriteLine("Thank you for using the Pig Latin Translator");
        }
    }
}






























Console.ReadLine();