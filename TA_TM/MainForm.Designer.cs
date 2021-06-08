
namespace TA_TM
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
            this.label1 = new System.Windows.Forms.Label();
            this.AlphabetTextBox = new System.Windows.Forms.TextBox();
            this.AlphabetButton = new System.Windows.Forms.Button();
            this.TableGridView = new System.Windows.Forms.DataGridView();
            this.AddColumnTableButton = new System.Windows.Forms.Button();
            this.DeleteColumnTableButton = new System.Windows.Forms.Button();
            this.CommandGridView = new System.Windows.Forms.DataGridView();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommandGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Алфавит";
            // 
            // AlphabetTextBox
            // 
            this.AlphabetTextBox.Location = new System.Drawing.Point(366, 38);
            this.AlphabetTextBox.Name = "AlphabetTextBox";
            this.AlphabetTextBox.Size = new System.Drawing.Size(180, 22);
            this.AlphabetTextBox.TabIndex = 1;
            // 
            // AlphabetButton
            // 
            this.AlphabetButton.Location = new System.Drawing.Point(381, 66);
            this.AlphabetButton.Name = "AlphabetButton";
            this.AlphabetButton.Size = new System.Drawing.Size(153, 44);
            this.AlphabetButton.TabIndex = 3;
            this.AlphabetButton.Text = "Записать алфавит";
            this.AlphabetButton.UseVisualStyleBackColor = true;
            this.AlphabetButton.Click += new System.EventHandler(this.AlphabetButton_Click);
            // 
            // TableGridView
            // 
            this.TableGridView.AllowUserToAddRows = false;
            this.TableGridView.AllowUserToDeleteRows = false;
            this.TableGridView.AllowUserToResizeColumns = false;
            this.TableGridView.AllowUserToResizeRows = false;
            this.TableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGridView.Location = new System.Drawing.Point(24, 227);
            this.TableGridView.Name = "TableGridView";
            this.TableGridView.RowHeadersVisible = false;
            this.TableGridView.RowHeadersWidth = 51;
            this.TableGridView.RowTemplate.Height = 24;
            this.TableGridView.Size = new System.Drawing.Size(705, 178);
            this.TableGridView.TabIndex = 4;
            // 
            // AddColumnTableButton
            // 
            this.AddColumnTableButton.Location = new System.Drawing.Point(751, 252);
            this.AddColumnTableButton.Name = "AddColumnTableButton";
            this.AddColumnTableButton.Size = new System.Drawing.Size(149, 50);
            this.AddColumnTableButton.TabIndex = 5;
            this.AddColumnTableButton.Text = "Добавить столбец";
            this.AddColumnTableButton.UseVisualStyleBackColor = true;
            this.AddColumnTableButton.Click += new System.EventHandler(this.AddColumnTableButton_Click);
            // 
            // DeleteColumnTableButton
            // 
            this.DeleteColumnTableButton.Location = new System.Drawing.Point(751, 319);
            this.DeleteColumnTableButton.Name = "DeleteColumnTableButton";
            this.DeleteColumnTableButton.Size = new System.Drawing.Size(149, 50);
            this.DeleteColumnTableButton.TabIndex = 6;
            this.DeleteColumnTableButton.Text = "Удалить столбец";
            this.DeleteColumnTableButton.UseVisualStyleBackColor = true;
            this.DeleteColumnTableButton.Click += new System.EventHandler(this.DeleteColumnTableButton_Click);
            // 
            // CommandGridView
            // 
            this.CommandGridView.AllowUserToAddRows = false;
            this.CommandGridView.AllowUserToDeleteRows = false;
            this.CommandGridView.AllowUserToResizeColumns = false;
            this.CommandGridView.AllowUserToResizeRows = false;
            this.CommandGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CommandGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CommandGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommandGridView.ColumnHeadersVisible = false;
            this.CommandGridView.Location = new System.Drawing.Point(24, 120);
            this.CommandGridView.Name = "CommandGridView";
            this.CommandGridView.RowHeadersVisible = false;
            this.CommandGridView.RowHeadersWidth = 51;
            this.CommandGridView.RowTemplate.Height = 24;
            this.CommandGridView.Size = new System.Drawing.Size(705, 84);
            this.CommandGridView.TabIndex = 7;
            this.CommandGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CommandGridView_CellClick);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(381, 424);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(153, 44);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Запуск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 493);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CommandGridView);
            this.Controls.Add(this.DeleteColumnTableButton);
            this.Controls.Add(this.AddColumnTableButton);
            this.Controls.Add(this.TableGridView);
            this.Controls.Add(this.AlphabetButton);
            this.Controls.Add(this.AlphabetTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Машина Тьюринга";
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommandGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AlphabetTextBox;
        private System.Windows.Forms.Button AlphabetButton;
        private System.Windows.Forms.DataGridView TableGridView;
        private System.Windows.Forms.Button AddColumnTableButton;
        private System.Windows.Forms.Button DeleteColumnTableButton;
        private System.Windows.Forms.DataGridView CommandGridView;
        private System.Windows.Forms.Button StartButton;
    }
}

