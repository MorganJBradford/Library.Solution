using System.Collections.Generic;

namespace Library.Models
{
  public class Patron
  {
    public Patron()
    {
      JoinEntities = new HashSet<Checkout>();
    }
    public int PatronId { get; set; }
    public string Name { get; set; }
    public string Books { get; set; }
    public virtual ApplicationUser PatronUser { get; set; }
    public virtual ICollection<Checkout> JoinEntities { get; }
  }
}