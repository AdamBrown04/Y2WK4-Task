string path = "numbers.txt";
List<string> fileContents = new List<string>();
if (File.Exists(path))
{
    fileContents = File.ReadAllLines(path).ToList();
}
List<int> numbers = new List<int>();
foreach(string number in fileContents)
{
    numbers.Add(Convert.ToInt32(number));
}

while (true)
{
    if(numbers.Count > 0)
    {
        Console.WriteLine($"The average is: {numbers.Average()}");
    }

    Console.Write("Enter a new number: ");
    string userInput = Console.ReadLine().ToLower();
    if (userInput == "q")
    {
        break;
    }
    else
    {
        numbers.Add(Convert.ToInt32(userInput));
    }
}

List<string> fileNumbers = new List<string>();
foreach (int number in numbers)
{
    fileNumbers.Add(number.ToString());
}
File.WriteAllLines(path, fileNumbers);
Console.WriteLine("File updated \nProgram ended");