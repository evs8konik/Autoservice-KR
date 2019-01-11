namespace avservic
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.входВСистемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.входВСистемуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персонаАвтосервисаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияКлиентовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(13, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // входВСистемуToolStripMenuItem
            // 
            this.входВСистемуToolStripMenuItem.Name = "входВСистемуToolStripMenuItem";
            this.входВСистемуToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.входВСистемуToolStripMenuItem.Text = "Вход в систему";
            // 
            // регистрацияКлиентовToolStripMenuItem
            // 
            this.регистрацияКлиентовToolStripMenuItem.Name = "регистрацияКлиентовToolStripMenuItem";
            this.регистрацияКлиентовToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.регистрацияКлиентовToolStripMenuItem.Text = "Регистрация клиентов";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входВСистемуToolStripMenuItem1,
            this.регистрацияКлиентовToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // входВСистемуToolStripMenuItem1
            // 
            this.входВСистемуToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользовательToolStripMenuItem,
            this.персонаАвтосервисаToolStripMenuItem});
            this.входВСистемуToolStripMenuItem1.Name = "входВСистемуToolStripMenuItem1";
            this.входВСистемуToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.входВСистемуToolStripMenuItem1.Text = "Вход в систему";
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            this.пользовательToolStripMenuItem.Click += new System.EventHandler(this.пользовательToolStripMenuItem_Click);
            // 
            // персонаАвтосервисаToolStripMenuItem
            // 
            this.персонаАвтосервисаToolStripMenuItem.Name = "персонаАвтосервисаToolStripMenuItem";
            this.персонаАвтосервисаToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.персонаАвтосервисаToolStripMenuItem.Text = "Персона автосервиса";
            // 
            // регистрацияКлиентовToolStripMenuItem1
            // 
            this.регистрацияКлиентовToolStripMenuItem1.Name = "регистрацияКлиентовToolStripMenuItem1";
            this.регистрацияКлиентовToolStripMenuItem1.Size = new System.Drawing.Size(142, 20);
            this.регистрацияКлиентовToolStripMenuItem1.Text = "Регистрация клиентов";
            this.регистрацияКлиентовToolStripMenuItem1.Click += new System.EventHandler(this.регистрацияКлиентовToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::avservic.Properties.Resources.SbkxPrfh_0Q;
            this.ClientSize = new System.Drawing.Size(606, 401);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Автосервис \"Corvet\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem входВСистемуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияКлиентовToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem входВСистемуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem персонаАвтосервисаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияКлиентовToolStripMenuItem1;
    }
}

