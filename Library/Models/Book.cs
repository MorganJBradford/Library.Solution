using System.Collections.Generic;
using System;

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
    public bool CheckedOut { get; set; }
    public int Copies { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<AuthorBook> JoinEntities { get; }
  }
}