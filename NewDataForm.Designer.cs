
namespace CS2Stat
{
    partial class NewDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDataForm));
            this.panel_main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_assists = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_saveStat = new Guna.UI2.WinForms.Guna2Button();
            this.label_AVG = new System.Windows.Forms.Label();
            this.label_KD = new System.Windows.Forms.Label();
            this.textBox_deads = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_kills = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.textBox_assists);
            this.panel_main.Controls.Add(this.button_saveStat);
            this.panel_main.Controls.Add(this.label_AVG);
            this.panel_main.Controls.Add(this.label_KD);
            this.panel_main.Controls.Add(this.textBox_deads);
            this.panel_main.Controls.Add(this.textBox_kills);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(384, 261);
            this.panel_main.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(43, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ассисты: ";
            // 
            // textBox_assists
            // 
            this.textBox_assists.Animated = true;
            this.textBox_assists.BorderRadius = 5;
            this.textBox_assists.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_assists.DefaultText = "";
            this.textBox_assists.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_assists.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_assists.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_assists.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_assists.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.textBox_assists.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox_assists.ForeColor = System.Drawing.Color.Black;
            this.textBox_assists.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.textBox_assists.Location = new System.Drawing.Point(108, 120);
            this.textBox_assists.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_assists.Name = "textBox_assists";
            this.textBox_assists.PasswordChar = '\0';
            this.textBox_assists.PlaceholderText = "";
            this.textBox_assists.SelectedText = "";
            this.textBox_assists.Size = new System.Drawing.Size(230, 25);
            this.textBox_assists.TabIndex = 3;
            this.textBox_assists.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_assists.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_assists_KeyPress);
            // 
            // button_saveStat
            // 
            this.button_saveStat.Animated = true;
            this.button_saveStat.BackColor = System.Drawing.Color.Transparent;
            this.button_saveStat.BorderColor = System.Drawing.Color.Empty;
            this.button_saveStat.BorderRadius = 5;
            this.button_saveStat.BorderThickness = 1;
            this.button_saveStat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_saveStat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_saveStat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_saveStat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_saveStat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.button_saveStat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button_saveStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_saveStat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.button_saveStat.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.button_saveStat.Location = new System.Drawing.Point(46, 170);
            this.button_saveStat.Name = "button_saveStat";
            this.button_saveStat.Size = new System.Drawing.Size(292, 45);
            this.button_saveStat.TabIndex = 4;
            this.button_saveStat.Text = "Внести данные";
            this.button_saveStat.Click += new System.EventHandler(this.button_saveStat_Click);
            // 
            // label_AVG
            // 
            this.label_AVG.AutoSize = true;
            this.label_AVG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AVG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_AVG.Location = new System.Drawing.Point(46, 86);
            this.label_AVG.Name = "label_AVG";
            this.label_AVG.Size = new System.Drawing.Size(59, 17);
            this.label_AVG.TabIndex = 7;
            this.label_AVG.Text = "Смерти: ";
            // 
            // label_KD
            // 
            this.label_KD.AutoSize = true;
            this.label_KD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_KD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_KD.Location = new System.Drawing.Point(52, 48);
            this.label_KD.Name = "label_KD";
            this.label_KD.Size = new System.Drawing.Size(53, 17);
            this.label_KD.TabIndex = 6;
            this.label_KD.Text = "Киллы: ";
            // 
            // textBox_deads
            // 
            this.textBox_deads.Animated = true;
            this.textBox_deads.BorderRadius = 5;
            this.textBox_deads.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_deads.DefaultText = "";
            this.textBox_deads.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_deads.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_deads.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_deads.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_deads.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.textBox_deads.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox_deads.ForeColor = System.Drawing.Color.Black;
            this.textBox_deads.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.textBox_deads.Location = new System.Drawing.Point(108, 82);
            this.textBox_deads.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_deads.Name = "textBox_deads";
            this.textBox_deads.PasswordChar = '\0';
            this.textBox_deads.PlaceholderText = "";
            this.textBox_deads.SelectedText = "";
            this.textBox_deads.Size = new System.Drawing.Size(230, 25);
            this.textBox_deads.TabIndex = 2;
            this.textBox_deads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_deads.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_deads_KeyPress);
            // 
            // textBox_kills
            // 
            this.textBox_kills.Animated = true;
            this.textBox_kills.BorderRadius = 5;
            this.textBox_kills.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_kills.DefaultText = "";
            this.textBox_kills.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_kills.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_kills.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_kills.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_kills.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.textBox_kills.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox_kills.ForeColor = System.Drawing.Color.Black;
            this.textBox_kills.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.textBox_kills.Location = new System.Drawing.Point(108, 44);
            this.textBox_kills.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_kills.Name = "textBox_kills";
            this.textBox_kills.PasswordChar = '\0';
            this.textBox_kills.PlaceholderText = "";
            this.textBox_kills.SelectedText = "";
            this.textBox_kills.Size = new System.Drawing.Size(230, 25);
            this.textBox_kills.TabIndex = 1;
            this.textBox_kills.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_kills.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_kills_KeyPress);
            // 
            // NewDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новые данные";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewDataForm_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        public Guna.UI2.WinForms.Guna2Button button_saveStat;
        private System.Windows.Forms.Label label_AVG;
        private System.Windows.Forms.Label label_KD;
        private Guna.UI2.WinForms.Guna2TextBox textBox_deads;
        private Guna.UI2.WinForms.Guna2TextBox textBox_kills;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_assists;
    }
}