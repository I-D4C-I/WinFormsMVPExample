using WinFormsWPFExample.Models;
using WinFormsWPFExample.Repositories;
using WinFormsWPFExample.Views;

namespace WinFormsWPFExample.Presenters
{
    /// <summary>
    /// Представляет презентер главного окна.
    /// </summary>
    internal class MainPresenter
    {
        private readonly IMainView _mainView = null!; // Представление главного окна.
        private readonly string _connectionString = null!; // Строка подключения к базе данных.

        /// <summary>
        /// Инициализирует новый экземпляр класса MainPresenter.
        /// </summary>
        /// <param name="mainView">Представление главного окна.</param>
        /// <param name="connectionString">Строка подключения к базе данных.</param>
        public MainPresenter(IMainView mainView, string connectionString)
        {
            _mainView = mainView;
            _connectionString = connectionString;
            mainView.ShowPetView += ShowPetView; // Подписка на событие отображения окна управления питомцами.
        }

        /// <summary>
        /// Обработчик события отображения окна управления питомцами.
        /// </summary>
        /// <param name="sender">Объект-источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ShowPetView(object? sender, EventArgs e)
        {
            // Создание экземпляра представления питомцев.
            IPetView view = PetView.GetInstance((Form)_mainView);
            // Создание экземпляра репозитория питомцев.
            IPetRepository repository = new PetRepository(connectionString: _connectionString);
            // Создание презентера питомцев.
            new PetPresenter(view: view, repository: repository);


            /*
             * Есть неудобаство, что одну и ту же форму можно открытвать столько раз, сколько захотим.
             * Если необходимо иметь только одну форму одного типа есть варианты:
             * 1. Создать список открытых форм, если форма не открыть, то создать форму, если нет, то повторно отобразить форму.
             * 2. Паттерн Singleton позволит открыть только одну форму
             */

        }
    }
}
