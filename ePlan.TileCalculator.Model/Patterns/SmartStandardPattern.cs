using System.ComponentModel.Composition;

namespace ePlan.TileCalculator.Model.Patterns
{
	/// <summary>
	/// This class will attempt to calculate tile usage.  Tile placement is normal (not diagonal, nor offset).
	/// However, this calculation will use offcuts where possible to minimize waste.
	/// </summary>
	[Export(typeof(IPattern))]
	public class SmartStandardPattern : StandardPattern, IPattern
	{
		/// <summary>
		/// Used by the UI to display a consumer-friendly name in the drop down.
		/// </summary>
		public string Name
		{
			get
			{
				return "Smart Standard Pattern";
			}
		}

		/// <summary>
		/// Calculates the number of whole tiles used, along with the number of cuts
		/// and the total waste percentage.
		/// </summary>
		/// <returns>An instance of CalculatorResult.</returns>
		public override CalculatorResult Calculate(Room room, Tile tile, double groutThickness)
		{
			Room = room;
			Tile = tile;
			GroutThickness = groutThickness;

			CalculatorResult result = new CalculatorResult(Tile);

			bool roomComplete = false;
			Point origin = new Point(0, 0);

			while (roomComplete == false)
			{
				// can a whole tile be placed?
				Point destination = new Point(origin.X + Tile.Width, origin.Y + Tile.Length);
				if (destination.X <= Room.Width & destination.Y <= Room.Length)
				{
					result.WholeTilesUsed++;

					origin.X += Tile.Width + GroutThickness;
				}
				
				// there is not enough room in width, a tile has to be cut
				else if (destination.X > Room.Width & destination.Y <= Room.Length)
                {
					Area availableArea = new Area(Room.Width - origin.X, Tile.Length);

					// look for an offcut
					var foundTile = result.FindMatchingOffcut(availableArea);
					if (foundTile == null)
					{
						foundTile = Tile;
						result.WholeTilesUsed++;
					}

					foundTile.CutPartialTile(availableArea).ForEach(o => result.Offcuts.Add(o));

					origin.X = 0;
					origin.Y += Tile.Length + GroutThickness;
				}
				
				// there is not enough room in length, a tile has to be cut
				else if (destination.X <= Room.Width & destination.Y > Room.Length)
				{
					Area availableArea = new Area(Tile.Width, Room.Length - origin.Y);

					// look for an offcut
					var foundTile = result.FindMatchingOffcut(availableArea);
					if (foundTile == null)
					{
						foundTile = Tile;
						result.WholeTilesUsed++;
					}

					foundTile.CutPartialTile(availableArea).ForEach(o => result.Offcuts.Add(o));

					origin.X += Tile.Width + GroutThickness;
				}
				
				// there is not enough room in length or width, a tile has to be cut twice
				else if (destination.X > Room.Width & destination.Y > Room.Length)
				{
					Area availableArea = new Area(Room.Width - origin.X, Room.Length - origin.Y);

					// look for an offcut
					var foundTile = result.FindMatchingOffcut(availableArea);
					if (foundTile == null)
					{
						foundTile = Tile;
						result.WholeTilesUsed++;
					}

					foundTile.CutPartialTile(availableArea).ForEach(o => result.Offcuts.Add(o));

					origin.X += Tile.Width + GroutThickness;
					origin.Y += Tile.Length + GroutThickness;
				}

				if (destination.X >= Room.Width & destination.Y >= Room.Length)
				{
					roomComplete = true;
				}
			}

			return result;
		}
	}
}
