using System;

namespace ePlan.TileCalculator.Model.Patterns
{
	/// <summary>
	/// This class will attempt to calculate tile usage using simple area math.  Tile placement is normal (not diagonal, 
	/// nor offset).
	/// It will not attempt to use offcuts to minimize waste.
	/// </summary>
	public class StandardPattern : IPattern
	{
		/// <summary>
		/// Used by the UI to display a consumer-friendly name in the drop down.
		/// </summary>
		public string Name
		{
			get
			{
				return "Standard Pattern";
			}
		}

		/// <summary>
		/// The area of the room to be tiled.
		/// </summary>
		protected Room Room { get; set; }

		/// <summary>
		/// The tile size that will be used to tile the room.
		/// </summary>
		protected Tile Tile { get; set; }

		/// <summary>
		/// The grout thickness between each tile.
		/// </summary>
		public double GroutThickness { get; set; }

		/// <summary>
		/// Calculates the number of whole tiles used, along with the number of cuts
		/// and the total waste percentage.
		/// </summary>
		/// <returns>An instance of CalculatorResult.</returns>
		public virtual CalculatorResult Calculate(Room room, Tile tile, double groutThickness)
		{
			Room = room;
			Tile = tile;
			GroutThickness = groutThickness;

			CalculatorResult result = new CalculatorResult(Tile);

			// determine how many whole tiles will be used to tile the floor.
			int wholeTilesUsedAlongWidth = (int)Math.Floor(Room.Width / (Tile.Width + GroutThickness));
			int wholeTilesUsedAlongLength = (int)Math.Floor(Room.Length / (Tile.Length + GroutThickness));
			// add them to the sum of tiles
			result.WholeTilesUsed = wholeTilesUsedAlongWidth * wholeTilesUsedAlongLength;

			// determine if the 'width' require partial tiles
			// if yes, add as many partial tiles to the sum of tiles as there are whole tiles in the 'length'
			// add the offcuts to the collection for later use and waste calculation
			bool requiresIncompleteTileForWidth = false;
			double remainingWidth = Room.Width % (Tile.Width + GroutThickness);
			if (remainingWidth > 0)
			{
				requiresIncompleteTileForWidth = true;
				result.WholeTilesUsed += wholeTilesUsedAlongLength;

				for (int i = 1; i <= wholeTilesUsedAlongLength; i++)
				{
					result.Offcuts.Add(new Tile(Tile.Width - remainingWidth, Tile.Length));
				}
			}

			// determine if the 'length' require partial tiles
			// if yes, add as many partial tiles to the sum of tiles as there are whole tiles in the 'width'
			// add the offcuts to the collection for later use and waste calculation
			bool requiresIncompleteTileForLength = false;
			double remainingLength = Room.Length % (Tile.Length + GroutThickness);
			if (remainingLength > 0)
			{
				requiresIncompleteTileForLength = true;
				result.WholeTilesUsed += wholeTilesUsedAlongWidth;

				for (int i = 1; i <= wholeTilesUsedAlongWidth; i++)
				{
					result.Offcuts.Add(new Tile(Tile.Length - remainingLength, Tile.Width));
				}
			}

			// if partials were required for both width and length, then one tile must be cut twice to fill the last corner.
			// add the offcuts to the collection for later use and waste calculation
			if (requiresIncompleteTileForWidth && requiresIncompleteTileForLength)
			{
				result.WholeTilesUsed++;

				// TODO this is not ideal: it does not take into account that the second cut has a different length/width
				result.Offcuts.Add(new Tile(Tile.Length, Tile.Width - remainingWidth));
				result.Offcuts.Add(new Tile(Tile.Length - remainingLength, Tile.Width));
			}

			return result;
		}
	}
}
