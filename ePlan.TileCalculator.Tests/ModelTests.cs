using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ePlan.TileCalculator.Model;
using System.Diagnostics.CodeAnalysis;
using ePlan.TileCalculator.Model.Patterns;
using ePlan.TileCalculator.SmartStandardPatter;

namespace ePlan.TileCalculator.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ModelTests
	{
		[TestMethod]
		public void Area__ComputedArea_Returns_100_When_Tile_Is_Created_With_10_By_10()
		{
			var area = new Area(10, 10);
			Assert.AreEqual(100, area.ComputedArea);
		}

		[TestMethod]
		public void TileArea_Returns_100_When_Tile_Is_Created_With_10_By_10()
		{
			var tile = new Tile(10, 10);
			Assert.AreEqual(100, tile.Area);
		}

		[TestMethod]
		public void RoomArea_Returns_200_When_Tile_Is_Created_With_10_By_20()
		{
			var room = new Room(10, 20);
			Assert.AreEqual(200, room.Area);
		}

		[TestMethod]
		public void Tile_CutPartialTile_Can_Create_Single_Offcut()
		{
			var tile = new Tile(12, 12);
			var offCuts = tile.CutPartialTile(new Area(10, 12));

			Assert.AreEqual(1, offCuts.Count);
			Assert.AreEqual(2, offCuts[0].Width);
			Assert.AreEqual(12, offCuts[0].Length);
		}

		[TestMethod]
		public void Tile_CutPartialTile_Can_Create_Double_Offcut()
		{
			var tile = new Tile(12, 12);
			var offCuts = tile.CutPartialTile(new Area(10, 10));

			Assert.AreEqual(2, offCuts.Count);
			Assert.AreEqual(2, offCuts[0].Width);
			Assert.AreEqual(12, offCuts[0].Length);
			Assert.AreEqual(10, offCuts[1].Width);
			Assert.AreEqual(2, offCuts[1].Length);
		}

		[TestMethod]
		public void Can_Rotate_Tile()
		{
			Tile tile = new Tile(10, 20);
			tile.Rotate();

			Assert.AreEqual(20, tile.Width);
			Assert.AreEqual(10, tile.Length);
		}

		[TestMethod]
		public void CalculateResult_FindMatchingOffcut_Can_Return_Suitable_Offcut()
		{
			var result = new CalculatorResult(new Tile(12, 12));
			result.Offcuts.Add(new Tile(2, 10));
			result.Offcuts.Add(new Tile(3, 6));

			var offcut = result.FindMatchingOffcut(new Area(3, 5));
			Assert.IsNotNull(offcut);
			Assert.AreEqual(3, offcut.Width);
			Assert.AreEqual(6, offcut.Length);
		}

		[TestMethod]
		public void CalculateResult_FindMatchingOffcut_Can_Return_Suitable_Rotated_Offcut()
		{
			var result = new CalculatorResult(new Tile(12, 12));
			result.Offcuts.Add(new Tile(2, 10));
			result.Offcuts.Add(new Tile(6, 3));

			var offcut = result.FindMatchingOffcut(new Area(3, 5));
			Assert.IsNotNull(offcut);
			Assert.AreEqual(3, offcut.Width);
			Assert.AreEqual(6, offcut.Length);
		}

		[TestMethod]
		public void CalculateResult_FindMatchingOffcut_Returns_Null_When_No_Suitable_Offcuts()
		{
			var result = new CalculatorResult(new Tile(12, 12));
			result.Offcuts.Add(new Tile(2, 10));
			result.Offcuts.Add(new Tile(6, 1));

			var offcut = result.FindMatchingOffcut(new Area(3, 5));
			Assert.IsNull(offcut);
		}

		[TestMethod]
		public void Can_Get_Name_From_StandardPattern()
		{
			var pattern = new StandardPattern();
			Assert.AreEqual("Standard Pattern", pattern.Name);
		}

		[TestMethod]
		public void Can_Get_Name_From_SmartStandardPattern()
		{
			var pattern = new SmartStandardPattern();
			Assert.AreEqual("Smart Standard Pattern", pattern.Name);
		}
	}
}
