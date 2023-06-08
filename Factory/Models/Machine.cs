using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string Description { get; set; }
    public int EngineerId { get; set; }
    public Engineer Engineer { get; set; }
    public List<MachineTag> JoinEntities { get;}
    public List<MachineEngineer> MachineEngineers { get;}
  }
}
