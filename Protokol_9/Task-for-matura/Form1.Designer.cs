
namespace Task_for_matura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vsb1 = new System.Windows.Forms.VScrollBar();
            this.TxtStepen = new System.Windows.Forms.TextBox();
            this.ButtonStepen = new System.Windows.Forms.RadioButton();
            this.ButtonKV = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cmdNew = new System.Windows.Forms.Button();
            this.cmdres = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведете стойност за пресмятане";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Резултат";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 26);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(203, 20);
            this.txtInput.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(282, 26);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(198, 20);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vsb1);
            this.groupBox1.Controls.Add(this.TxtStepen);
            this.groupBox1.Controls.Add(this.ButtonStepen);
            this.groupBox1.Controls.Add(this.ButtonKV);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(15, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Избор на действие";
            // 
            // vsb1
            // 
            this.vsb1.LargeChange = 1;
            this.vsb1.Location = new System.Drawing.Point(186, 52);
            this.vsb1.Name = "vsb1";
            this.vsb1.Size = new System.Drawing.Size(13, 20);
            this.vsb1.TabIndex = 10;
            this.vsb1.Value = 2;
            // 
            // TxtStepen
            // 
            this.TxtStepen.Location = new System.Drawing.Point(154, 52);
            this.TxtStepen.Name = "TxtStepen";
            this.TxtStepen.Size = new System.Drawing.Size(29, 20);
            this.TxtStepen.TabIndex = 9;
            this.TxtStepen.Text = "2";
            this.TxtStepen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonStepen
            // 
            this.ButtonStepen.AutoSize = true;
            this.ButtonStepen.Location = new System.Drawing.Point(7, 55);
            this.ButtonStepen.Name = "ButtonStepen";
            this.ButtonStepen.Size = new System.Drawing.Size(141, 17);
            this.ButtonStepen.TabIndex = 3;
            this.ButtonStepen.TabStop = true;
            this.ButtonStepen.Text = "Пресмятане на степен";
            this.ButtonStepen.UseVisualStyleBackColor = true;
            // 
            // ButtonKV
            // 
            this.ButtonKV.AutoSize = true;
            this.ButtonKV.Location = new System.Drawing.Point(7, 32);
            this.ButtonKV.Name = "ButtonKV";
            this.ButtonKV.Size = new System.Drawing.Size(192, 17);
            this.ButtonKV.TabIndex = 0;
            this.ButtonKV.TabStop = true;
            this.ButtonKV.Text = "Пресмятане на квадратен корен";
            this.ButtonKV.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(282, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 98);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Избор на режим за действие на данни";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 30);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Режим на ограничаването\r\nпри въвеждането\r\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 30);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Режим на проверка \r\nпри въвеждането";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(15, 185);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(100, 55);
            this.cmdNew.TabIndex = 6;
            this.cmdNew.Text = "Нови данни";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdres
            // 
            this.cmdres.Location = new System.Drawing.Point(201, 185);
            this.cmdres.Name = "cmdres";
            this.cmdres.Size = new System.Drawing.Size(100, 55);
            this.cmdres.TabIndex = 7;
            this.cmdres.Text = "Квадратен корен";
            this.cmdres.UseVisualStyleBackColor = true;
            this.cmdres.Click += new System.EventHandler(this.cmdres_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(380, 185);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(100, 55);
            this.cmdExit.TabIndex = 8;
            this.cmdExit.Text = "Изход";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 255);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdres);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Задача";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ButtonKV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton ButtonStepen;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.Button cmdres;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.VScrollBar vsb1;
        private System.Windows.Forms.TextBox TxtStepen;
    }
}

