using System.Collections.Generic;
using System;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      JoinEntities = new HashSet<AuthorBook>();
      this.Copies = new HashSet<Copy>();
    }
    
    public int BookId { get; set; }
    public string Title { get; set; }

    public virtual ApplicationUser Librarian { get; set; }
    public virtual ICollection<AuthorBook> JoinEntities { get; }
    public ICollection<Copy> Copies { get; set; }
  }
}