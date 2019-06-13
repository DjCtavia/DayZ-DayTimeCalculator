namespace TimeManager_DayZ
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nightHours = new System.Windows.Forms.NumericUpDown();
            this.nightMinutes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IsNightTime = new System.Windows.Forms.CheckBox();
            this.nightSeconds = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dayHours = new System.Windows.Forms.NumericUpDown();
            this.dayMinutes = new System.Windows.Forms.NumericUpDown();
            this.daySeconds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.lMinHoursNight = new System.Windows.Forms.Label();
            this.lMinMinutesNight = new System.Windows.Forms.Label();
            this.lMinSecondsNight = new System.Windows.Forms.Label();
            this.lMaxSecondsNight = new System.Windows.Forms.Label();
            this.lMaxMinutesNight = new System.Windows.Forms.Label();
            this.lMaxHoursNight = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nightHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daySeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // nightHours
            // 
            this.nightHours.Enabled = false;
            this.nightHours.Location = new System.Drawing.Point(12, 87);
            this.nightHours.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nightHours.Name = "nightHours";
            this.nightHours.Size = new System.Drawing.Size(48, 20);
            this.nightHours.TabIndex = 0;
            this.nightHours.ValueChanged += new System.EventHandler(this.NightHours_ValueChanged);
            // 
            // nightMinutes
            // 
            this.nightMinutes.Enabled = false;
            this.nightMinutes.Location = new System.Drawing.Point(107, 87);
            this.nightMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nightMinutes.Name = "nightMinutes";
            this.nightMinutes.Size = new System.Drawing.Size(52, 20);
            this.nightMinutes.TabIndex = 1;
            this.nightMinutes.ValueChanged += new System.EventHandler(this.NightMinutes_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Minutes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Night duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Day duration";
            // 
            // IsNightTime
            // 
            this.IsNightTime.AutoSize = true;
            this.IsNightTime.Location = new System.Drawing.Point(94, 228);
            this.IsNightTime.Name = "IsNightTime";
            this.IsNightTime.Size = new System.Drawing.Size(134, 17);
            this.IsNightTime.TabIndex = 7;
            this.IsNightTime.Text = "Consider night duration";
            this.IsNightTime.UseVisualStyleBackColor = true;
            this.IsNightTime.CheckedChanged += new System.EventHandler(this.IsNightTime_CheckedChanged);
            this.IsNightTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckBox1_MouseClick);
            // 
            // nightSeconds
            // 
            this.nightSeconds.Enabled = false;
            this.nightSeconds.Location = new System.Drawing.Point(215, 87);
            this.nightSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nightSeconds.Name = "nightSeconds";
            this.nightSeconds.Size = new System.Drawing.Size(52, 20);
            this.nightSeconds.TabIndex = 1;
            this.nightSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nightSeconds.ValueChanged += new System.EventHandler(this.NightSeconds_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Seconds";
            // 
            // dayHours
            // 
            this.dayHours.Location = new System.Drawing.Point(12, 34);
            this.dayHours.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dayHours.Name = "dayHours";
            this.dayHours.Size = new System.Drawing.Size(48, 20);
            this.dayHours.TabIndex = 0;
            this.dayHours.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.dayHours.ValueChanged += new System.EventHandler(this.DayHours_ValueChanged);
            // 
            // dayMinutes
            // 
            this.dayMinutes.Location = new System.Drawing.Point(107, 34);
            this.dayMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.dayMinutes.Name = "dayMinutes";
            this.dayMinutes.Size = new System.Drawing.Size(52, 20);
            this.dayMinutes.TabIndex = 1;
            this.dayMinutes.ValueChanged += new System.EventHandler(this.DayMinutes_ValueChanged);
            // 
            // daySeconds
            // 
            this.daySeconds.Location = new System.Drawing.Point(215, 34);
            this.daySeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.daySeconds.Name = "daySeconds";
            this.daySeconds.Size = new System.Drawing.Size(52, 20);
            this.daySeconds.TabIndex = 1;
            this.daySeconds.ValueChanged += new System.EventHandler(this.DaySeconds_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Seconds";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Min night time:";
            // 
            // lMinHoursNight
            // 
            this.lMinHoursNight.AutoSize = true;
            this.lMinHoursNight.Location = new System.Drawing.Point(12, 149);
            this.lMinHoursNight.Name = "lMinHoursNight";
            this.lMinHoursNight.Size = new System.Drawing.Size(40, 13);
            this.lMinHoursNight.TabIndex = 9;
            this.lMinHoursNight.Text = "NotSet";
            // 
            // lMinMinutesNight
            // 
            this.lMinMinutesNight.AutoSize = true;
            this.lMinMinutesNight.Location = new System.Drawing.Point(107, 149);
            this.lMinMinutesNight.Name = "lMinMinutesNight";
            this.lMinMinutesNight.Size = new System.Drawing.Size(40, 13);
            this.lMinMinutesNight.TabIndex = 10;
            this.lMinMinutesNight.Text = "NotSet";
            // 
            // lMinSecondsNight
            // 
            this.lMinSecondsNight.AutoSize = true;
            this.lMinSecondsNight.Location = new System.Drawing.Point(215, 149);
            this.lMinSecondsNight.Name = "lMinSecondsNight";
            this.lMinSecondsNight.Size = new System.Drawing.Size(40, 13);
            this.lMinSecondsNight.TabIndex = 11;
            this.lMinSecondsNight.Text = "NotSet";
            // 
            // lMaxSecondsNight
            // 
            this.lMaxSecondsNight.AutoSize = true;
            this.lMaxSecondsNight.Location = new System.Drawing.Point(212, 203);
            this.lMaxSecondsNight.Name = "lMaxSecondsNight";
            this.lMaxSecondsNight.Size = new System.Drawing.Size(40, 13);
            this.lMaxSecondsNight.TabIndex = 15;
            this.lMaxSecondsNight.Text = "NotSet";
            // 
            // lMaxMinutesNight
            // 
            this.lMaxMinutesNight.AutoSize = true;
            this.lMaxMinutesNight.Location = new System.Drawing.Point(104, 203);
            this.lMaxMinutesNight.Name = "lMaxMinutesNight";
            this.lMaxMinutesNight.Size = new System.Drawing.Size(40, 13);
            this.lMaxMinutesNight.TabIndex = 14;
            this.lMaxMinutesNight.Text = "NotSet";
            // 
            // lMaxHoursNight
            // 
            this.lMaxHoursNight.AutoSize = true;
            this.lMaxHoursNight.Location = new System.Drawing.Point(9, 203);
            this.lMaxHoursNight.Name = "lMaxHoursNight";
            this.lMaxHoursNight.Size = new System.Drawing.Size(40, 13);
            this.lMaxHoursNight.TabIndex = 13;
            this.lMaxHoursNight.Text = "NotSet";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(9, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Max night time:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 267);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(306, 87);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 395);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lMaxSecondsNight);
            this.Controls.Add(this.lMaxMinutesNight);
            this.Controls.Add(this.lMaxHoursNight);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lMinSecondsNight);
            this.Controls.Add(this.lMinMinutesNight);
            this.Controls.Add(this.lMinHoursNight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IsNightTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.daySeconds);
            this.Controls.Add(this.nightSeconds);
            this.Controls.Add(this.dayMinutes);
            this.Controls.Add(this.nightMinutes);
            this.Controls.Add(this.dayHours);
            this.Controls.Add(this.nightHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calcul day - DayZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nightHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daySeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nightHours;
        private System.Windows.Forms.NumericUpDown nightMinutes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox IsNightTime;
        private System.Windows.Forms.NumericUpDown nightSeconds;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown dayHours;
        private System.Windows.Forms.NumericUpDown dayMinutes;
        private System.Windows.Forms.NumericUpDown daySeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lMinHoursNight;
        private System.Windows.Forms.Label lMinMinutesNight;
        private System.Windows.Forms.Label lMinSecondsNight;
        private System.Windows.Forms.Label lMaxSecondsNight;
        private System.Windows.Forms.Label lMaxMinutesNight;
        private System.Windows.Forms.Label lMaxHoursNight;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

