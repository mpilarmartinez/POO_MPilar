using Asociaciones.ManyToMany;
using Asociaciones.ManyToOne;
using Asociaciones.OneToOne;
using System.Reflection;

Console.WriteLine("--------OneToOne--------");

Address address = new Address { Id = 1, Street = "Calle 1", City = "Madrid" };

Customer  customer = new Customer { Id =1, Name = "" , Age = 30, address = address};

Console.WriteLine(address);
Console.WriteLine(customer);

Console.WriteLine("--------OneToMany y ManyToOne--------");

Author author1 = new Author { Id = 1, Name = "Author 1" };
Book book1 = new Book { id = 1, title = "Book 1", Author = author1 };
Book book2 = new Book { id = 2, title = "Book 2", Author = author1 };
Book book3 = new Book { id = 3, title = "Book 3", Author = author1 };

author1.books = new List<Book> { book1, book2, book3 };

Console.WriteLine(author1);

Console.WriteLine("--------ManyToMany--------");

//Crear peliculas
Film film1 = new Film { Id = 1, Title = "Film 1", Duration = 120 };
Film film2 = new Film { Id = 2, Title = "Film 2", Duration = 100 };

//Crear categorias
Category category1 = new Category { Id = 1, Name = "Comedia", Color = "Amarillo" };
Category category2 = new Category { Id = 2, Name = "Terror", Color = "Negro" };
Category category3 = new Category { Id = 3, Name = "Accion", Color = "Verde" };

//Asociar
film1.categories.Add(category1);
film1.categories.Add(category3);

film2.categories.Add(category2);
film2.categories.Add(category3);