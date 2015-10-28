using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System;

namespace ePlan.TileCalculator.Model
{
	/// <summary>
	/// Defines the results of the calculation, which includes the number of whole tiles used,
	/// the total number of cuts made, and the waste percentange
	/// </summary>
	public class CalculatorResult
	{
		public CalculatorResult(Tile tile)
		{
			Tile = tile;
			Offcuts = new ObservableCollection<Tile>();

			Offcuts.CollectionChanged += Offcuts_CollectionChanged;
		}

		private void Offcuts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == NotifyCollectionChangedAction.Add)
			{
				TotalCuts++;
			}
		}

		public Tile Tile { get; internal set; }
		/// <summary>
		/// Gets the number of whole tiles used based on the pattern
		/// and area of the room provided.
		/// </summary>
		public int WholeTilesUsed { get; internal set; }

		/// <summary>
		/// Gets the total number of cuts made during the tiling operation.
		/// Cuts are incremented by adding offcuts to the Offcuts collection.
		/// </summary>
		public int TotalCuts { get; internal set; }

		/// <summary>
		/// Gets the total waste percentage as the amount of tiling that was offcut
		/// and unable to be used for a later placement.
		/// This value is rounded to the nearest 100th of a percentage.
		/// </summary>
		public double WastePercentage {
			get
			{
				return Math.Round(Offcuts.Sum(o => o.Area) / (Tile.Area * WholeTilesUsed), 2);
			}
		}

		/// <summary>
		/// Represents the collection of offcuts that are produced during a cut.
		/// These are later used, if possible, instead of cutting a whole tile.
		/// </summary>
		public ObservableCollection<Tile> Offcuts { get; internal set; }

		public Tile FindMatchingOffcut(Area requiredArea)
		{
			Tile selectedOffcut = null;

			foreach (Tile offcut in Offcuts)
			{
				if (offcut.Width >= requiredArea.Width & offcut.Length >= requiredArea.Length)
				{
					selectedOffcut = offcut;
					break;
				}

				if (offcut.Length >= requiredArea.Width & offcut.Width >= requiredArea.Length)
				{
					offcut.Rotate();
					selectedOffcut = offcut;
					break;
				}
            }

			Offcuts.Remove(selectedOffcut);
			return selectedOffcut;
		}
	}
}
