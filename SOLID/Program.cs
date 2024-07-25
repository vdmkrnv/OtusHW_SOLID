namespace SOLID;
class Program
{
	static void Main(string[] args)
	{
		var settings = new Settings
		(
			attempts: 5,
			minNumber: 1,
			maxNumber: 50
		);

		var numberGenerator = new RandomNumberGenerator();
		var userInterface = new ConsoleUserInterface();

		var game = new Game
		(
			numberGenerator, 
			userInterface, 
			settings
		);

		game.StartGame();
	}
}