using WinFormsWPFExample.Models;
using ApplicationContext = WinFormsWPFExample.Data.ApplicationContext;

namespace WinFormsWPFExample.Repositories
{
    /// <summary>
    /// Представляет класс репозитория питомцев.
    /// </summary>
    internal class PetRepository : BaseRepository, IPetRepository
    {
        /*
         * В дальнейшем репозиторий можно сделать обобщенным
         * для работы с несколькими таблицами.
         */

        /// <summary>
        /// Инициализирует новый экземпляр класса PetRepository.
        /// </summary>
        /// <param name="connectionString">Строка подключения к базе данных.</param>
        public PetRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Удаляет питомца из базы данных по его идентификатору.
        /// </summary>
        /// <param name="petId">Идентификатор питомца для удаления.</param>
        public void Delete(long petId)
        {
            using ApplicationContext db = new(_connectionString); // Создание контекста базы данных.
            var petModel = new PetModel { Id = petId }; // Создание объекта питомца с заданным идентификатором.
            try
            {
                db.Pets.Attach(petModel); // Прикрепление питомца к контексту базы данных.
                db.Pets.Remove(petModel); // Удаление питомца.
                db.SaveChanges(); // Сохранение изменений в базе данных.
            }
            catch (Exception)
            {
                throw; // Проброс исключения.
            }
            /*
             * Можно так же реализовать:
            
                var petModel = context.Pets
                    .Where(pet => pet.Id == petId)
                    .FirstOrDefault();

                db.Pets.Remove(order);
                db.SaveChanges();
            Этот пример использует LINQ-запрос на загрузку данных заказа с идентификатором.
            Чтобы не загружать данные, используя дополнительный ненужный запрос, исползуется прикрепление к контектсу черех Attach().
            Этот подход следует использовать осторожно. Если в базе данных не существует заказа с petId идентификатором,
            то код сгенерирует исключение DbUpdateConcurrencyException.
            В примере выше также сгенерировано исключение, но NullReferenceException,
            если petModel при загрузке будет иметь значение null.
            В примере выше достаточно просто использовать проверку на null. 
            А вот с Attach уже необходимо явно определять блоки try catch. 
             */
        }

        /// <summary>
        /// Возвращает все питомцев из базы данных.
        /// </summary>
        /// <returns>Коллекция питомцев.</returns>
        public IEnumerable<PetModel> GetAll()
        {
            /*Смысл репозитория в том, что Presenter не должен знать как именно получаются данные.
            * Тут может быть логика свзяванная с вытаскиванием из файла, бд, или REST API
            * Presenter'ам без разницы откуда беруться данные, они просто вызывают GetAll()
             */

            using ApplicationContext db = new(_connectionString); // Создание контекста базы данных.
            return db.Pets.ToList(); // Возвращение всех питомцев из базы данных.
        }

        /// <summary>
        /// Возвращает питомцев из базы данных по заданному значению.
        /// </summary>
        /// <param name="value">Значение для поиска питомцев.</param>
        /// <returns>Коллекция питомцев, удовлетворяющих заданному значению.</returns>
        public IEnumerable<PetModel> GetByValue(string value)
        {
            using ApplicationContext db = new(_connectionString); // Создание контекста базы данных.
            int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0; // Преобразование строки в целое число.                                                                                 
            return db.Pets.Where(pet => pet.Name.Contains(value, StringComparison.CurrentCultureIgnoreCase) || pet.Id == petId).ToList();// Поиск питомцев по имени или идентификатору.
        }

        /// <summary>
        /// Вставляет нового питомца в базу данных.
        /// </summary>
        /// <param name="pet">Питомец для вставки.</param>
        /// <returns>Идентификатор нового питомца.</returns>
        public long Insert(PetModel pet)
        {
            using ApplicationContext db = new(_connectionString); // Создание контекста базы данных.
            db.Pets.Add(pet); // Добавление питомца в контекст.
            db.SaveChanges(); // Сохранение изменений в базе данных.
            return pet.Id; // Возвращение идентификатора нового питомца.
        }

        /// <summary>
        /// Обновляет информацию о питомце в базе данных.
        /// </summary>
        /// <param name="pet">Питомец с обновленной информацией.</param>
        public void Update(PetModel pet)
        {
            using ApplicationContext db = new(_connectionString); // Создание контекста базы данных.
            db.Entry(pet).State = Microsoft.EntityFrameworkCore.EntityState.Modified; // Установка состояния объекта как измененного.
            db.SaveChanges(); // Сохранение изменений в базе данных.
        }
    }
}
