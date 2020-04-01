namespace Category.UI
{
    partial class FormCategory
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
            this.Update_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Del_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCatId = new System.Windows.Forms.TextBox();
            this.tbCatName = new System.Windows.Forms.TextBox();
            this.Show_btn = new System.Windows.Forms.Button();
            this.dGW1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).BeginInit();
            this.SuspendLayout();
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(6, 185);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(162, 31);
            this.Update_btn.TabIndex = 1;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(6, 147);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(162, 32);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Del_btn
            // 
            this.Del_btn.Location = new System.Drawing.Point(12, 89);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(162, 46);
            this.Del_btn.TabIndex = 3;
            this.Del_btn.Text = "Delete";
            this.Del_btn.UseVisualStyleBackColor = true;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCatId);
            this.groupBox1.Controls.Add(this.tbCatName);
            this.groupBox1.Controls.Add(this.Update_btn);
            this.groupBox1.Controls.Add(this.Add_btn);
            this.groupBox1.Location = new System.Drawing.Point(23, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 238);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add or Update ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "CategoryName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "CategoryId";
            // 
            // tbCatId
            // 
            this.tbCatId.Location = new System.Drawing.Point(6, 68);
            this.tbCatId.Name = "tbCatId";
            this.tbCatId.Size = new System.Drawing.Size(212, 22);
            this.tbCatId.TabIndex = 4;
            // 
            // tbCatName
            // 
            this.tbCatName.Location = new System.Drawing.Point(6, 119);
            this.tbCatName.Name = "tbCatName";
            this.tbCatName.Size = new System.Drawing.Size(212, 22);
            this.tbCatName.TabIndex = 3;
            // 
            // Show_btn
            // 
            this.Show_btn.Location = new System.Drawing.Point(12, 12);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(162, 46);
            this.Show_btn.TabIndex = 5;
            this.Show_btn.Text = "Show";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // dGW1
            // 
            this.dGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW1.Location = new System.Drawing.Point(297, 12);
            this.dGW1.Name = "dGW1";
            this.dGW1.RowTemplate.Height = 24;
            this.dGW1.Size = new System.Drawing.Size(505, 398);
            this.dGW1.TabIndex = 6;
            this.dGW1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGW1_CellContentClick);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 422);
            this.Controls.Add(this.dGW1);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Del_btn);
            this.Name = "FormCategory";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Show_btn;
        public System.Windows.Forms.TextBox tbCatId;
        public System.Windows.Forms.TextBox tbCatName;
        public System.Windows.Forms.DataGridView dGW1;
    }
}

