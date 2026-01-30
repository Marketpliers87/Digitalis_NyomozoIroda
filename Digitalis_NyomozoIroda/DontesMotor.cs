using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class DontesMotor
	{
		private int kuszobErtek;

		public DontesMotor(int kuszobErtek)
		{
			this.kuszobErtek = kuszobErtek;
		}

		public int KuszobErtek { get => kuszobErtek; set => kuszobErtek = value; }

		public void Ertekel(Gyanusitott gyanusitott, Bizonyitek bizonyitek)
		{
			int noveles = bizonyitek.Megbizhatosag * 10;
			gyanusitott.GyanusitasSzint += noveles;

			if (gyanusitott.GyanusitasSzint >= kuszobErtek)
			{
				Console.WriteLine("⚠️ FIGYELEM: Gyanúsítottsági küszöb elérve!");
			}
		}
	}
}
