using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class Gyanusitott
	{
		private Szemely szemely;
		private int szint;
		private string statusz;

		public Gyanusitott(Szemely szemely, int szint, string statusz)
		{
			this.szemely = szemely;
			this.szint = szint;
			this.statusz = statusz;
		}

		public int Szint { get => szint; set => szint = value; }
		public string Statusz { get => statusz; set => statusz = value; }
		internal Szemely Szemely { get => szemely; set => szemely = value; }
	}
}
