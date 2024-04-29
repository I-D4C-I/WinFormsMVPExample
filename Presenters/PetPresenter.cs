using WinFormsWPFExample.Models;
using WinFormsWPFExample.Repositories.Common;
using WinFormsWPFExample.Views;

namespace WinFormsWPFExample.Presenters
{
    /// <summary>
    /// Представляет презентер питомцев.
    /// </summary>
    internal class PetPresenter
    {
        private readonly IPetView _view; // Представление питомцев.
        private readonly IPetRepository _repository; // Репозиторий питомцев.
        private readonly BindingSource _petsBindingSource; // Привязка источника данных к представлению.
        private IEnumerable<PetModel> _petsList = null!; // Список питомцев.

        /// <summary>
        /// Инициализирует новый экземпляр класса PetPresenter.
        /// </summary>
        /// <param name="view">Представление питомцев.</param>
        /// <param name="repository">Репозиторий питомцев.</param>
        public PetPresenter(IPetView view, IPetRepository repository)
        {
            _petsBindingSource = new BindingSource();
            _view = view;
            _repository = repository;

            // Подписка на события представления питомцев.
            view.SearchEvent += SearchPet;
            view.AddNewEvent += AddNewPet;
            view.EditEvent += LoadSelectedPetToEdit;
            view.DeleteEvent += DeleteSelectedPet;
            view.UpdateEvent += SavePet;
            view.CancelEvent += CancelEvent;

            // Установка привязки источника данных к представлению.
            view.SetPetListBindingSource(petList: _petsBindingSource);

            // Загрузка всех питомцев.
            LoadAllPets();

            view.Show(); // Отображение представления питомцев.
        }

        /// <summary>
        /// Загружает все питомцев.
        /// </summary>
        private void LoadAllPets()
        {
            //Автоматическое изменение благодаря привязки даных
            _petsList = _repository.GetAll(); // Получение всех питомцев из репозитория.
            _petsBindingSource.DataSource = _petsList; // Привязка списка питомцев к источнику данных.
        }

        /// <summary>
        /// Обработчик события поиска питомцев.
        /// </summary>
        private void SearchPet(object? sender, EventArgs e)
        {
            // Поиск питомцев по заданному значению.
            bool emptyValue = string.IsNullOrWhiteSpace(_view.SearchValue);
            if (!emptyValue)
                _petsList = _repository.GetByValue(_view.SearchValue);
            else
                _petsList = _repository.GetAll();
            _petsBindingSource.DataSource = _petsList;
        }

        /// <summary>
        /// Обработчик события отмены операции.
        /// </summary>
        private void CancelEvent(object? sender, EventArgs e)
        {
            CleanViewFields(); // Очистка полей представления.
        }

        /// <summary>
        /// Сохраняет питомца.
        /// </summary>
        private void SavePet(object? sender, EventArgs e)
        {
            var newPet = new PetModel
            {
                Id = Convert.ToInt32(_view.PetId),
                Name = _view.PetName,
                Type = _view.PetType,
                Color = _view.PetColor,
            };
            try
            {
                ModelDataValidation.Validate(newPet); // Валидация данных питомца.
                if (_view.IsEdit)
                {
                    _repository.Update(newPet); // Обновление информации о питомце.
                    _view.Message = "Питомец успешно обновлен";
                }
                else
                {
                    _repository.Insert(newPet); // Вставка нового питомца.
                    _view.Message = "Питомец успешно добален";
                }
                _view.IsSuccessful = true;
                LoadAllPets(); // Обновление списка питомцев.
                CleanViewFields(); // Очистка полей представления.
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message; // Отображение сообщения об ошибке.
            }

        }

        /// <summary>
        /// Очищает поля представления.
        /// </summary>
        private void CleanViewFields()
        {
            _view.PetId = "0";
            _view.PetName = string.Empty;
            _view.PetType = string.Empty;
            _view.PetColor = string.Empty;
        }

        /// <summary>
        /// Удаляет выбранного питомца.
        /// </summary>
        private void DeleteSelectedPet(object? sender, EventArgs e)
        {
            try
            {
                var deletedPet = (PetModel)_petsBindingSource.Current; // Получение выбранного питомца.
                _repository.Delete(petId: deletedPet.Id); // Удаление питомца из репозитория.
                _view.IsSuccessful = true;
                _view.Message = "Питомец успешно удален";
                LoadAllPets(); // Обновление списка питомцев.
            }
            catch
            {
                _view.IsSuccessful = false;
                _view.Message = "Возникла ошибка. Невозможно удалить питомца";
            }
        }

        /// <summary>
        /// Загружает информацию выбранного питомца для редактирования.
        /// </summary>
        private void LoadSelectedPetToEdit(object? sender, EventArgs e)
        {
            var currentPet = (PetModel)_petsBindingSource.Current; // Получение выбранного питомца.
            _view.PetId = currentPet.Id.ToString();
            _view.PetName = currentPet.Name;
            _view.PetType = currentPet.Type;
            _view.PetColor = currentPet.Color;
            _view.IsEdit = true;
        }

        /// <summary>
        /// Обработчик события добавления нового питомца.
        /// </summary>
        private void AddNewPet(object? sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

    }
}
