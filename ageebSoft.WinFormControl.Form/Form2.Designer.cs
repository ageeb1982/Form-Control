namespace ageebSoft.WinFormControl.FormX
{
    partial class Form2
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
            this.cmdAr = new System.Windows.Forms.Button();
            this.cmdEng = new System.Windows.Forms.Button();
            this.cmdUp = new System.Windows.Forms.Button();
            this.cmdDown = new System.Windows.Forms.Button();
            this.cmdR = new System.Windows.Forms.Button();
            this.cmdL = new System.Windows.Forms.Button();
            this.cmdRDown = new System.Windows.Forms.Button();
            this.CmdRUp = new System.Windows.Forms.Button();
            this.cmdLUp = new System.Windows.Forms.Button();
            this.cmdLDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAr
            // 
            this.cmdAr.Location = new System.Drawing.Point(105, 12);
            this.cmdAr.Name = "cmdAr";
            this.cmdAr.Size = new System.Drawing.Size(75, 23);
            this.cmdAr.TabIndex = 0;
            this.cmdAr.Text = "عربي";
            this.cmdAr.UseVisualStyleBackColor = true;
            this.cmdAr.Click += new System.EventHandler(this.cmdAr_Click);
            // 
            // cmdEng
            // 
            this.cmdEng.Location = new System.Drawing.Point(24, 12);
            this.cmdEng.Name = "cmdEng";
            this.cmdEng.Size = new System.Drawing.Size(75, 23);
            this.cmdEng.TabIndex = 0;
            this.cmdEng.Text = "انجليزي";
            this.cmdEng.UseVisualStyleBackColor = true;
            this.cmdEng.Click += new System.EventHandler(this.cmdEng_Click);
            // 
            // cmdUp
            // 
            this.cmdUp.Location = new System.Drawing.Point(84, 46);
            this.cmdUp.Name = "cmdUp";
            this.cmdUp.Size = new System.Drawing.Size(38, 42);
            this.cmdUp.TabIndex = 0;
            this.cmdUp.Text = "فوق";
            this.cmdUp.UseVisualStyleBackColor = true;
            this.cmdUp.Click += new System.EventHandler(this.cmdUp_Click);
            // 
            // cmdDown
            // 
            this.cmdDown.Location = new System.Drawing.Point(84, 108);
            this.cmdDown.Name = "cmdDown";
            this.cmdDown.Size = new System.Drawing.Size(38, 42);
            this.cmdDown.TabIndex = 0;
            this.cmdDown.Text = "تحت";
            this.cmdDown.UseVisualStyleBackColor = true;
            this.cmdDown.Click += new System.EventHandler(this.cmdDown_Click);
            // 
            // cmdR
            // 
            this.cmdR.Location = new System.Drawing.Point(128, 82);
            this.cmdR.Name = "cmdR";
            this.cmdR.Size = new System.Drawing.Size(52, 30);
            this.cmdR.TabIndex = 0;
            this.cmdR.Text = "يمين";
            this.cmdR.UseVisualStyleBackColor = true;
            this.cmdR.Click += new System.EventHandler(this.cmdR_Click);
            // 
            // cmdL
            // 
            this.cmdL.Location = new System.Drawing.Point(24, 82);
            this.cmdL.Name = "cmdL";
            this.cmdL.Size = new System.Drawing.Size(54, 30);
            this.cmdL.TabIndex = 0;
            this.cmdL.Text = "شمال";
            this.cmdL.UseVisualStyleBackColor = true;
            this.cmdL.Click += new System.EventHandler(this.cmdL_Click);
            // 
            // cmdRDown
            // 
            this.cmdRDown.Location = new System.Drawing.Point(128, 118);
            this.cmdRDown.Name = "cmdRDown";
            this.cmdRDown.Size = new System.Drawing.Size(70, 30);
            this.cmdRDown.TabIndex = 0;
            this.cmdRDown.Text = "يمين لتحت";
            this.cmdRDown.UseVisualStyleBackColor = true;
            this.cmdRDown.Click += new System.EventHandler(this.cmdRDown_Click);
            // 
            // CmdRUp
            // 
            this.CmdRUp.Location = new System.Drawing.Point(128, 46);
            this.CmdRUp.Name = "CmdRUp";
            this.CmdRUp.Size = new System.Drawing.Size(70, 30);
            this.CmdRUp.TabIndex = 0;
            this.CmdRUp.Text = "يمين لفوق";
            this.CmdRUp.UseVisualStyleBackColor = true;
            this.CmdRUp.Click += new System.EventHandler(this.CmdRUp_Click);
            // 
            // cmdLUp
            // 
            this.cmdLUp.Location = new System.Drawing.Point(8, 46);
            this.cmdLUp.Name = "cmdLUp";
            this.cmdLUp.Size = new System.Drawing.Size(70, 30);
            this.cmdLUp.TabIndex = 0;
            this.cmdLUp.Text = "شمال لفوق";
            this.cmdLUp.UseVisualStyleBackColor = true;
            this.cmdLUp.Click += new System.EventHandler(this.cmdLUp_Click);
            // 
            // cmdLDown
            // 
            this.cmdLDown.Location = new System.Drawing.Point(8, 120);
            this.cmdLDown.Name = "cmdLDown";
            this.cmdLDown.Size = new System.Drawing.Size(70, 30);
            this.cmdLDown.TabIndex = 0;
            this.cmdLDown.Text = "شمال لتحت";
            this.cmdLDown.UseVisualStyleBackColor = true;
            this.cmdLDown.Click += new System.EventHandler(this.cmdLDown_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 162);
            this.Controls.Add(this.cmdL);
            this.Controls.Add(this.cmdLDown);
            this.Controls.Add(this.cmdLUp);
            this.Controls.Add(this.CmdRUp);
            this.Controls.Add(this.cmdRDown);
            this.Controls.Add(this.cmdR);
            this.Controls.Add(this.cmdDown);
            this.Controls.Add(this.cmdUp);
            this.Controls.Add(this.cmdEng);
            this.Controls.Add(this.cmdAr);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAr;
        private System.Windows.Forms.Button cmdEng;
        private System.Windows.Forms.Button cmdUp;
        private System.Windows.Forms.Button cmdDown;
        private System.Windows.Forms.Button cmdR;
        private System.Windows.Forms.Button cmdL;
        private System.Windows.Forms.Button cmdRDown;
        private System.Windows.Forms.Button CmdRUp;
        private System.Windows.Forms.Button cmdLUp;
        private System.Windows.Forms.Button cmdLDown;
    }
}