using System.Collections.Generic;

namespace Factory.Models
{
  public class Tag
  {
    public int TagId { get; set; }
    public string Title { get; set; }
    public List<MachineTag> JoinEntities { get;}
  }
}
