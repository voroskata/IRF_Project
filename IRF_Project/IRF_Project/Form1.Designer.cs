
namespace IRF_Project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(783, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Legjobb játékos:";
            // 
            // nickname
            // 
            this.nickname.AutoSize = true;
            this.nickname.Location = new System.Drawing.Point(728, 69);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(46, 17);
            this.nickname.TabIndex = 2;
            this.nickname.Text = "label2";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Location = new System.Drawing.Point(908, 69);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(46, 17);
            this.points.TabIndex = 3;
            this.points.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(972, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "pont";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuestion.Location = new System.Drawing.Point(493, 158);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(70, 25);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "label3";
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(210, 239);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(46, 17);
            this.lblAnswer1.TabIndex = 6;
            this.lblAnswer1.Text = "label3";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(676, 239);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(46, 17);
            this.lblAnswer2.TabIndex = 7;
            this.lblAnswer2.Text = "label3";
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(210, 376);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(46, 17);
            this.lblAnswer3.TabIndex = 8;
            this.lblAnswer3.Text = "label3";
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.Location = new System.Drawing.Point(676, 376);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(46, 17);
            this.lblAnswer4.TabIndex = 9;
            this.lblAnswer4.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Eredmények";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.points);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nickname;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.Button button1;
    }
}

