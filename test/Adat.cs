using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	internal class Adat
	{
		private string nev;
		private int ar;

		public Adat(string nev)
		{
			this.nev = nev;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Ar { get => ar; set => ar = value; }
	}
}
