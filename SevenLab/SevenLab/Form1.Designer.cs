namespace SevenLab
{
    partial class app
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            staff = new Button();
            client = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // staff
            // 
            staff.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            staff.Location = new Point(62, 154);
            staff.Name = "staff";
            staff.Size = new Size(409, 69);
            staff.TabIndex = 0;
            staff.Text = "Я сотрудник";
            staff.UseVisualStyleBackColor = true;
            staff.Click += button1_Click;
            // 
            // client
            // 
            client.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            client.Location = new Point(62, 270);
            client.Name = "client";
            client.Size = new Size(409, 69);
            client.TabIndex = 1;
            client.Text = "Я клиент";
            client.UseVisualStyleBackColor = true;
            client.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(86, 52);
            label1.Name = "label1";
            label1.Size = new Size(367, 53);
            label1.TabIndex = 2;
            label1.Text = "Выберите опцию";
            label1.Click += label1_Click;
            // 
            // app
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 409);
            Controls.Add(label1);
            Controls.Add(client);
            Controls.Add(staff);
            Name = "app";
            Text = "Приложение";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button staff;
        private Button client;
        private Label label1;
    }
}
