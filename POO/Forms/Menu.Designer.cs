namespace POO
{
    partial class Menu
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
            btnGestionar = new Button();
            SuspendLayout();
            // 
            // btnGestionar
            // 
            btnGestionar.Location = new Point(21, 12);
            btnGestionar.Name = "btnGestionar";
            btnGestionar.Size = new Size(141, 23);
            btnGestionar.TabIndex = 0;
            btnGestionar.Text = "Gestionar Clientes";
            btnGestionar.UseVisualStyleBackColor = true;
            btnGestionar.Click += btnGestionar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGestionar);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionar;
    }
}