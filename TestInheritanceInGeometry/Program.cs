using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceInGeometry;

namespace TestInheritanceInGeometry {
	class Program {
		//these classes have overloaded constructors that allow side lengths to be defined
		//as parameters, or using SetSides method
		void Run() {
			//Parllelogram side length can be defined with constructor OR SetSides method
			Quadrilateral quad1 = new Quadrilateral(3, 4, 5, 6);
			//quad1.SetSides(3, 4, 5, 6);
			var perimeter = quad1.CalculatePerimeter();
			Console.WriteLine($"The perimeter is {perimeter}.");

			//Parllelogram side length can be defined with constructor OR SetSides method
			Parallelogram p1 = new Parallelogram(7,3);
			//p1.SetSides(7, 3);
			perimeter = p1.CalculatePerimeter();
			var area = p1.CalculateArea();
			Console.WriteLine($"The perimeter is {perimeter}; the area is {area}");

			//Square side length can be defined with constructor OR SetSides method
			Square sqr = new Square(6);
			//sqr.SetSides(6);
			perimeter = sqr.CalculatePerimeter();
			area = sqr.CalculateArea();
			Console.WriteLine($"The perimeter is {perimeter}; the area is {area}");
		}

		static void Main(string[] args) {
			new Program().Run();
		}

	}
}
