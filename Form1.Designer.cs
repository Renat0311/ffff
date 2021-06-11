
namespace gggg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.redakted = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // add1
            // 
            this.add1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.add1.Location = new System.Drawing.Point(45, 399);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(121, 39);
            this.add1.TabIndex = 1;
            this.add1.Text = "Добавить(1)";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // delete
            // 
            this.delete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.delete.Location = new System.Drawing.Point(286, 400);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 39);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить(1)";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(182, 389);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(111, 61);
            this.del.TabIndex = 2;
            this.del.Text = "Удалить(1)";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.delete_Click);
            // 
            // redakted
            // 
            this.redakted.ForeColor = System.Drawing.SystemColors.Desktop;
            this.redakted.Location = new System.Drawing.Point(172, 400);
            this.redakted.Name = "redakted";
            this.redakted.Size = new System.Drawing.Size(108, 39);
            this.redakted.TabIndex = 3;
            this.redakted.Text = "Редактировать(1)";
            this.redakted.UseVisualStyleBackColor = true;
            this.redakted.Click += new System.EventHandler(this.redakted_Click);
            // 
            // close
            // 
            this.close.ForeColor = System.Drawing.SystemColors.Desktop;
            this.close.Location = new System.Drawing.Point(404, 400);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 44);
            this.close.TabIndex = 5;
            this.close.Text = "Закрыть(1)";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.redakted);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "База данных";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button redakted;
        private System.Windows.Forms.Button close;
    }
}

