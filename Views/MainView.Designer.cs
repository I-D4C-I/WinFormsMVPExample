namespace WinFormsWPFExample.Views
{
    partial class MainView
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
            p_MainMenu = new Panel();
            btn_Pets = new Button();
            p_MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // p_MainMenu
            // 
            p_MainMenu.Controls.Add(btn_Pets);
            p_MainMenu.Dock = DockStyle.Left;
            p_MainMenu.Font = new Font("Segoe UI", 12F);
            p_MainMenu.Location = new Point(0, 0);
            p_MainMenu.Name = "p_MainMenu";
            p_MainMenu.Size = new Size(150, 561);
            p_MainMenu.TabIndex = 0;
            // 
            // btn_Pets
            // 
            btn_Pets.Location = new Point(3, 31);
            btn_Pets.Name = "btn_Pets";
            btn_Pets.Size = new Size(146, 43);
            btn_Pets.TabIndex = 0;
            btn_Pets.Text = "Питомцы";
            btn_Pets.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 561);
            Controls.Add(p_MainMenu);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MainView";
            p_MainMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel p_MainMenu;
        private Button btn_Pets;
    }
}