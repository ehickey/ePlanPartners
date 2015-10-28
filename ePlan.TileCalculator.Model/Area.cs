using System.Diagnostics;

namespace ePlan.TileCalculator.Model
{
	/// <summary>
	/// Used as a simple value that holds the width and length of an area.
	/// </summary>
	[DebuggerDisplay("[{Width} x {Length}]")]
	public struct Area
	{
		/// <summary>
		/// Creates the Area object using the specified Width and length.
		/// </summary>
		/// <param name="width">A value, in inches, representing the Width of the area.</param>
		/// <param name="length">A value, in inches, representing the Length of the area.</param>
		public Area(double width, double length)
		{
			Width = width;
			Length = length;
		}

		/// <summary>
		/// A value, in inches, representing the Width of an area.
		/// </summary>
		public double Width { get; set; }

		/// <summary>
		/// A value, in inches, representing the Length of an area.
		/// </summary>
		public double Length { get; set; }

		/// <summary>
		/// The computed area, in square inches, by using the Width and the Length.
		/// </summary>
		public double ComputedArea
		{
			get
			{
				return Width * Length;
			}
		}
	}
}
