namespace SOLID;
/// <summary>
/// Настройки игры 
/// </summary>
/// <param name="attempts">Количество попыток.</param>
/// <param name="maxNumber">Верхняя граница диапазона.</param>
/// <param name="minNumber">Нижняя граница диапазона.</param>
public class Settings(int attempts, int maxNumber, int minNumber)
{
	/// <summary>
	/// Количество попыток
	/// </summary>
	public int Attempts { get; set; } = attempts;

	/// <summary>
	/// Верхняя граница диапазона
	/// </summary>
	public int MaxNumber { get; set; } = maxNumber;

	/// <summary>
	/// Нижняя граница диапазона
	/// </summary>
	public int MinNumber { get; set; } = minNumber;
}