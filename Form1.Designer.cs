namespace ContaPersone
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
            this.components = new System.ComponentModel.Container();
            this.btPersonAdd = new System.Windows.Forms.Button();
            this.byPersonMinus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPersonNumber = new System.Windows.Forms.TextBox();
            this.tbMaxPerson = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbTextStop = new System.Windows.Forms.TextBox();
            this.tbTextVia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btPersonAdd
            // 
            this.btPersonAdd.Location = new System.Drawing.Point(153, 261);
            this.btPersonAdd.Name = "btPersonAdd";
            this.btPersonAdd.Size = new System.Drawing.Size(114, 48);
            this.btPersonAdd.TabIndex = 0;
            this.btPersonAdd.Text = "Persona +";
            this.btPersonAdd.UseVisualStyleBackColor = true;
            this.btPersonAdd.Click += new System.EventHandler(this.btPersonAdd_Click);
            // 
            // byPersonMinus
            // 
            this.byPersonMinus.Location = new System.Drawing.Point(153, 344);
            this.byPersonMinus.Name = "byPersonMinus";
            this.byPersonMinus.Size = new System.Drawing.Size(114, 48);
            this.byPersonMinus.TabIndex = 1;
            this.byPersonMinus.Text = "Persona -";
            this.byPersonMinus.UseVisualStyleBackColor = true;
            this.byPersonMinus.Click += new System.EventHandler(this.byPersonMinus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Limite di persone:";
            // 
            // tbPersonNumber
            // 
            this.tbPersonNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonNumber.Location = new System.Drawing.Point(315, 314);
            this.tbPersonNumber.Name = "tbPersonNumber";
            this.tbPersonNumber.Size = new System.Drawing.Size(52, 26);
            this.tbPersonNumber.TabIndex = 3;
            this.tbPersonNumber.Text = "9999";
            this.tbPersonNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMaxPerson
            // 
            this.tbMaxPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxPerson.Location = new System.Drawing.Point(98, 26);
            this.tbMaxPerson.Name = "tbMaxPerson";
            this.tbMaxPerson.Size = new System.Drawing.Size(45, 26);
            this.tbMaxPerson.TabIndex = 4;
            this.tbMaxPerson.Text = "3";
            this.tbMaxPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMaxPerson.TextChanged += new System.EventHandler(this.tbMaxPerson_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTextVia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTextStop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMaxPerson);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 145);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Red;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClose.Location = new System.Drawing.Point(367, 413);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(113, 30);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Testo ext STOP:";
            // 
            // tbTextStop
            // 
            this.tbTextStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTextStop.Location = new System.Drawing.Point(98, 58);
            this.tbTextStop.Name = "tbTextStop";
            this.tbTextStop.Size = new System.Drawing.Size(257, 21);
            this.tbTextStop.TabIndex = 6;
            this.tbTextStop.Text = "Aspettare che esca una persona";
            this.tbTextStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTextVia
            // 
            this.tbTextVia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTextVia.Location = new System.Drawing.Point(98, 86);
            this.tbTextVia.Name = "tbTextVia";
            this.tbTextVia.Size = new System.Drawing.Size(257, 21);
            this.tbTextVia.TabIndex = 8;
            this.tbTextVia.Text = "Prego, entrare pure";
            this.tbTextVia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Testo ext VIA:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 455);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPersonNumber);
            this.Controls.Add(this.byPersonMinus);
            this.Controls.Add(this.btPersonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPersonAdd;
        private System.Windows.Forms.Button byPersonMinus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPersonNumber;
        private System.Windows.Forms.TextBox tbMaxPerson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbTextStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTextVia;
        private System.Windows.Forms.Label label3;
    }
}

