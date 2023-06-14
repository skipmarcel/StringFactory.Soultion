using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }

    [Required(ErrorMessage = "A machine name is required.")]
    public string MachineName { get; set; }

    [Required(ErrorMessage = "Please description the machine.")]
    public string MachineDescription { get; set; }
    public List<EngineerMachine> JoinEntities { get; set; }   
  }
}

