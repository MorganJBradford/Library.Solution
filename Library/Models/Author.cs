using System.Collections.Generic;
namespace Library.Models
{
  public class Author
  {
    public Author()
    {
      JoinEntities = new HashSet<AuthorBook>();
    }
    public int AuthorId { get; set; }
    //[MaxLength(255), Required, Column(TypeName = "varchar")]
    public string Name { get; set; }
    public virtual ICollection<AuthorBook> JoinEntities { get; set; }
  }
}