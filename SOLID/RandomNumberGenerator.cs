namespace SOLID;

/// <summary>
/// Класс генератора рандомных чисел.
/// </summary>
public class RandomNumberGenerator : INumberGenerator
{
	private Random _random = new Random();

	/// <summary>
	/// Сгенерировать целое число в диапазоне.
	/// </summary>
	/// <param name="min">Нижняя граница диапазона.</param>
	/// <param name="max">Верхняя граница диапазона.</param>
	public int Generate(int min, int max)
	{
		return _random.Next(min, max);
	}
}