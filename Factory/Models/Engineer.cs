using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Please enter an Engineer's name")]
    public string EngineerName { get; set; }
    [Required(ErrorMessage = "Please enter details about the Engineer")]
    public string EngineerDetails { get; set; }
    public List<EngineerMachine> JoinEntities { get;}
  }
}
