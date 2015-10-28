using ePlan.TileCalculator.Model;
using ePlan.TileCalculator.Model.Patterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ePlan.TileCalculator.UI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			var catalog = new AggregateCatalog();
			catalog.Catalogs.Add(new AssemblyCatalog(typeof(Form1).Assembly));
			catalog.Catalogs.Add(new DirectoryCatalog(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
			PatternContainer = new CompositionContainer(catalog);

			try
			{
				PatternContainer.ComposeParts(this);
			}
			catch (CompositionException compositionException)
			{
				throw new Exception(compositionException.ToString());
			}
		}

		private CompositionContainer PatternContainer { get; set; }

		[ImportMany(typeof(IPattern))]
		public List<IPattern> Patterns { get; set; }

		private void Form1_Load(object sender, EventArgs e)
		{
			cmbPattern.DataSource = Patterns;
			cmbPattern.DisplayMember = "Name";
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			var room = new Room(double.Parse(txtRoomWidth.Text), double.Parse(txtRoomLength.Text));
			var tile = new Tile(double.Parse(txtTileWidth.Text), double.Parse(txtTileLength.Text));
			var groutThickness = double.Parse(txtGroutThickness.Text);

			IPattern pattern = (IPattern)cmbPattern.SelectedItem;
			var result = pattern.Calculate(room, tile, groutThickness);

			txtTotalTilesUsed.Text = result.WholeTilesUsed.ToString();
			txtTotalCuts.Text = result.TotalCuts.ToString();
			txtWaste.Text = result.WastePercentage.ToString("P2");
		}
	}
}
