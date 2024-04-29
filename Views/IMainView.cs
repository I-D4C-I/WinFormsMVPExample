namespace WinFormsWPFExample.Views
{
    /// <summary>
    /// Определяет интерфейс представления главного окна.
    /// </summary>
    internal interface IMainView
    {
        /// <summary>
        /// Событие, возникающее при запросе отображения окна управления питомцами.
        /// </summary>
        event EventHandler ShowPetView;

        /// <summary>
        /// Событие, возникающее при запросе отображения окна управления владельцами.
        /// </summary>
        event EventHandler ShowOwnerView;

        /// <summary>
        /// Событие, возникающее при запросе отображения окна управления ветеринарами.
        /// </summary>
        event EventHandler ShowVetsView;
    }
}
