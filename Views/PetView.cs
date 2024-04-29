namespace WinFormsWPFExample.Views
{
    public partial class PetView : Form, IPetView
    {
        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl.TabPages.Remove(tabPagePetDetail);
            btn_CloseForm.Click += delegate { Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Поиск
            btn_search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tb_Search.KeyDown += (sender, eventArgs) =>
            {
                if (eventArgs.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Добавить
            btn_AddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPagePets);
                tabControl.TabPages.Add(tabPagePetDetail);
                l_TabDetail.Text = "Добавить";
            };
            //Изменить 
            btn_Edit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPagePets);
                tabControl.TabPages.Add(tabPagePetDetail);
                l_TabDetail.Text = "Изменить ";
            };
            //Удалить
            btn_Delete.Click += delegate
            {
                var result = MessageBox.Show(text: "Удалить выбраного питомца?", caption: "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }
            };

            //Сохранить
            btn_Save.Click += delegate
            {
                UpdateEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl.TabPages.Remove(tabPagePetDetail);
                    tabControl.TabPages.Add(tabPagePets);
                };
                MessageBox.Show(Message);
            };

            //Отмена
            btn_Cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPagePetDetail);
                tabControl.TabPages.Add(tabPagePets);
            };
        }


        //Приемущество MVP паттерна, presenter может взаимодействовать с содержимым формы не имея зависимоти от form, благодаря интерфесу и вне зависимости от вида control'а

        public string PetId { get => tb_PetId.Text; set => tb_PetId.Text = value; }
        public string PetName { get => tb_PetName.Text; set => tb_PetName.Text = value; }
        public string PetType { get => tb_PetType.Text; set => tb_PetType.Text = value; }
        public string PetColor { get => tb_PetColor.Text; set => tb_PetColor.Text = value; }
        public string SearchValue { get => tb_Search.Text; set => tb_Search.Text = value; }

        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler CancelEvent;

        public void SetPetListBindingSource(BindingSource petList) => dgv_PetsList.DataSource = petList;


        //Singleton
        private static PetView? _instance;
        public static PetView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new PetView
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,

                };
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                    _instance.WindowState = FormWindowState.Normal;
                _instance.BringToFront();
            }
            return _instance;
        }


    }
}
