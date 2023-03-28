Console.WriteLine("Welcome to the game!");
ViewActions();

bool end = false;

while (!end) {

	string userAction = Console.ReadLine() ?? throw new InvalidOperationException();

	bool npcCanPlay = true;
	
	switch (userAction) {
		case "1":
			ViewActions();
			npcCanPlay = false;
			break;
		case "2":
			Console.WriteLine("You attack !");
			break;
		case "3":
			Console.WriteLine("Goodbye !");
			npcCanPlay = false;
			end = true;
			break;
		default:
			Console.WriteLine("Wrong input!");
			npcCanPlay = false;
			break;
	}

	if (!end && npcCanPlay) {
		Console.WriteLine("The enemy is doing something!");
	}
	
}

/*
 * This function displays the accepted user inputs
 */
void ViewActions() {
	Console.WriteLine("------------------");
	Console.WriteLine("1. View actions");
	Console.WriteLine("2. Attack");
	Console.WriteLine("3. Quit");
	Console.WriteLine("------------------");
}