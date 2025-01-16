using EF_Core_App;
using Microsoft.EntityFrameworkCore;

using var dbContext = new BookContext();

var books = dbContext.Books
    .Where(x => x.Id == new Guid("61E8D0E2-B493-4B1B-94DA-B4CE297ACF06"))
    .Include(x => x.Pages)
    .ToList();

Console.WriteLine();

//var book = new Book("Amazing book");
//for (int i = 0; i < 599; i++) 
//{
//    book.Pages.Add(new Page(i, $"content - {i}"));
//}

//dbContext.Books.Add(book);
//dbContext.SaveChanges();



//var page = new Page(1, "some page text");

//dbContext.Pages.Add(page);
//dbContext.SaveChanges();

//dbContext.Pages.Remove(page);
//dbContext.SaveChanges();

////remove all
//var results = dbContext.Pages.Where(x => x.Number == 5).ToList();
//dbContext.Pages.RemoveRange(results);

////remove single
//var result = dbContext.Pages.FirstOrDefault(x => x.Id == new Guid("F2EB8F77-0190-48C4-A7D0-E52ECB0D1181"));
//dbContext.Pages.Remove(result);
//dbContext.SaveChanges();
