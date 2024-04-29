namespace WinFormsWPFExample.Views
{
    partial class PetView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            l_TabDetail = new Label();
            panel1 = new Panel();
            btn_CloseForm = new Button();
            tabControl = new TabControl();
            tabPagePets = new TabPage();
            dgv_PetsList = new DataGridView();
            btn_Delete = new Button();
            btn_Edit = new Button();
            btn_AddNew = new Button();
            btn_search = new Button();
            tb_Search = new TextBox();
            l_Search = new Label();
            tabPagePetDetail = new TabPage();
            tb_PetColor = new TextBox();
            tb_PetType = new TextBox();
            tb_PetName = new TextBox();
            tb_PetId = new TextBox();
            btn_Cancel = new Button();
            btn_Save = new Button();
            l_PetColor = new Label();
            l_PetType = new Label();
            l_PetName = new Label();
            l_PetId = new Label();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPagePets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_PetsList).BeginInit();
            tabPagePetDetail.SuspendLayout();
            SuspendLayout();
            // 
            // l_TabDetail
            // 
            l_TabDetail.AutoSize = true;
            l_TabDetail.Font = new Font("Segoe UI", 15F);
            l_TabDetail.Location = new Point(12, 9);
            l_TabDetail.Name = "l_TabDetail";
            l_TabDetail.Size = new Size(98, 28);
            l_TabDetail.TabIndex = 0;
            l_TabDetail.Text = "Питомцы";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_CloseForm);
            panel1.Controls.Add(l_TabDetail);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 61);
            panel1.TabIndex = 1;
            // 
            // btn_CloseForm
            // 
            btn_CloseForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_CloseForm.AutoSize = true;
            btn_CloseForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_CloseForm.Location = new Point(942, 12);
            btn_CloseForm.Name = "btn_CloseForm";
            btn_CloseForm.Size = new Size(29, 31);
            btn_CloseForm.TabIndex = 1;
            btn_CloseForm.Text = "X";
            btn_CloseForm.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPagePets);
            tabControl.Controls.Add(tabPagePetDetail);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 61);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(984, 500);
            tabControl.TabIndex = 2;
            // 
            // tabPagePets
            // 
            tabPagePets.Controls.Add(dgv_PetsList);
            tabPagePets.Controls.Add(btn_Delete);
            tabPagePets.Controls.Add(btn_Edit);
            tabPagePets.Controls.Add(btn_AddNew);
            tabPagePets.Controls.Add(btn_search);
            tabPagePets.Controls.Add(tb_Search);
            tabPagePets.Controls.Add(l_Search);
            tabPagePets.Location = new Point(4, 30);
            tabPagePets.Name = "tabPagePets";
            tabPagePets.Padding = new Padding(3);
            tabPagePets.Size = new Size(976, 466);
            tabPagePets.TabIndex = 0;
            tabPagePets.Text = "Список питомцев";
            tabPagePets.UseVisualStyleBackColor = true;
            // 
            // dgv_PetsList
            // 
            dgv_PetsList.AllowUserToAddRows = false;
            dgv_PetsList.AllowUserToDeleteRows = false;
            dgv_PetsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_PetsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_PetsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_PetsList.Location = new Point(20, 92);
            dgv_PetsList.Name = "dgv_PetsList";
            dgv_PetsList.ReadOnly = true;
            dgv_PetsList.Size = new Size(799, 366);
            dgv_PetsList.TabIndex = 6;
            // 
            // btn_Delete
            // 
            btn_Delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Delete.Location = new Point(825, 169);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(142, 32);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Удалить";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            btn_Edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Edit.Location = new Point(825, 132);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(142, 31);
            btn_Edit.TabIndex = 4;
            btn_Edit.Text = "Редактировать";
            btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_AddNew
            // 
            btn_AddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AddNew.Location = new Point(825, 92);
            btn_AddNew.Name = "btn_AddNew";
            btn_AddNew.Size = new Size(142, 34);
            btn_AddNew.TabIndex = 3;
            btn_AddNew.Text = "Добавить";
            btn_AddNew.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_search.Location = new Point(712, 45);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(107, 29);
            btn_search.TabIndex = 2;
            btn_search.Text = "Поиск";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // tb_Search
            // 
            tb_Search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_Search.Location = new Point(20, 46);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(686, 29);
            tb_Search.TabIndex = 1;
            // 
            // l_Search
            // 
            l_Search.AutoSize = true;
            l_Search.Location = new Point(20, 22);
            l_Search.Name = "l_Search";
            l_Search.Size = new Size(121, 21);
            l_Search.TabIndex = 0;
            l_Search.Text = "Поиск питомца";
            // 
            // tabPagePetDetail
            // 
            tabPagePetDetail.Controls.Add(tb_PetColor);
            tabPagePetDetail.Controls.Add(tb_PetType);
            tabPagePetDetail.Controls.Add(tb_PetName);
            tabPagePetDetail.Controls.Add(tb_PetId);
            tabPagePetDetail.Controls.Add(btn_Cancel);
            tabPagePetDetail.Controls.Add(btn_Save);
            tabPagePetDetail.Controls.Add(l_PetColor);
            tabPagePetDetail.Controls.Add(l_PetType);
            tabPagePetDetail.Controls.Add(l_PetName);
            tabPagePetDetail.Controls.Add(l_PetId);
            tabPagePetDetail.Location = new Point(4, 30);
            tabPagePetDetail.Name = "tabPagePetDetail";
            tabPagePetDetail.Padding = new Padding(3);
            tabPagePetDetail.Size = new Size(976, 466);
            tabPagePetDetail.TabIndex = 1;
            tabPagePetDetail.Text = "Подробно";
            tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // tb_PetColor
            // 
            tb_PetColor.Location = new Point(63, 249);
            tb_PetColor.Name = "tb_PetColor";
            tb_PetColor.Size = new Size(411, 29);
            tb_PetColor.TabIndex = 10;
            // 
            // tb_PetType
            // 
            tb_PetType.Location = new Point(291, 144);
            tb_PetType.Name = "tb_PetType";
            tb_PetType.Size = new Size(183, 29);
            tb_PetType.TabIndex = 9;
            // 
            // tb_PetName
            // 
            tb_PetName.Location = new Point(63, 144);
            tb_PetName.Name = "tb_PetName";
            tb_PetName.Size = new Size(183, 29);
            tb_PetName.TabIndex = 8;
            // 
            // tb_PetId
            // 
            tb_PetId.Location = new Point(63, 61);
            tb_PetId.Name = "tb_PetId";
            tb_PetId.ReadOnly = true;
            tb_PetId.ShortcutsEnabled = false;
            tb_PetId.Size = new Size(183, 29);
            tb_PetId.TabIndex = 7;
            tb_PetId.Text = "0";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(291, 334);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(183, 31);
            btn_Cancel.TabIndex = 6;
            btn_Cancel.Text = "Отменить";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            btn_Save.AutoSize = true;
            btn_Save.Location = new Point(63, 334);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(183, 31);
            btn_Save.TabIndex = 5;
            btn_Save.Text = "Сохранить";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // l_PetColor
            // 
            l_PetColor.AutoSize = true;
            l_PetColor.Location = new Point(63, 225);
            l_PetColor.Name = "l_PetColor";
            l_PetColor.Size = new Size(114, 21);
            l_PetColor.TabIndex = 3;
            l_PetColor.Text = "Цвет Питомца";
            // 
            // l_PetType
            // 
            l_PetType.AutoSize = true;
            l_PetType.Location = new Point(291, 120);
            l_PetType.Name = "l_PetType";
            l_PetType.Size = new Size(105, 21);
            l_PetType.TabIndex = 2;
            l_PetType.Text = "Тип Питомца";
            // 
            // l_PetName
            // 
            l_PetName.AutoSize = true;
            l_PetName.Location = new Point(63, 120);
            l_PetName.Name = "l_PetName";
            l_PetName.Size = new Size(110, 21);
            l_PetName.TabIndex = 1;
            l_PetName.Text = "Имя Питомца";
            // 
            // l_PetId
            // 
            l_PetId.AutoSize = true;
            l_PetId.Location = new Point(63, 37);
            l_PetId.Name = "l_PetId";
            l_PetId.Size = new Size(94, 21);
            l_PetId.TabIndex = 0;
            l_PetId.Text = "ID Питомца";
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "PetView";
            Text = "PetView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPagePets.ResumeLayout(false);
            tabPagePets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_PetsList).EndInit();
            tabPagePetDetail.ResumeLayout(false);
            tabPagePetDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label l_TabDetail;
        private Panel panel1;
        private TabControl tabControl;
        private TabPage tabPagePets;
        private TabPage tabPagePetDetail;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_AddNew;
        private Button btn_search;
        private TextBox tb_Search;
        private Label l_Search;
        private DataGridView dgv_PetsList;
        private Button btn_Cancel;
        private Button btn_Save;
        private Label l_PetColor;
        private Label l_PetType;
        private Label l_PetName;
        private Label l_PetId;
        private TextBox tb_PetColor;
        private TextBox tb_PetType;
        private TextBox tb_PetName;
        private TextBox tb_PetId;
        private Button btn_CloseForm;
    }
}