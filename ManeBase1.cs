using System;
using System.Data.Entity;
using System.Linq;

namespace ServiceLibrary
{
    public class ManeBase1 : DbContext
    {
        // Контекст настроен для использования строки подключения "ManeBase1" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "ServiceLibrary.ManeBase1" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ManeBase1" 
        // в файле конфигурации приложения.
        public ManeBase1()
            : base("name=ManeBase1")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Author> Authors { get; set; }
         public virtual DbSet<Admin> Admins { get; set; }
         public virtual DbSet<Book> Books { get; set; }
         public virtual DbSet<BookAuthor> BookAuthors { get; set; }
         public virtual DbSet<Comment> Comments { get; set; }
         public virtual DbSet<Genre> Genres { get; set; }
         public virtual DbSet<Сomplaint> Сomplaints { get; set; }
         public virtual DbSet<ListСomplaint> ListСomplaint { get; set; }
    }

    //public class MyEntity ListСomplaint
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}