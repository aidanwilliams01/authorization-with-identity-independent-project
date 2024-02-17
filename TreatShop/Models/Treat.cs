using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace TreatShop.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}
