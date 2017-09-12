using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceInGeometry;

namespace TestInheritanceInGeometry {
	class Program {
		void Run() {
			Quadrilateral quad1 = new Quadrilateral();
			quad1.SetAllSides(3, 4, 5, 6);
			var perimeter = quad1.CalculatePerimeter();
			Console.WriteLine($"The perimeter is {perimeter}.");

			Parallelogram p1 = new Parallelogram();
			p1.SetAllSides(7, 3);
			perimeter = p1.CalculatePerimeter();
			Console.WriteLine($"The perimeter is {perimeter}.");

			Square sqr = new Square();
			sqr.SetAllSides(6);
			perimeter = sqr.CalculatePerimeter();
			Console.WriteLine($"The perimeter is {perimeter}.");
		}

		static void Main(string[] args) {
			new Program().Run();
		}

	}
}
