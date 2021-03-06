using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class Treat
	{
		public Treat()
		{
			this.Flavors = new HashSet<TreatFlavor>();
		}

		public int TreatId { get; set; }
		public string TreatName { get; set; }
		public virtual ICollection<TreatFlavor> Flavors { get; set; }
	}
}