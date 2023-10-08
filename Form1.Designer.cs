namespace RGRerm
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.bt_run = new System.Windows.Forms.Button();
            this.random_b = new System.Windows.Forms.Button();
            this.result_b = new System.Windows.Forms.Button();
            this.bt26 = new System.Windows.Forms.Button();
            this.bt43 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt15 = new System.Windows.Forms.Button();
            this.bt32 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ColumnHeadersVisible = false;
            this.DGV.Location = new System.Drawing.Point(46, 12);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.Size = new System.Drawing.Size(630, 344);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "столбцы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "строки";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(109, 384);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 3;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(109, 406);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 4;
            // 
            // bt_run
            // 
            this.bt_run.Location = new System.Drawing.Point(277, 384);
            this.bt_run.Name = "bt_run";
            this.bt_run.Size = new System.Drawing.Size(174, 42);
            this.bt_run.TabIndex = 5;
            this.bt_run.Text = "сгенерировать матрицу";
            this.bt_run.UseVisualStyleBackColor = true;
            this.bt_run.Click += new System.EventHandler(this.bt_run_Click);
            // 
            // random_b
            // 
            this.random_b.Location = new System.Drawing.Point(698, 384);
            this.random_b.Name = "random_b";
            this.random_b.Size = new System.Drawing.Size(89, 41);
            this.random_b.TabIndex = 1;
            this.random_b.Text = "random generation";
            this.random_b.UseVisualStyleBackColor = true;
            this.random_b.Click += new System.EventHandler(this.random_b_Click);
            // 
            // result_b
            // 
            this.result_b.Location = new System.Drawing.Point(698, 217);
            this.result_b.Name = "result_b";
            this.result_b.Size = new System.Drawing.Size(75, 23);
            this.result_b.TabIndex = 7;
            this.result_b.Text = "9";
            this.result_b.UseVisualStyleBackColor = true;
            this.result_b.Click += new System.EventHandler(this.result_b_Click_1);
            // 
            // bt26
            // 
            this.bt26.Location = new System.Drawing.Point(698, 35);
            this.bt26.Name = "bt26";
            this.bt26.Size = new System.Drawing.Size(75, 23);
            this.bt26.TabIndex = 8;
            this.bt26.Text = "26";
            this.bt26.UseVisualStyleBackColor = true;
            this.bt26.Click += new System.EventHandler(this.bt26_Click);
            // 
            // bt43
            // 
            this.bt43.Location = new System.Drawing.Point(698, 122);
            this.bt43.Name = "bt43";
            this.bt43.Size = new System.Drawing.Size(75, 23);
            this.bt43.TabIndex = 9;
            this.bt43.Text = "43";
            this.bt43.UseVisualStyleBackColor = true;
            this.bt43.Click += new System.EventHandler(this.bt43_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(698, 166);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 23);
            this.bt4.TabIndex = 10;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt15
            // 
            this.bt15.Location = new System.Drawing.Point(698, 81);
            this.bt15.Name = "bt15";
            this.bt15.Size = new System.Drawing.Size(75, 23);
            this.bt15.TabIndex = 11;
            this.bt15.Text = "15";
            this.bt15.UseVisualStyleBackColor = true;
            this.bt15.Click += new System.EventHandler(this.bt15_Click);
            // 
            // bt32
            // 
            this.bt32.Location = new System.Drawing.Point(698, 262);
            this.bt32.Name = "bt32";
            this.bt32.Size = new System.Drawing.Size(75, 23);
            this.bt32.TabIndex = 12;
            this.bt32.Text = "32";
            this.bt32.UseVisualStyleBackColor = true;
            this.bt32.Click += new System.EventHandler(this.bt32_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt32);
            this.Controls.Add(this.bt15);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt43);
            this.Controls.Add(this.bt26);
            this.Controls.Add(this.result_b);
            this.Controls.Add(this.random_b);
            this.Controls.Add(this.bt_run);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button bt_run;
        private System.Windows.Forms.Button random_b;
        private System.Windows.Forms.Button result_b;
        private System.Windows.Forms.Button bt26;
        private System.Windows.Forms.Button bt43;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt15;
        private System.Windows.Forms.Button bt32;
    }
}

