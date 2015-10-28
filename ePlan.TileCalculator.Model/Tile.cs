using System.Collections.Generic;
using System.Diagnostics;

namespace ePlan.TileCalculator.Model
{
	/// <summary>
	/// Represents the information pertaining to a tile, including the Width and Length, and also provides functions that assist in the tiling process.
	/// </summary>
	[DebuggerDisplay("[{Width} x {Length}]")]
	public class Tile
	{
		/// <summary>
		/// Creates a Tile (or offcut) using the provided Width and Length.
		/// </summary>
		/// <param name="width">A value, in inches, representing the Width of the tile.</param>
		/// <param name="length">A value, in inches, representing the Length of the tile.</param>
		public Tile(double width, double length)
		{
			Width = width;
			Length = length;
		}

		/// <summary>
		/// A value, in inches, representing the Width of the tile.
		/// </summary>
		public double Width { get; set; }

		/// <summary>
		/// A value, in inches, representing the Length of the tile.
		/// </summary>
		public double Length { get; set; }

		/// <summary>
		/// The calculation of the area, in square inches, of the tile by using the Width and the Length.
		/// </summary>
		public double Area
		{
			get
			{
				return Width * Length;
			}
		}

		/// <summary>
		/// Rotates the tile (or offcut), so that the Width and Length are switched.
		/// </summary>
		public void Rotate()
		{
			var width = Width;
			Width = Length;
			Length = width;
		}

		/// <summary>
		/// Calculates the number of offcuts needed to achieve the area to keep, and returns a collection of those offcuts as tiles.
		/// </summary>
		/// <param name="areaToKeep">The area that we need to tile; everything else will be waste.</param>
		/// <returns>A collection of offcuts, as tiles.</returns>
		public List<Tile> CutPartialTile(Area areaToKeep)
		{
			Tile partialTile = new Tile(Width, Length);

			var offCuts = new List<Tile>();

			if (areaToKeep.Width < Width)
			{
				offCuts.Add(new Tile(partialTile.Width - areaToKeep.Width, Length));
				partialTile.Width = areaToKeep.Width;
			}

			if (areaToKeep.Length < Length)
			{
				offCuts.Add(new Tile(partialTile.Width, partialTile.Length - areaToKeep.Length));
				partialTile.Length = areaToKeep.Length;
			}

			return offCuts;
		}
	}
}
