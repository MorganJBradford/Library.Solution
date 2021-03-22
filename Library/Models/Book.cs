using System.Collections.Generic;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      JoinEntities = new HashSet<AuthorBook>();
    }
    
    public int BookId { get; set; }
    public string Title { get; set; }
    public DateTime CheckOut { get; set; }
    public DateTime DueDate { get; set; }
    public virtual ApplicationUser Librarian { get; set; }
    public virtual ICollection<AuthorBook> JoinEntities { get; }
  }
}