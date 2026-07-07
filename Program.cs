 // function getComputerChoice() {
 //     randomNum = Math.random()
 //     if (randomNum < 0.33) {
 //         computerChoice = "Rock";
 //     } else if (randomNum >= 0.33 && randomNum <= 0.66) {
 //         computerChoice = "Paper";
 //     } else if (randomNum > 0.66) {
 //         computerChoice = "Scissors";
 //     }
 //     return computerChoice;
 // }
 
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
