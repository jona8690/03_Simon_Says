using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Simon_Says;

namespace SimonSaysInterface {
	class Program {
		static void Main(string[] args) {
			Simon simon = new Simon();

			string Input = Console.ReadLine();

			Console.WriteLine(simon.Echo(Input));
		}
	}
}
