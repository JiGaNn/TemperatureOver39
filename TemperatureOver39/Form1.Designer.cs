
namespace TemperatureOver39
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.cmbtype1 = new System.Windows.Forms.ComboBox();
            this.cmbtype2 = new System.Windows.Forms.ComboBox();
            this.cmbresultType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "сложение",
            "вычитание",
            "умножение на число",
            "сравнение"});
            this.comboBox1.Location = new System.Drawing.Point(39, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "сложение";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(191, 36);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(121, 20);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(191, 87);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(121, 20);
            this.txt2.TabIndex = 2;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(191, 146);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(121, 20);
            this.result.TabIndex = 3;
            // 
            // cmbtype1
            // 
            this.cmbtype1.FormattingEnabled = true;
            this.cmbtype1.Location = new System.Drawing.Point(318, 35);
            this.cmbtype1.Name = "cmbtype1";
            this.cmbtype1.Size = new System.Drawing.Size(45, 21);
            this.cmbtype1.TabIndex = 4;
            // 
            // cmbtype2
            // 
            this.cmbtype2.FormattingEnabled = true;
            this.cmbtype2.Location = new System.Drawing.Point(318, 87);
            this.cmbtype2.Name = "cmbtype2";
            this.cmbtype2.Size = new System.Drawing.Size(45, 21);
            this.cmbtype2.TabIndex = 5;
            // 
            // cmbresultType
            // 
            this.cmbresultType.FormattingEnabled = true;
            this.cmbresultType.Location = new System.Drawing.Point(318, 145);
            this.cmbresultType.Name = "cmbresultType";
            this.cmbresultType.Size = new System.Drawing.Size(45, 21);
            this.cmbresultType.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 211);
            this.Controls.Add(this.cmbresultType);
            this.Controls.Add(this.cmbtype2);
            this.Controls.Add(this.cmbtype1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Why so hot?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.ComboBox cmbtype1;
        private System.Windows.Forms.ComboBox cmbtype2;
        private System.Windows.Forms.ComboBox cmbresultType;
    }
}

