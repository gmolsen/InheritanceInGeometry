using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGeometry {
	public class Square : Parallelogram {
		public void SetAllSides(int length) {
			SetAllSides(length, length);
		}
	}
}
