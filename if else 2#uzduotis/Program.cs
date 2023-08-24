Console.WriteLine("Sveiki, iveskite prasom skaiciu, aciu.");
string userInput = Console.ReadLine();
int userText = Convert.ToInt32(userInput);
if (userText % 5 == 0)
    Console.WriteLine("Skaicius dalijasi is 5");
else if (userText % 2 == 0)
    Console.WriteLine("Skaicius yra lyginis");