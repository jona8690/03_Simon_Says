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

			Start:

			string Input = Console.ReadLine();

			char[] space = { ' ' };
			string[] cmd = Input.Split(space);

			switch(cmd[0]) {
				default:
					Console.WriteLine("Unknow Command. Use !commands to show all.");
					break;

				case "!commands":
					ShowCommands();
					break;

				case "echo":
					Console.WriteLine(simon.Echo(cmd[1]));
					break;

				case "shout":
					Console.WriteLine(simon.Shout(cmd[1]));
					break;

				case "repeat":
					int Repeat = Int32.Parse(cmd[2]);
					Console.WriteLine(simon.Repeat(cmd[1], Repeat));
					break;
			}

			EndProgram();
			goto Start;
		}

		private static void ShowCommands() {
			List<string> Commands = new List<string>();

			Commands.Add("echo <input> - Repat what you enter");
			Commands.Add("shout <input> - Shout what you enter");
			Commands.Add("repeat <input> <times> - Repat what you enter");

			foreach (string write in Commands) {
				Console.WriteLine(write);
			}
		}

		private static void EndProgram() {
			Console.WriteLine("");
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
			Console.Clear();
		}
	}
}
