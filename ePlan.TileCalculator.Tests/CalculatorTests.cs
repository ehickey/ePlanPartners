using Microsoft.VisualStudio.TestTools.UnitTesting;
using ePlan.TileCalculator.Model;
using ePlan.TileCalculator.Model.Patterns;
using System.Diagnostics.CodeAnalysis;

namespace ePlan.TileCalculator.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class CalculatorTests
	{
		[TestMethod]
		public void StandardPattern_Calculates_Correctly_With_24_By_24_Room()
		{
			IPattern standardPattern = new StandardPattern();

			CalculatorResult result = standardPattern.Calculate(new Room(24, 24), new Tile(12, 12), .25);

			Assert.AreEqual(4, result.WholeTilesUsed);
			Assert.AreEqual(4, result.TotalCuts);
			Assert.AreEqual(.02, result.WastePercentage);
		}

		[TestMethod]
		public void StandardPattern_Calculates_Correctly_With_36_By_36_Room()
		{
			IPattern standardPattern = new StandardPattern();

			CalculatorResult result = standardPattern.Calculate(new Room(36, 36), new Tile(12, 12), .25);

			Assert.AreEqual(9, result.WholeTilesUsed);
			Assert.AreEqual(6, result.TotalCuts);
			Assert.AreEqual(.03, result.WastePercentage);
		}

		[TestMethod]
		public void SmartStandardPattern_Calculates_Correctly_With_24_By_24_Room()
		{
			IPattern standardPattern = new SmartStandardPattern();

			CalculatorResult result = standardPattern.Calculate(new Room(24, 24), new Tile(12, 12), .25);

			Assert.AreEqual(4, result.WholeTilesUsed);
			Assert.AreEqual(4, result.TotalCuts);
			Assert.AreEqual(.02, result.WastePercentage);
		}

		[TestMethod]
		public void SmartStandardPattern_Calculates_Correctly_Using_Offcuts()
		{
			IPattern standardPattern = new SmartStandardPattern();

			CalculatorResult result = standardPattern.Calculate(new Room(16.25, 36.5), new Tile(12, 12), .25);

			Assert.AreEqual(4, result.WholeTilesUsed);
			Assert.AreEqual(2, result.TotalCuts);
			Assert.AreEqual(0, result.WastePercentage);
		}
	}
}
