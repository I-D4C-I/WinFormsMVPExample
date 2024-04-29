namespace WinFormsWPFExample.Views
{
    /// <summary>
    /// Определяет интерфейс представления питомцев.
    /// </summary>
    internal interface IPetView
    {
        string PetId { get; set; }
        string PetName { get; set; }
        string PetType { get; set; }
        string PetColor { get; set; }

        /// <summary>
        /// Значение для поиска питомцев.
        /// </summary>
        string SearchValue { get; set; }

        /// <summary>
        /// Флаг редактирования информации о питомце.
        /// </summary>
        bool IsEdit { get; set; }

        /// <summary>
        /// Флаг успешного выполнения операции.
        /// </summary>
        bool IsSuccessful { get; set; }

        /// <summary>
        /// Сообщение об операции.
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Событие поиска питомцев.
        /// </summary>
        event EventHandler SearchEvent;

        /// <summary>
        /// Событие добавления нового питомца.
        /// </summary>
        event EventHandler AddNewEvent;

        /// <summary>
        /// Событие редактирования питомца.
        /// </summary>
        event EventHandler EditEvent;

        /// <summary>
        /// Событие удаления питомца.
        /// </summary>
        event EventHandler DeleteEvent;

        /// <summary>
        /// Событие обновления информации о питомце.
        /// </summary>
        event EventHandler UpdateEvent;

        /// <summary>
        /// Событие отмены операции.
        /// </summary>
        event EventHandler CancelEvent;

        //Binding source Создает приввязку между элементом управления данными и источником данных
        void SetPetListBindingSource(BindingSource petList);

        // Отображает представление питомцев
        void Show();
    }

}
