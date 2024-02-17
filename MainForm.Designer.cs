
namespace CS2Stat
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
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_MM = new FontAwesome.Sharp.IconButton();
            this.panel_activeMM = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Premier = new FontAwesome.Sharp.IconButton();
            this.panel_activePremier = new System.Windows.Forms.Panel();
            this.panel_leftDock = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_clearLog = new Guna.UI2.WinForms.Guna2Button();
            this.button_newStat = new Guna.UI2.WinForms.Guna2Button();
            this.label_AVG = new System.Windows.Forms.Label();
            this.label_KD = new System.Windows.Forms.Label();
            this.textBox_AVG = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_KD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_allAssists = new System.Windows.Forms.Label();
            this.label_allDeads = new System.Windows.Forms.Label();
            this.label_allKills = new System.Windows.Forms.Label();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_leftDock.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(150, 80);
            this.panel_logo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "CS2Stat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_MM);
            this.panel1.Controls.Add(this.panel_activeMM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 40);
            this.panel1.TabIndex = 1;
            // 
            // button_MM
            // 
            this.button_MM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_MM.FlatAppearance.BorderSize = 0;
            this.button_MM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_MM.IconChar = FontAwesome.Sharp.IconChar.None;
            this.button_MM.IconColor = System.Drawing.Color.Black;
            this.button_MM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_MM.Location = new System.Drawing.Point(10, 0);
            this.button_MM.Name = "button_MM";
            this.button_MM.Size = new System.Drawing.Size(140, 40);
            this.button_MM.TabIndex = 3;
            this.button_MM.TabStop = false;
            this.button_MM.Text = "Матчмейкинг";
            this.button_MM.UseVisualStyleBackColor = true;
            this.button_MM.Click += new System.EventHandler(this.button_MM_Click);
            this.button_MM.MouseEnter += new System.EventHandler(this.button_MM_MouseEnter);
            this.button_MM.MouseLeave += new System.EventHandler(this.button_MM_MouseLeave);
            // 
            // panel_activeMM
            // 
            this.panel_activeMM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.panel_activeMM.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_activeMM.Location = new System.Drawing.Point(0, 0);
            this.panel_activeMM.Name = "panel_activeMM";
            this.panel_activeMM.Size = new System.Drawing.Size(10, 40);
            this.panel_activeMM.TabIndex = 2;
            this.panel_activeMM.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Premier);
            this.panel2.Controls.Add(this.panel_activePremier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 40);
            this.panel2.TabIndex = 2;
            // 
            // button_Premier
            // 
            this.button_Premier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Premier.FlatAppearance.BorderSize = 0;
            this.button_Premier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Premier.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Premier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_Premier.IconChar = FontAwesome.Sharp.IconChar.None;
            this.button_Premier.IconColor = System.Drawing.Color.Black;
            this.button_Premier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Premier.Location = new System.Drawing.Point(10, 0);
            this.button_Premier.Name = "button_Premier";
            this.button_Premier.Size = new System.Drawing.Size(140, 40);
            this.button_Premier.TabIndex = 3;
            this.button_Premier.TabStop = false;
            this.button_Premier.Text = "Премьер";
            this.button_Premier.UseVisualStyleBackColor = true;
            this.button_Premier.Click += new System.EventHandler(this.button_Premier_Click);
            this.button_Premier.MouseEnter += new System.EventHandler(this.button_Premier_MouseEnter);
            this.button_Premier.MouseLeave += new System.EventHandler(this.button_Premier_MouseLeave);
            // 
            // panel_activePremier
            // 
            this.panel_activePremier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.panel_activePremier.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_activePremier.Location = new System.Drawing.Point(0, 0);
            this.panel_activePremier.Name = "panel_activePremier";
            this.panel_activePremier.Size = new System.Drawing.Size(10, 40);
            this.panel_activePremier.TabIndex = 2;
            this.panel_activePremier.Visible = false;
            // 
            // panel_leftDock
            // 
            this.panel_leftDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panel_leftDock.Controls.Add(this.panel2);
            this.panel_leftDock.Controls.Add(this.panel1);
            this.panel_leftDock.Controls.Add(this.panel_logo);
            this.panel_leftDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_leftDock.Location = new System.Drawing.Point(0, 0);
            this.panel_leftDock.Name = "panel_leftDock";
            this.panel_leftDock.Size = new System.Drawing.Size(150, 401);
            this.panel_leftDock.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel_main.Controls.Add(this.button_clearLog);
            this.panel_main.Controls.Add(this.button_newStat);
            this.panel_main.Controls.Add(this.label_AVG);
            this.panel_main.Controls.Add(this.label_KD);
            this.panel_main.Controls.Add(this.textBox_AVG);
            this.panel_main.Controls.Add(this.textBox_KD);
            this.panel_main.Controls.Add(this.label_allAssists);
            this.panel_main.Controls.Add(this.label_allDeads);
            this.panel_main.Controls.Add(this.label_allKills);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(150, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(484, 401);
            this.panel_main.TabIndex = 2;
            // 
            // button_clearLog
            // 
            this.button_clearLog.Animated = true;
            this.button_clearLog.BackColor = System.Drawing.Color.Transparent;
            this.button_clearLog.BorderColor = System.Drawing.Color.Empty;
            this.button_clearLog.BorderRadius = 5;
            this.button_clearLog.BorderThickness = 1;
            this.button_clearLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_clearLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_clearLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_clearLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_clearLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.button_clearLog.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button_clearLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_clearLog.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.button_clearLog.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.button_clearLog.Location = new System.Drawing.Point(261, 293);
            this.button_clearLog.Name = "button_clearLog";
            this.button_clearLog.Size = new System.Drawing.Size(180, 45);
            this.button_clearLog.TabIndex = 9;
            this.button_clearLog.Text = "Очистить историю";
            this.button_clearLog.Click += new System.EventHandler(this.button_clearLog_Click);
            // 
            // button_newStat
            // 
            this.button_newStat.Animated = true;
            this.button_newStat.BackColor = System.Drawing.Color.Transparent;
            this.button_newStat.BorderColor = System.Drawing.Color.Empty;
            this.button_newStat.BorderRadius = 5;
            this.button_newStat.BorderThickness = 1;
            this.button_newStat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_newStat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_newStat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_newStat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_newStat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.button_newStat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button_newStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_newStat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.button_newStat.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.button_newStat.Location = new System.Drawing.Point(42, 293);
            this.button_newStat.Name = "button_newStat";
            this.button_newStat.Size = new System.Drawing.Size(180, 45);
            this.button_newStat.TabIndex = 8;
            this.button_newStat.Text = "Новые данные";
            this.button_newStat.Click += new System.EventHandler(this.button_newStat_Click);
            // 
            // label_AVG
            // 
            this.label_AVG.AutoSize = true;
            this.label_AVG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AVG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_AVG.Location = new System.Drawing.Point(92, 104);
            this.label_AVG.Name = "label_AVG";
            this.label_AVG.Size = new System.Drawing.Size(36, 17);
            this.label_AVG.TabIndex = 7;
            this.label_AVG.Text = "АВГ: ";
            // 
            // label_KD
            // 
            this.label_KD.AutoSize = true;
            this.label_KD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_KD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_KD.Location = new System.Drawing.Point(96, 66);
            this.label_KD.Name = "label_KD";
            this.label_KD.Size = new System.Drawing.Size(32, 17);
            this.label_KD.TabIndex = 6;
            this.label_KD.Text = "КД: ";
            // 
            // textBox_AVG
            // 
            this.textBox_AVG.Animated = true;
            this.textBox_AVG.BorderRadius = 5;
            this.textBox_AVG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_AVG.DefaultText = "";
            this.textBox_AVG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_AVG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_AVG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_AVG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_AVG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.textBox_AVG.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox_AVG.ForeColor = System.Drawing.Color.Black;
            this.textBox_AVG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.textBox_AVG.Location = new System.Drawing.Point(131, 100);
            this.textBox_AVG.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_AVG.Name = "textBox_AVG";
            this.textBox_AVG.PasswordChar = '\0';
            this.textBox_AVG.PlaceholderText = "";
            this.textBox_AVG.ReadOnly = true;
            this.textBox_AVG.SelectedText = "";
            this.textBox_AVG.Size = new System.Drawing.Size(230, 25);
            this.textBox_AVG.TabIndex = 5;
            this.textBox_AVG.TabStop = false;
            this.textBox_AVG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_KD
            // 
            this.textBox_KD.Animated = true;
            this.textBox_KD.BorderRadius = 5;
            this.textBox_KD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_KD.DefaultText = "";
            this.textBox_KD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_KD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_KD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_KD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_KD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.textBox_KD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox_KD.ForeColor = System.Drawing.Color.Black;
            this.textBox_KD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.textBox_KD.Location = new System.Drawing.Point(131, 62);
            this.textBox_KD.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_KD.Name = "textBox_KD";
            this.textBox_KD.PasswordChar = '\0';
            this.textBox_KD.PlaceholderText = "";
            this.textBox_KD.ReadOnly = true;
            this.textBox_KD.SelectedText = "";
            this.textBox_KD.Size = new System.Drawing.Size(230, 25);
            this.textBox_KD.TabIndex = 4;
            this.textBox_KD.TabStop = false;
            this.textBox_KD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_allAssists
            // 
            this.label_allAssists.AutoSize = true;
            this.label_allAssists.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_allAssists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_allAssists.Location = new System.Drawing.Point(128, 225);
            this.label_allAssists.Name = "label_allAssists";
            this.label_allAssists.Size = new System.Drawing.Size(182, 17);
            this.label_allAssists.TabIndex = 3;
            this.label_allAssists.Text = "Общее количество ассистов:";
            // 
            // label_allDeads
            // 
            this.label_allDeads.AutoSize = true;
            this.label_allDeads.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_allDeads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_allDeads.Location = new System.Drawing.Point(128, 200);
            this.label_allDeads.Name = "label_allDeads";
            this.label_allDeads.Size = new System.Drawing.Size(179, 17);
            this.label_allDeads.TabIndex = 2;
            this.label_allDeads.Text = "Общее количество смертей:";
            // 
            // label_allKills
            // 
            this.label_allKills.AutoSize = true;
            this.label_allKills.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_allKills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_allKills.Location = new System.Drawing.Point(128, 174);
            this.label_allKills.Name = "label_allKills";
            this.label_allKills.Size = new System.Drawing.Size(176, 17);
            this.label_allKills.TabIndex = 1;
            this.label_allKills.Text = "Общее количество убийств:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 401);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_leftDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS2Stat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_leftDock.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_activeMM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_activePremier;
        private System.Windows.Forms.Panel panel_leftDock;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_allAssists;
        private System.Windows.Forms.Label label_allDeads;
        private System.Windows.Forms.Label label_allKills;
        private Guna.UI2.WinForms.Guna2TextBox textBox_KD;
        private Guna.UI2.WinForms.Guna2TextBox textBox_AVG;
        private System.Windows.Forms.Label label_AVG;
        private System.Windows.Forms.Label label_KD;
        public Guna.UI2.WinForms.Guna2Button button_newStat;
        public Guna.UI2.WinForms.Guna2Button button_clearLog;
        public FontAwesome.Sharp.IconButton button_MM;
        public FontAwesome.Sharp.IconButton button_Premier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

