using System.Diagnostics;

namespace ePlan.TileCalculator.Model
{
	[DebuggerDisplay("({X}, {Y})")]
	struct Point
	{

		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}
		public double X { get; set; }
		public double Y { get; set; }
	}
}
