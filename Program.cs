static string GetComputerChoice() {
    Random random = new Random();
    int choice = random.Next(1, 4);
    if (choice == 1) {
        return "ROCK";
    } else if (choice == 2) {
        return "PAPER";
    } else {
        return "SCISSORS";
    } 
} 

static string GetUserChoice() {
    Console.WriteLine("Rock, paper, scissors: ");
    string input = Console.ReadLine()?.Trim() ?? "";
    return input.ToUpper();
}

static string PlayRound(string ComputerChoice, string UserChoice) {
    if (
        ComputerChoice == "ROCK" && UserChoice == "SCISSORS" ||
        ComputerChoice == "SCISSORS" && UserChoice == "PAPER" ||
        ComputerChoice == "PAPER" && UserChoice == "ROCK") {
            return "Computer Wins!"; 
    } else if (
        UserChoice == "ROCK" && ComputerChoice == "SCISSORS" ||
        UserChoice == "SCISSORS" && ComputerChoice == "PAPER" ||
        UserChoice == "PAPER" && ComputerChoice == "ROCK") {
            return "User Wins!";
    } else {
        return "Draw!";
    }
}

while (true) {
    Console.WriteLine(PlayRound(GetComputerChoice(), GetUserChoice()));
    Console.WriteLine("Continue? (y/n): ");
    string cont = Console.ReadLine()?.Trim().ToUpper() ?? "N";
    if (cont != "Y") {
        break;
    }
}
