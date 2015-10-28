using System.Diagnostics;

namespace ePlan.TileCalculator.Model
{
	/// <summary>
	/// Represents the room that is to be tiled.  It provides the overal area that needs to be tiled.
	/// </summary>
	[DebuggerDisplay("[{Width} x {Length}]")]
	public class Room
	{
		/// <summary>
		/// Creates a room by using the provided Width and Length.
		/// </summary>
		/// <param name="width">A value, in inches, representing the Width of the room.</param>
		/// <param name="length">A value, in inches, representing the Length of the room.</param>
		public Room(double width, double length)
		{
			Width = width;
			Length = length;
		}

		/// <summary>
		/// A value, in inches, representing the Width of the room.
		/// </summary>
		public double Width { get; protected set; }

		/// <summary>
		/// A value, in inches, representing the Length of the room.
		/// </summary>
		public double Length { get; protected set; }

		/// <summary>
		/// The calculation of the area, in square inches, of the room by using the Width and the Length.
		/// </summary>
		public double Area {
			get
			{
				return Width * Length;
			}
		}
	}
}
