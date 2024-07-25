namespace SOLID;

/// <summary>
/// Интерфейс консольного взаимодействия с пользователем.
/// </summary>
public class ConsoleUserInterface : IUserInterface
{
	/// <summary>
	/// Вывод сообщения в консоль.
	/// </summary>
	/// <param name="message">Текст сообщения.</param>
	public void PrintMessage(string message)
	{
		Console.WriteLine(message);
	}

	/// <summary>
	/// Получить пользовательский ввод.
	/// </summary>
	/// <param name="dialog">Диалоговое сообщение</param>
	public int GetUserInput(string? dialog)
	{
		if (!string.IsNullOrEmpty(dialog))
		{
			Console.Write(dialog);
		}
		return int.Parse(Console.ReadLine());
	}
}