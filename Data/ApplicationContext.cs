using Microsoft.EntityFrameworkCore;
using WinFormsWPFExample.Models;

namespace WinFormsWPFExample.Data
{
    /// <summary>
    /// Представляет контекст базы данных приложения для управления питомцами.
    /// </summary>
    internal class ApplicationContext : DbContext
    {
        private readonly string _connectionString = null!;
        /// <summary>
        /// Представляет коллекцию сущностей PetModel в базе данных.
        /// </summary>
        public DbSet<PetModel> Pets => Set<PetModel>();

        /// <summary>
        /// Инициализирует новый экземпляр класса ApplicationContext с указанной строкой подключения.
        /// </summary>
        /// <param name="ConnectionString">Строка подключения к базе данных.</param>
        public ApplicationContext(string ConnectionString)
        {
            _connectionString = ConnectionString;
            Database.EnsureCreated();
        }

        /// <summary>
        /// Настраивает подключение к базе данных и опции ведения журнала.
        /// </summary>
        /// <param name="optionsBuilder">Строитель, используемый для создания или изменения опций для данного контекста.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //"Data Source=testapp.db"
            optionsBuilder.UseSqlite(_connectionString);
            optionsBuilder.LogTo(Console.WriteLine);
        }

        /// <summary>
        /// Настраивает модель базы данных и заполняет начальные данные.
        /// </summary>
        /// <param name="modelBuilder">Строитель, используемый для создания модели для этого контекста.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PetModel>().HasData(
                new PetModel { Id = 1, Name = "Бурбон", Type = "Собака", Color = "Белый" },
                new PetModel { Id = 2, Name = "Мяу-Мяу", Type = "Кошка", Color = "Многоцветный" },
                new PetModel { Id = 3, Name = "Мерлин Менсон", Type = "Папугай", Color = "Зелено-Желтый" },
                new PetModel { Id = 4, Name = "Австрятский Пингвин", Type = "Утка", Color = "Белый" },
                new PetModel { Id = 5, Name = "Ежик", Type = "Ёж", Color = "Серый" },
                new PetModel { Id = 6, Name = "Ужьик", Type = "Уж", Color = "Черный" },
                new PetModel { Id = 7, Name = "Хомик", Type = "Хомяк", Color = "Бежевый" },
                new PetModel { Id = 8, Name = "Скункс", Type = "Опуссум", Color = "Черно-Белый" }
                );
        }
    }
}