static string GetComputerChoice() {
    Random random = new Random();
    int choice = random.Next(1, 4);
    if (choice == 1) {
        return "Rock";
    } else if (choice == 2) {
        return "Paper";
    } else {
        return "Scissors";
    } 
} 
Console.WriteLine(GetComputerChoice());

static string GetUserChoice() {
    Console.WriteLine("Rock, paper, scissors: ");
    string input = Console.ReadLine()?.Trim() ?? "";
    return input.ToUpper();
}
Console.WriteLine(GetUserChoice());
