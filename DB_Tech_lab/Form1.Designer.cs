namespace DB_Tech_lab
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблиціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.станціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категоріїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mQTTServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вимірюванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оптималніЗначенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.улюбленнаСтанціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mQTTMessegeUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.програмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиЗАкаунтуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиЗПрограмиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.репортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПідключенихСтанційToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатиВимірюваньСтанціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerBIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимальніЗначеняШкідливихЧастинокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кількостіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оптимальніЗначеняДляSO2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оптимальніЗначеняДляCOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціToolStripMenuItem,
            this.програмаToolStripMenuItem,
            this.репортToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблиціToolStripMenuItem
            // 
            this.таблиціToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.станціїToolStripMenuItem,
            this.категоріїToolStripMenuItem,
            this.mQTTServerToolStripMenuItem,
            this.вимірюванняToolStripMenuItem,
            this.оптималніЗначенняToolStripMenuItem,
            this.улюбленнаСтанціяToolStripMenuItem,
            this.mQTTMessegeUnitToolStripMenuItem});
            this.таблиціToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.таблиціToolStripMenuItem.Name = "таблиціToolStripMenuItem";
            this.таблиціToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.таблиціToolStripMenuItem.Text = "Таблиці";
            // 
            // станціїToolStripMenuItem
            // 
            this.станціїToolStripMenuItem.Name = "станціїToolStripMenuItem";
            this.станціїToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.станціїToolStripMenuItem.Text = "Станції";
            this.станціїToolStripMenuItem.Click += new System.EventHandler(this.станціїToolStripMenuItem_Click);
            // 
            // категоріїToolStripMenuItem
            // 
            this.категоріїToolStripMenuItem.Name = "категоріїToolStripMenuItem";
            this.категоріїToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.категоріїToolStripMenuItem.Text = "Категорії";
            this.категоріїToolStripMenuItem.Click += new System.EventHandler(this.категоріїToolStripMenuItem_Click);
            // 
            // mQTTServerToolStripMenuItem
            // 
            this.mQTTServerToolStripMenuItem.Name = "mQTTServerToolStripMenuItem";
            this.mQTTServerToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.mQTTServerToolStripMenuItem.Text = "MQTT Server";
            this.mQTTServerToolStripMenuItem.Click += new System.EventHandler(this.mQTTServerToolStripMenuItem_Click);
            // 
            // вимірюванняToolStripMenuItem
            // 
            this.вимірюванняToolStripMenuItem.Name = "вимірюванняToolStripMenuItem";
            this.вимірюванняToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.вимірюванняToolStripMenuItem.Text = "Вимірювання";
            this.вимірюванняToolStripMenuItem.Click += new System.EventHandler(this.вимірюванняToolStripMenuItem_Click);
            // 
            // оптималніЗначенняToolStripMenuItem
            // 
            this.оптималніЗначенняToolStripMenuItem.Name = "оптималніЗначенняToolStripMenuItem";
            this.оптималніЗначенняToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.оптималніЗначенняToolStripMenuItem.Text = "Оптималні значення";
            this.оптималніЗначенняToolStripMenuItem.Click += new System.EventHandler(this.оптималніЗначенняToolStripMenuItem_Click);
            // 
            // улюбленнаСтанціяToolStripMenuItem
            // 
            this.улюбленнаСтанціяToolStripMenuItem.Name = "улюбленнаСтанціяToolStripMenuItem";
            this.улюбленнаСтанціяToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.улюбленнаСтанціяToolStripMenuItem.Text = "Улюбленна станція";
            this.улюбленнаСтанціяToolStripMenuItem.Click += new System.EventHandler(this.улюбленнаСтанціяToolStripMenuItem_Click);
            // 
            // mQTTMessegeUnitToolStripMenuItem
            // 
            this.mQTTMessegeUnitToolStripMenuItem.Name = "mQTTMessegeUnitToolStripMenuItem";
            this.mQTTMessegeUnitToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.mQTTMessegeUnitToolStripMenuItem.Text = "MQTT Messege Unit";
            this.mQTTMessegeUnitToolStripMenuItem.Click += new System.EventHandler(this.mQTTMessegeUnitToolStripMenuItem_Click);
            // 
            // програмаToolStripMenuItem
            // 
            this.програмаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вийтиЗАкаунтуToolStripMenuItem,
            this.вийтиЗПрограмиToolStripMenuItem});
            this.програмаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.програмаToolStripMenuItem.Name = "програмаToolStripMenuItem";
            this.програмаToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.програмаToolStripMenuItem.Text = "Програма";
            // 
            // вийтиЗАкаунтуToolStripMenuItem
            // 
            this.вийтиЗАкаунтуToolStripMenuItem.Name = "вийтиЗАкаунтуToolStripMenuItem";
            this.вийтиЗАкаунтуToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.вийтиЗАкаунтуToolStripMenuItem.Text = "Вийти з акаунту";
            this.вийтиЗАкаунтуToolStripMenuItem.Click += new System.EventHandler(this.вийтиЗАкаунтуToolStripMenuItem_Click);
            // 
            // вийтиЗПрограмиToolStripMenuItem
            // 
            this.вийтиЗПрограмиToolStripMenuItem.Name = "вийтиЗПрограмиToolStripMenuItem";
            this.вийтиЗПрограмиToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.вийтиЗПрограмиToolStripMenuItem.Text = "Вийти з програми";
            this.вийтиЗПрограмиToolStripMenuItem.Click += new System.EventHandler(this.вийтиЗПрограмиToolStripMenuItem_Click);
            // 
            // репортToolStripMenuItem
            // 
            this.репортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПідключенихСтанційToolStripMenuItem,
            this.результатиВимірюваньСтанціїToolStripMenuItem,
            this.powerBIToolStripMenuItem,
            this.максимальніЗначеняШкідливихЧастинокToolStripMenuItem,
            this.кількостіToolStripMenuItem,
            this.оптимальніЗначеняДляSO2ToolStripMenuItem,
            this.оптимальніЗначеняДляCOToolStripMenuItem});
            this.репортToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.репортToolStripMenuItem.Name = "репортToolStripMenuItem";
            this.репортToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.репортToolStripMenuItem.Text = "Звіти";
            this.репортToolStripMenuItem.Click += new System.EventHandler(this.репортToolStripMenuItem_Click);
            // 
            // списокПідключенихСтанційToolStripMenuItem
            // 
            this.списокПідключенихСтанційToolStripMenuItem.Name = "списокПідключенихСтанційToolStripMenuItem";
            this.списокПідключенихСтанційToolStripMenuItem.Size = new System.Drawing.Size(409, 26);
            this.списокПідключенихСтанційToolStripMenuItem.Text = "Список підключених станцій";
            this.списокПідключенихСтанційToolStripMenuItem.Click += new System.EventHandler(this.списокПідключенихСтанційToolStripMenuItem_Click);
            // 
            // результатиВимірюваньСтанціїToolStripMenuItem
            // 
            this.результатиВимірюваньСтанціїToolStripMenuItem.Name = "результатиВимірюваньСтанціїToolStripMenuItem";
            this.результатиВимірюваньСтанціїToolStripMenuItem.Size = new System.Drawing.Size(409, 26);
            this.результатиВимірюваньСтанціїToolStripMenuItem.Text = "Результати вимірювань станції";
            this.результатиВимірюваньСтанціїToolStripMenuItem.Click += new System.EventHandler(this.результатиВимірюваньСтанціїToolStripMenuItem_Click);
            // 
            // powerBIToolStripMenuItem
            // 
            this.powerBIToolStripMenuItem.Name = "powerBIToolStripMenuItem";
            this.powerBIToolStripMenuItem.Size = new System.Drawing.Size(409, 26);
            this.powerBIToolStripMenuItem.Text = "PowerBI";
            this.powerBIToolStripMenuItem.Click += new System.EventHandler(this.powerBIToolStripMenuItem_Click);
            // 
            // максимальніЗначеняШкідливихЧастинокToolStripMenuItem
            // 
            this.максимальніЗначеняШкідливихЧастинокToolStripMenuItem.Name = "максимальніЗначеняШкідливихЧастинокToolStripMenuItem";
            this.максимальніЗначеняШкідливихЧастинокToolStripMenuItem.Size = new System.Drawing.Size(409, 26);
            this.максимальніЗначеняШкідливихЧастинокToolStripMenuItem.Text = "Максимальні значеня шкідливих частинок";
            this.максимальніЗначеняШкідливихЧастинокToolStripMenuItem.Click += new System.EventHandler(this.максимальніЗначеняШкідливихЧастинокToolStripMenuItem_Click);
            // 
            // кількостіToolStripMenuItem
            // 
            this.кількостіToolStripMenuItem.Name = "кількостіToolStripMenuItem";
            this.кількостіToolStripMenuItem.Size = new System.Drawing.Size(409, 26);
            this.кількостіToolStripMenuItem.Text = "Кількость зафіксованих середньодобих PM2.5";
            this.кількостіToolStripMenuItem.Click += new System.EventHandler(this.кількостіToolStripMenuItem_Click);
            // 
            // оптимальніЗначеняДляSO2ToolStripMenuItem
            // 
            this.оптимальніЗначеняДляSO2ToolStripMenuItem.Name = "оптимальніЗначеняДляSO2ToolStripMenuItem";
            this.оптимальніЗначеняДляSO2ToolStripMenuItem.Size = new System.Drawing.Size(409, 26);
            this.оптимальніЗначеняДляSO2ToolStripMenuItem.Text = "Оптимальні значеня для SO2";
            this.оптимальніЗначеняДляSO2ToolStripMenuItem.Click += new System.EventHandler(this.оптимальніЗначеняДляSO2ToolStripMenuItem_Click);
            // 
            // оптимальніЗначеняДляCOToolStripMenuItem
            // 
            this.оптимальніЗначеняДляCOToolStripMenuItem.Name = "оптимальніЗначеняДляCOToolStripMenuItem";
            this.оптимальніЗначеняДляCOToolStripMenuItem.Size = new System.Drawing.Size(409, 26);
            this.оптимальніЗначеняДляCOToolStripMenuItem.Text = "Оптимальні значеня для CO";
            this.оптимальніЗначеняДляCOToolStripMenuItem.Click += new System.EventHandler(this.оптимальніЗначеняДляCOToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Досідження";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблиціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem станціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категоріїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mQTTServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вимірюванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оптималніЗначенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem улюбленнаСтанціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mQTTMessegeUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem програмаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem репортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПідключенихСтанційToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиЗАкаунтуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиЗПрограмиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатиВимірюваньСтанціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerBIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимальніЗначеняШкідливихЧастинокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кількостіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оптимальніЗначеняДляSO2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оптимальніЗначеняДляCOToolStripMenuItem;
    }
}

