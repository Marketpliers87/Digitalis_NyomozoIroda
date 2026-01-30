using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class UgyAllapot
	{
		private string allapot;

		public UgyAllapot(string allapot)
		{
			this.allapot = allapot;
		}

		public string Allapot { get => allapot; set => allapot = value; }
	}
}
