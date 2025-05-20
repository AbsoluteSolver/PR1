namespace PR1
{
    partial class CalculationsForm
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
            back = new Button();
            material = new ComboBox();
            calcBtn = new Button();
            count = new TextBox();
            label1 = new Label();
            materialsList = new TextBox();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(103, 186, 128);
            back.Font = new Font("Segoe UI", 9F);
            back.ForeColor = Color.White;
            back.Location = new Point(209, 188);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(130, 24);
            back.TabIndex = 8;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // material
            // 
            material.FormattingEnabled = true;
            material.Location = new Point(15, 22);
            material.Name = "material";
            material.Size = new Size(150, 23);
            material.TabIndex = 9;
            // 
            // calcBtn
            // 
            calcBtn.BackColor = Color.FromArgb(103, 186, 128);
            calcBtn.Font = new Font("Segoe UI", 9F);
            calcBtn.ForeColor = Color.White;
            calcBtn.Location = new Point(15, 90);
            calcBtn.Margin = new Padding(3, 2, 3, 2);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(150, 24);
            calcBtn.TabIndex = 10;
            calcBtn.Text = "Рассчитать";
            calcBtn.UseVisualStyleBackColor = false;
            calcBtn.Click += calcBtn_Click;
            // 
            // count
            // 
            count.Location = new Point(65, 62);
            count.Name = "count";
            count.Size = new Size(100, 23);
            count.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 65);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 12;
            label1.Text = "Кол-во:";
            // 
            // materialsList
            // 
            materialsList.Location = new Point(184, 22);
            materialsList.Multiline = true;
            materialsList.Name = "materialsList";
            materialsList.Size = new Size(199, 92);
            materialsList.TabIndex = 13;
            // 
            // CalculationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 232, 211);
            ClientSize = new Size(409, 223);
            Controls.Add(materialsList);
            Controls.Add(label1);
            Controls.Add(count);
            Controls.Add(calcBtn);
            Controls.Add(material);
            Controls.Add(back);
            Name = "CalculationsForm";
            Text = "CalculationsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private ComboBox material;
        private Button calcBtn;
        private TextBox count;
        private Label label1;
        private TextBox materialsList;
    }
}