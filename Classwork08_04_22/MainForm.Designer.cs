
namespace Classwork08_04_22
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.RankedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(148, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(130, 45);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "СТАРТ";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RankedButton
            // 
            this.RankedButton.Location = new System.Drawing.Point(12, 12);
            this.RankedButton.Name = "RankedButton";
            this.RankedButton.Size = new System.Drawing.Size(130, 45);
            this.RankedButton.TabIndex = 3;
            this.RankedButton.Text = "Рейтинг";
            this.RankedButton.UseVisualStyleBackColor = true;
            this.RankedButton.Click += new System.EventHandler(this.RankedButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 70);
            this.Controls.Add(this.RankedButton);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Угадай пару";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RankedButton;
    }
}

