// See https://aka.ms/new-console-template for more information

using EFStarted.Entities;
using EFStarted.Repository;

Console.WriteLine("Usando EntityFramework Core com SQLite");

using var db = new BloggingContext();

System.Console.WriteLine(db.DbPath);

db.Add(new Blog { Url = "http:urlparaumblog"});
db.Add(new Blog { Url = "http:outraurlparaumblog"});
db.SaveChanges();

Blog? blog = db.Blogs
                    .OrderBy(b => b.BlogId).
                    FirstOrDefault();

System.Console.WriteLine(blog.Url);
