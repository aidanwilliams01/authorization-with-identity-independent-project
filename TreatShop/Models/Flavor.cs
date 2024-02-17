using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}