using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class Ugy
	{
		private int azonosito;
		private string cim;
		private string leiras;
		private string allapot;
		private List<Szemely> szemelyek;
		private List<Bizonyitek> bizonyitekok;
		private List<IdovonalEsemeny> idovonal;

		public Ugy(int azonosito, string cim, string leiras, string allapot, List<Szemely> szemelyek, List<Bizonyitek> bizonyitekok, List<IdovonalEsemeny> idovonal)
		{
			this.azonosito = azonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.szemelyek = szemelyek;
			this.bizonyitekok = bizonyitekok;
			this.idovonal = idovonal;
		}

		public int Azonosito { get => azonosito; set => azonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		public List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
		internal List<Szemely> Szemelyek { get => szemelyek; set => szemelyek = value; }
		internal List<IdovonalEsemeny> Idovonal { get => idovonal; set => idovonal = value; }
	}
}
