namespace ePlan.TileCalculator.Model.Patterns
{
	/// <summary>
	/// Provides a standard interface that all patterns must adhere to.
	/// </summary>
	public interface IPattern
	{
		/// <summary>
		/// Calculates the number of whole tiles used, along with the number of cuts
		/// and the total waste percentage.
		/// </summary>
		/// <returns>An instance of CalculatorResult.</returns>
		CalculatorResult Calculate(Room room, Tile tile, double groutThickness);

		/// <summary>
		/// Used by the UI to display a consumer-friendly name in the drop down.
		/// </summary>
		string Name { get; }
	}
}
