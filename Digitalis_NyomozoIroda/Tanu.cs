using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class Tanu
	{
		private Szemely szemely;
		private string vallomas;
		private DateTime vallomasDatuma;

		public Tanu(Szemely szemely, string vallomas, DateTime vallomasDatuma)
		{
			this.szemely = szemely;
			this.vallomas = vallomas;
			this.vallomasDatuma = vallomasDatuma;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public DateTime VallomasDatuma { get => vallomasDatuma; set => vallomasDatuma = value; }
		internal Szemely Szemely { get => szemely; set => szemely = value; }
	}
}
