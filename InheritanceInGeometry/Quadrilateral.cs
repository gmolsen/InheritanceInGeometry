using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGeometry
{
    public class Quadrilateral {
		private int s1;
		private int s2;
		private int s3;
		private int s4;

		public void SetAllSides(int side1, int side2, int side3, int side4) {
			s1 = side1;
			s2 = side2;
			s3 = side3;
			s4 = side4;
		}
		public int CalculatePerimeter() {
			var totalLength = s1 + s2 + s3 + s4;
			return totalLength;
		}
    }
}
