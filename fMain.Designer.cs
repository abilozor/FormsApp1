namespace lab_work_3
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbCarsnfo = new System.Windows.Forms.TextBox();
            this.btnAddTv = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tbTvsInfo
            // 
            this.tbCarsnfo.Location = new System.Drawing.Point(12, 12);
            this.tbCarsnfo.Multiline = true;
            this.tbCarsnfo.Name = "tbTvsInfo";
            this.tbCarsnfo.ReadOnly = true;
            this.tbCarsnfo.Size = new System.Drawing.Size(644, 393);
            this.tbCarsnfo.TabIndex = 0;
            // 
            // btnAddTv
            // 
            this.btnAddTv.Location = new System.Drawing.Point(662, 12);
            this.btnAddTv.Name = "btnAddTv";
            this.btnAddTv.Size = new System.Drawing.Size(101, 45);
            this.btnAddTv.TabIndex = 1;
            this.btnAddTv.Text = "Додати автомобіль";
            this.btnAddTv.UseVisualStyleBackColor = true;
            this.btnAddTv.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(662, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddTv);
            this.Controls.Add(this.tbCarsnfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox tbCarsnfo;
        private System.Windows.Forms.Button btnAddTv;
        private System.Windows.Forms.Button btnClose;
    }
}

