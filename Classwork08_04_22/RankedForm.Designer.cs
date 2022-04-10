
namespace Classwork08_04_22
{
    partial class RankedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankedForm));
            this.RankedDGV = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RankedDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // RankedDGV
            // 
            this.RankedDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RankedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RankedDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.ScoreColumn,
            this.DateColumn});
            this.RankedDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankedDGV.Location = new System.Drawing.Point(0, 0);
            this.RankedDGV.Name = "RankedDGV";
            this.RankedDGV.RowHeadersVisible = false;
            this.RankedDGV.RowHeadersWidth = 51;
            this.RankedDGV.Size = new System.Drawing.Size(800, 450);
            this.RankedDGV.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            // 
            // ScoreColumn
            // 
            this.ScoreColumn.HeaderText = "Очки";
            this.ScoreColumn.MinimumWidth = 6;
            this.ScoreColumn.Name = "ScoreColumn";
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Дата игры";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            // 
            // RankedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RankedDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RankedForm";
            this.Text = "Рейтинговая таблица";
            ((System.ComponentModel.ISupportInitialize)(this.RankedDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RankedDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
    }
}