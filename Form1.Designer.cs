namespace deneme_winformapp
{
    partial class Form1
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
            button1 = new Button();
            label1 = new Label();
            lbl_Adınız = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(367, 172);
            button1.Name = "button1";
            button1.Size = new Size(131, 76);
            button1.TabIndex = 0;
            button1.Text = "Sakın Basma";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(21, 71);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Adınız :";
            // 
            // lbl_Adınız
            // 
            lbl_Adınız.AutoSize = true;
            lbl_Adınız.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_Adınız.Location = new Point(109, 79);
            lbl_Adınız.Name = "lbl_Adınız";
            lbl_Adınız.Size = new Size(40, 15);
            lbl_Adınız.TabIndex = 2;
            lbl_Adınız.Text = "label2";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(21, 106);
            button2.Name = "button2";
            button2.Size = new Size(126, 64);
            button2.TabIndex = 3;
            button2.Text = "Yazdır";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 483);
            Controls.Add(button2);
            Controls.Add(lbl_Adınız);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "KırmızıButon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label lbl_Adınız;
        private Button button2;
    }
}
