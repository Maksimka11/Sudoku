namespace Sudoku
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
            this.dgvSudoku = new System.Windows.Forms.DataGridView();
            this.StartNumber = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRow = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.tbColumn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudoku)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSudoku
            // 
            this.dgvSudoku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSudoku.ColumnHeadersVisible = false;
            this.dgvSudoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.dgvSudoku.Location = new System.Drawing.Point(13, 53);
            this.dgvSudoku.Name = "dgvSudoku";
            this.dgvSudoku.ReadOnly = true;
            this.dgvSudoku.RowHeadersVisible = false;
            this.dgvSudoku.Size = new System.Drawing.Size(385, 305);
            this.dgvSudoku.TabIndex = 0;
            this.dgvSudoku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSudoku_CellClick);
            this.dgvSudoku.RowCount = 9;
            this.dgvSudoku.ColumnCount = 9;
            // 
            // StartNumber
            // 
            this.StartNumber.AutoSize = true;
            this.StartNumber.Location = new System.Drawing.Point(13, 13);
            this.StartNumber.Name = "StartNumber";
            this.StartNumber.Size = new System.Drawing.Size(152, 13);
            this.StartNumber.TabIndex = 1;
            this.StartNumber.Text = "Начальное количество цифр";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(171, 10);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 2;
            this.tbNumber.Text = "25";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(299, 8);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(99, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Клетка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Значение";
            // 
            // tbRow
            // 
            this.tbRow.Location = new System.Drawing.Point(72, 374);
            this.tbRow.Name = "tbRow";
            this.tbRow.Size = new System.Drawing.Size(100, 20);
            this.tbRow.TabIndex = 7;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(72, 409);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 7;
            // 
            // tbColumn
            // 
            this.tbColumn.Location = new System.Drawing.Point(178, 374);
            this.tbColumn.Name = "tbColumn";
            this.tbColumn.Size = new System.Drawing.Size(100, 20);
            this.tbColumn.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 488);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.tbColumn);
            this.Controls.Add(this.tbRow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.StartNumber);
            this.Controls.Add(this.dgvSudoku);
            this.Name = "Form1";
            this.Text = "Судоку";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudoku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSudoku;
        private System.Windows.Forms.Label StartNumber;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRow;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.TextBox tbColumn;
    }
}

