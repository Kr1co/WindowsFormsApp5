namespace WindowsFormsApp5
{
    partial class AddActivityForm
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
            this.components = new System.ComponentModel.Container();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EventPlancomboBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ModeratorcomboBox = new System.Windows.Forms.ComboBox();
            this.JuricomboBox = new System.Windows.Forms.ComboBox();
            this.AddActivity = new System.Windows.Forms.Button();
            this.AddJuri = new System.Windows.Forms.Button();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userbindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(157, 56);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление новой активности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(69, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "План события";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(69, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "День";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(69, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Начало мер.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(69, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Модератор";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(69, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Жюри";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(219, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 29);
            this.textBox1.TabIndex = 8;
            // 
            // EventPlancomboBox
            // 
            this.EventPlancomboBox.DataSource = this.eventBindingSource;
            this.EventPlancomboBox.DisplayMember = "Title";
            this.EventPlancomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventPlancomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventPlancomboBox.FormattingEnabled = true;
            this.EventPlancomboBox.Location = new System.Drawing.Point(219, 153);
            this.EventPlancomboBox.Name = "EventPlancomboBox";
            this.EventPlancomboBox.Size = new System.Drawing.Size(192, 32);
            this.EventPlancomboBox.TabIndex = 9;
            this.EventPlancomboBox.ValueMember = "ID";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(219, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 29);
            this.textBox2.TabIndex = 10;
            // 
            // ModeratorcomboBox
            // 
            this.ModeratorcomboBox.DataSource = this.userBindingSource;
            this.ModeratorcomboBox.DisplayMember = "Surname";
            this.ModeratorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeratorcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModeratorcomboBox.FormattingEnabled = true;
            this.ModeratorcomboBox.Location = new System.Drawing.Point(219, 281);
            this.ModeratorcomboBox.Name = "ModeratorcomboBox";
            this.ModeratorcomboBox.Size = new System.Drawing.Size(192, 32);
            this.ModeratorcomboBox.TabIndex = 12;
            this.ModeratorcomboBox.ValueMember = "ID";
            // 
            // JuricomboBox
            // 
            this.JuricomboBox.DataSource = this.userbindingSource2;
            this.JuricomboBox.DisplayMember = "Surname";
            this.JuricomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JuricomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JuricomboBox.FormattingEnabled = true;
            this.JuricomboBox.Location = new System.Drawing.Point(219, 326);
            this.JuricomboBox.Name = "JuricomboBox";
            this.JuricomboBox.Size = new System.Drawing.Size(192, 32);
            this.JuricomboBox.TabIndex = 13;
            this.JuricomboBox.ValueMember = "ID";
            // 
            // AddActivity
            // 
            this.AddActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddActivity.Location = new System.Drawing.Point(171, 383);
            this.AddActivity.Name = "AddActivity";
            this.AddActivity.Size = new System.Drawing.Size(307, 46);
            this.AddActivity.TabIndex = 14;
            this.AddActivity.Text = "Добавить новую активность";
            this.AddActivity.UseVisualStyleBackColor = true;
            this.AddActivity.Click += new System.EventHandler(this.AddActivity_Click);
            // 
            // AddJuri
            // 
            this.AddJuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddJuri.Location = new System.Drawing.Point(435, 326);
            this.AddJuri.Name = "AddJuri";
            this.AddJuri.Size = new System.Drawing.Size(117, 38);
            this.AddJuri.TabIndex = 15;
            this.AddJuri.Text = "Добавить";
            this.AddJuri.UseVisualStyleBackColor = true;
            this.AddJuri.Click += new System.EventHandler(this.AddJuri_Click);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(WindowsFormsApp5.DCom.Event);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(WindowsFormsApp5.DCom.User);
            // 
            // userbindingSource2
            // 
            this.userbindingSource2.DataSource = typeof(WindowsFormsApp5.DCom.User);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 29);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // AddActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 458);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AddJuri);
            this.Controls.Add(this.AddActivity);
            this.Controls.Add(this.JuricomboBox);
            this.Controls.Add(this.ModeratorcomboBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.EventPlancomboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "AddActivityForm";
            this.Text = "AddActivityForm";
            this.Load += new System.EventHandler(this.AddActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox EventPlancomboBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox ModeratorcomboBox;
        private System.Windows.Forms.ComboBox JuricomboBox;
        private System.Windows.Forms.Button AddActivity;
        private System.Windows.Forms.Button AddJuri;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userbindingSource2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}