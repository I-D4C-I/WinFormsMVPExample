namespace WinFormsWPFExample.Models
{
    /// <summary>
    /// Определяет интерфейс репозитория питомцев.
    /// </summary>
    internal interface IPetRepository
    {
        /// <summary>
        /// Вставляет новую сущность питомца в хранилище.
        /// </summary>
        /// <param name="pet">Сущность питомца для вставки.</param>
        /// <returns>Идентификатор новой сущности питомца.</returns>
        long Insert(PetModel pet);

        /// <summary>
        /// Удаляет сущность питомца из хранилища по её идентификатору.
        /// </summary>
        /// <param name="petId">Идентификатор сущности питомца для удаления.</param>
        void Delete(long petId);

        /// <summary>
        /// Обновляет существующую сущность питомца в хранилище.
        /// </summary>
        /// <param name="pet">Сущность питомца для обновления.</param>
        void Update(PetModel pet);

        /// <summary>
        /// Возвращает все сущности питомцев из хранилища.
        /// </summary>
        /// <returns>Перечисление всех сущностей питомцев.</returns>
        IEnumerable<PetModel> GetAll();

        /// <summary>
        /// Возвращает сущности питомцев из хранилища, удовлетворяющие заданному критерию.
        /// </summary>
        /// <param name="value">Критерий поиска для сущностей питомцев: Id или имя</param>
        /// <returns>Перечисление сущностей питомцев, соответствующих заданному критерию.</returns>
        IEnumerable<PetModel> GetByValue(string value);
    }
}
