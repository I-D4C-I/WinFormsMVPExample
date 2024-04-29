using WinFormsWPFExample.Presenters;
using WinFormsWPFExample.Views;

namespace WinFormsWPFExample
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string connectionString = "Data Source=testapp.db";
            IMainView view = new MainView();
            new MainPresenter(view, connectionString);
            Application.Run((Form)view);
        }
    }
}

/*
 * Для DI можно создать контейнер о типу:
 * Сопоставление в контейнере регестрируется таким обраом, чтобы он мог создать правильный объект для данного типа,
 * то есть указать какой класс должен быть создан для указаного интерфейса
 * Resolve Заботится о создании объекта и автоматически введет зависимости
var container =  new Cotainer()
container.RegisterType<IPetView, PetView>();
container.RegisterType<IPetRepository, PetRepository>();

var Presenter = container.Resolve<PetPresenter>();
 */