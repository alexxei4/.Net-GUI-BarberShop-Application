namespace LabTwoB
{
    partial class Form1
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
            this.hairdresserbox = new System.Windows.Forms.GroupBox();
            this.LauraRenkins = new System.Windows.Forms.RadioButton();
            this.SuePallon = new System.Windows.Forms.RadioButton();
            this.RonChambers = new System.Windows.Forms.RadioButton();
            this.PatJohnson = new System.Windows.Forms.RadioButton();
            this.JaneSamley = new System.Windows.Forms.RadioButton();
            this.Servicesbox = new System.Windows.Forms.GroupBox();
            this.Extensions = new System.Windows.Forms.CheckBox();
            this.Highlights = new System.Windows.Forms.CheckBox();
            this.Colour = new System.Windows.Forms.CheckBox();
            this.Cut = new System.Windows.Forms.CheckBox();
            this.clientbox = new System.Windows.Forms.GroupBox();
            this.Elderly = new System.Windows.Forms.RadioButton();
            this.Student = new System.Windows.Forms.RadioButton();
            this.LilKid = new System.Windows.Forms.RadioButton();
            this.Standard = new System.Windows.Forms.RadioButton();
            this.clientv = new System.Windows.Forms.GroupBox();
            this.clientnumeric = new System.Windows.Forms.NumericUpDown();
            this.clientvisitlabel = new System.Windows.Forms.Label();
            this.totalprice = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hairdresserbox.SuspendLayout();
            this.Servicesbox.SuspendLayout();
            this.clientbox.SuspendLayout();
            this.clientv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // hairdresserbox
            // 
            this.hairdresserbox.Controls.Add(this.LauraRenkins);
            this.hairdresserbox.Controls.Add(this.SuePallon);
            this.hairdresserbox.Controls.Add(this.RonChambers);
            this.hairdresserbox.Controls.Add(this.PatJohnson);
            this.hairdresserbox.Controls.Add(this.JaneSamley);
            this.hairdresserbox.Location = new System.Drawing.Point(24, 20);
            this.hairdresserbox.Margin = new System.Windows.Forms.Padding(2);
            this.hairdresserbox.Name = "hairdresserbox";
            this.hairdresserbox.Padding = new System.Windows.Forms.Padding(2);
            this.hairdresserbox.Size = new System.Drawing.Size(146, 132);
            this.hairdresserbox.TabIndex = 0;
            this.hairdresserbox.TabStop = false;
            this.hairdresserbox.Text = "HairDresser";
            // 
            // LauraRenkins
            // 
            this.LauraRenkins.AutoSize = true;
            this.LauraRenkins.Location = new System.Drawing.Point(5, 105);
            this.LauraRenkins.Margin = new System.Windows.Forms.Padding(2);
            this.LauraRenkins.Name = "LauraRenkins";
            this.LauraRenkins.Size = new System.Drawing.Size(56, 17);
            this.LauraRenkins.TabIndex = 4;
            this.LauraRenkins.Text = "Laura";
            this.LauraRenkins.UseVisualStyleBackColor = true;
            // 
            // SuePallon
            // 
            this.SuePallon.AutoSize = true;
            this.SuePallon.Location = new System.Drawing.Point(5, 83);
            this.SuePallon.Margin = new System.Windows.Forms.Padding(2);
            this.SuePallon.Name = "SuePallon";
            this.SuePallon.Size = new System.Drawing.Size(45, 17);
            this.SuePallon.TabIndex = 3;
            this.SuePallon.Text = "Sue";
            this.SuePallon.UseVisualStyleBackColor = true;
            // 
            // RonChambers
            // 
            this.RonChambers.AutoSize = true;
            this.RonChambers.Location = new System.Drawing.Point(5, 61);
            this.RonChambers.Margin = new System.Windows.Forms.Padding(2);
            this.RonChambers.Name = "RonChambers";
            this.RonChambers.Size = new System.Drawing.Size(46, 17);
            this.RonChambers.TabIndex = 2;
            this.RonChambers.Text = "Ron";
            this.RonChambers.UseVisualStyleBackColor = true;
            // 
            // PatJohnson
            // 
            this.PatJohnson.AutoSize = true;
            this.PatJohnson.Location = new System.Drawing.Point(5, 39);
            this.PatJohnson.Margin = new System.Windows.Forms.Padding(2);
            this.PatJohnson.Name = "PatJohnson";
            this.PatJohnson.Size = new System.Drawing.Size(42, 17);
            this.PatJohnson.TabIndex = 1;
            this.PatJohnson.Text = "Pat";
            this.PatJohnson.UseVisualStyleBackColor = true;
            // 
            // JaneSamley
            // 
            this.JaneSamley.AutoSize = true;
            this.JaneSamley.Checked = true;
            this.JaneSamley.Location = new System.Drawing.Point(5, 17);
            this.JaneSamley.Margin = new System.Windows.Forms.Padding(2);
            this.JaneSamley.Name = "JaneSamley";
            this.JaneSamley.Size = new System.Drawing.Size(50, 17);
            this.JaneSamley.TabIndex = 0;
            this.JaneSamley.TabStop = true;
            this.JaneSamley.Text = "Jane";
            this.JaneSamley.UseVisualStyleBackColor = true;
           
            // 
            // Servicesbox
            // 
            this.Servicesbox.Controls.Add(this.Extensions);
            this.Servicesbox.Controls.Add(this.Highlights);
            this.Servicesbox.Controls.Add(this.Colour);
            this.Servicesbox.Controls.Add(this.Cut);
            this.Servicesbox.Location = new System.Drawing.Point(261, 17);
            this.Servicesbox.Margin = new System.Windows.Forms.Padding(2);
            this.Servicesbox.Name = "Servicesbox";
            this.Servicesbox.Padding = new System.Windows.Forms.Padding(2);
            this.Servicesbox.Size = new System.Drawing.Size(132, 134);
            this.Servicesbox.TabIndex = 1;
            this.Servicesbox.TabStop = false;
            this.Servicesbox.Text = "Services";
            // 
            // Extensions
            // 
            this.Extensions.AutoSize = true;
            this.Extensions.Location = new System.Drawing.Point(6, 87);
            this.Extensions.Margin = new System.Windows.Forms.Padding(2);
            this.Extensions.Name = "Extensions";
            this.Extensions.Size = new System.Drawing.Size(82, 17);
            this.Extensions.TabIndex = 3;
            this.Extensions.Text = "Extensions";
            this.Extensions.UseVisualStyleBackColor = true;
            // 
            // Highlights
            // 
            this.Highlights.AutoSize = true;
            this.Highlights.Location = new System.Drawing.Point(6, 64);
            this.Highlights.Margin = new System.Windows.Forms.Padding(2);
            this.Highlights.Name = "Highlights";
            this.Highlights.Size = new System.Drawing.Size(82, 17);
            this.Highlights.TabIndex = 2;
            this.Highlights.Text = "Highlights";
            this.Highlights.UseVisualStyleBackColor = true;
            // 
            // Colour
            // 
            this.Colour.AutoSize = true;
            this.Colour.Location = new System.Drawing.Point(6, 43);
            this.Colour.Margin = new System.Windows.Forms.Padding(2);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(63, 17);
            this.Colour.TabIndex = 1;
            this.Colour.Text = "Colour";
            this.Colour.UseVisualStyleBackColor = true;
            // 
            // Cut
            // 
            this.Cut.AutoSize = true;
            this.Cut.Location = new System.Drawing.Point(6, 20);
            this.Cut.Margin = new System.Windows.Forms.Padding(2);
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(46, 17);
            this.Cut.TabIndex = 0;
            this.Cut.Text = "Cut";
            this.Cut.UseVisualStyleBackColor = true;
            // 
            // clientbox
            // 
            this.clientbox.Controls.Add(this.Elderly);
            this.clientbox.Controls.Add(this.Student);
            this.clientbox.Controls.Add(this.LilKid);
            this.clientbox.Controls.Add(this.Standard);
            this.clientbox.Location = new System.Drawing.Point(24, 171);
            this.clientbox.Margin = new System.Windows.Forms.Padding(2);
            this.clientbox.Name = "clientbox";
            this.clientbox.Padding = new System.Windows.Forms.Padding(2);
            this.clientbox.Size = new System.Drawing.Size(146, 132);
            this.clientbox.TabIndex = 5;
            this.clientbox.TabStop = false;
            this.clientbox.Text = "Client Type";
            // 
            // Elderly
            // 
            this.Elderly.AutoSize = true;
            this.Elderly.Location = new System.Drawing.Point(5, 83);
            this.Elderly.Margin = new System.Windows.Forms.Padding(2);
            this.Elderly.Name = "Elderly";
            this.Elderly.Size = new System.Drawing.Size(81, 17);
            this.Elderly.TabIndex = 3;
            this.Elderly.Text = "Senior 65+";
            this.Elderly.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(5, 61);
            this.Student.Margin = new System.Windows.Forms.Padding(2);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(66, 17);
            this.Student.TabIndex = 2;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // LilKid
            // 
            this.LilKid.AutoSize = true;
            this.LilKid.Location = new System.Drawing.Point(5, 39);
            this.LilKid.Margin = new System.Windows.Forms.Padding(2);
            this.LilKid.Name = "LilKid";
            this.LilKid.Size = new System.Drawing.Size(131, 17);
            this.LilKid.TabIndex = 1;
            this.LilKid.Text = "Child(12 and under)";
            this.LilKid.UseVisualStyleBackColor = true;
            // 
            // Standard
            // 
            this.Standard.AutoSize = true;
            this.Standard.Checked = true;
            this.Standard.Location = new System.Drawing.Point(5, 17);
            this.Standard.Margin = new System.Windows.Forms.Padding(2);
            this.Standard.Name = "Standard";
            this.Standard.Size = new System.Drawing.Size(103, 17);
            this.Standard.TabIndex = 0;
            this.Standard.TabStop = true;
            this.Standard.Text = "Standard Adult";
            this.Standard.UseVisualStyleBackColor = true;
            // 
            // clientv
            // 
            this.clientv.Controls.Add(this.clientnumeric);
            this.clientv.Controls.Add(this.clientvisitlabel);
            this.clientv.Location = new System.Drawing.Point(261, 171);
            this.clientv.Margin = new System.Windows.Forms.Padding(2);
            this.clientv.Name = "clientv";
            this.clientv.Padding = new System.Windows.Forms.Padding(2);
            this.clientv.Size = new System.Drawing.Size(132, 132);
            this.clientv.TabIndex = 6;
            this.clientv.TabStop = false;
            this.clientv.Text = "Client Visits";
            // 
            // clientnumeric
            // 
            this.clientnumeric.Location = new System.Drawing.Point(6, 46);
            this.clientnumeric.Margin = new System.Windows.Forms.Padding(2);
            this.clientnumeric.Name = "clientnumeric";
            this.clientnumeric.Size = new System.Drawing.Size(105, 20);
            this.clientnumeric.TabIndex = 1;
            // 
            // clientvisitlabel
            // 
            this.clientvisitlabel.AutoSize = true;
            this.clientvisitlabel.Location = new System.Drawing.Point(-2, 23);
            this.clientvisitlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientvisitlabel.Name = "clientvisitlabel";
            this.clientvisitlabel.Size = new System.Drawing.Size(136, 13);
            this.clientvisitlabel.TabIndex = 0;
            this.clientvisitlabel.Text = "Number of Client Visits:";
            this.clientvisitlabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // totalprice
            // 
            this.totalprice.AutoSize = true;
            this.totalprice.Location = new System.Drawing.Point(124, 306);
            this.totalprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(66, 13);
            this.totalprice.TabIndex = 7;
            this.totalprice.Text = "Total Price:";
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Plum;
            this.calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calculate.Cursor = System.Windows.Forms.Cursors.No;
            this.calculate.Location = new System.Drawing.Point(24, 332);
            this.calculate.Margin = new System.Windows.Forms.Padding(2);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(91, 32);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Plum;
            this.clear.Location = new System.Drawing.Point(202, 333);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 31);
            this.clear.TabIndex = 9;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Violet;
            this.exit.Location = new System.Drawing.Point(357, 334);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(65, 30);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(191, 306);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(87, 13);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(439, 382);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.clientv);
            this.Controls.Add(this.clientbox);
            this.Controls.Add(this.Servicesbox);
            this.Controls.Add(this.hairdresserbox);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SpringGreen;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hairdresserbox.ResumeLayout(false);
            this.hairdresserbox.PerformLayout();
            this.Servicesbox.ResumeLayout(false);
            this.Servicesbox.PerformLayout();
            this.clientbox.ResumeLayout(false);
            this.clientbox.PerformLayout();
            this.clientv.ResumeLayout(false);
            this.clientv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientnumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hairdresserbox;
        private System.Windows.Forms.RadioButton LauraRenkins;
        private System.Windows.Forms.RadioButton SuePallon;
        private System.Windows.Forms.RadioButton RonChambers;
        private System.Windows.Forms.RadioButton PatJohnson;
        private System.Windows.Forms.RadioButton JaneSamley;
        private System.Windows.Forms.GroupBox Servicesbox;
        private System.Windows.Forms.CheckBox Extensions;
        private System.Windows.Forms.CheckBox Highlights;
        private System.Windows.Forms.CheckBox Colour;
        private System.Windows.Forms.CheckBox Cut;
        private System.Windows.Forms.GroupBox clientbox;
        private System.Windows.Forms.RadioButton Elderly;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.RadioButton LilKid;
        private System.Windows.Forms.RadioButton Standard;
        private System.Windows.Forms.GroupBox clientv;
        private System.Windows.Forms.Label clientvisitlabel;
        private System.Windows.Forms.Label totalprice;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.NumericUpDown clientnumeric;
        private System.Windows.Forms.TextBox textBox1;
    }
}

