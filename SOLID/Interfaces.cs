namespace SOLID;

/// <summary>
/// Интерфейс генератора чисел.
/// </summary>
public interface INumberGenerator
{
	int Generate(int min, int max);
}

/// <summary>
/// Интерфейс взаимодействия с пользователем.
/// </summary>
public interface IUserInterface
{
	void PrintMessage(string message);
	int GetUserInput(string? message = default);
}