namespace SOLID;
public class Game
{
	private readonly INumberGenerator _numberGenerator;
	private readonly IUserInterface _userInterface;
	private int _targetNumber;
	private readonly Settings _settings;

	/// <summary>
	/// Создать новую игру.
	/// </summary>
	/// <param name="numberGenerator">Экземпляр генератора чисел.</param>
	/// <param name="userInterface">Экземпляп интерфейса пользователя.</param>
	/// <param name="settings">Экземпляр настроек игры.</param>
	public Game(INumberGenerator numberGenerator, IUserInterface userInterface, Settings settings)
	{
		_numberGenerator = numberGenerator;
		_userInterface = userInterface;
		_settings = settings;
	}

	/// <summary>
	/// Начать игру.
	/// </summary>
	public void StartGame()
	{
		_targetNumber = _numberGenerator.Generate(_settings.MinNumber, _settings.MaxNumber);
		_userInterface.PrintMessage($"Угадай число от {_settings.MinNumber} до {_settings.MaxNumber} за {_settings.Attempts} попыток!");

		for (var i = 0; i < _settings.Attempts; i++)
		{
			if (CheckNumber(_userInterface.GetUserInput("Ваш ответ: ")))
			{
				_userInterface.PrintMessage($"Вы выиграли! Игра завершена.");
				return;
			}
		}

		_userInterface.PrintMessage($"Вы исчерпали все попытки. Игра завершена. Загаданное число было: {_targetNumber}");
	}

	/// <summary>
	/// Проверка введенного числа.
	/// </summary>
	/// <param name="answer"></param>
	/// <returns><see langword="true"/>, если число угадано, <see langword="false"/> в противном случае.</returns>
	private bool CheckNumber(int answer)
	{
		if (answer < _targetNumber)
		{
			_userInterface.PrintMessage(">>> Больше >>>");
			return false;
		}
		else if (answer > _targetNumber)
		{
			_userInterface.PrintMessage("<<< Меньше <<<");
			return false;
		}
		else
		{
			_userInterface.PrintMessage("=== В точку! ===");
			return true;
		}
	}
}