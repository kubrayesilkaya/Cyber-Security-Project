namespace MitreAttack
{
    partial class Test
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
            this.lblT1518 = new System.Windows.Forms.Label();
            this.lblT1614 = new System.Windows.Forms.Label();
            this.btn1518 = new System.Windows.Forms.Button();
            this.btnT1614 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblT1518
            // 
            this.lblT1518.AutoSize = true;
            this.lblT1518.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblT1518.Location = new System.Drawing.Point(155, 164);
            this.lblT1518.Name = "lblT1518";
            this.lblT1518.Size = new System.Drawing.Size(266, 22);
            this.lblT1518.TabIndex = 0;
            this.lblT1518.Text = "T1518 System Discovery Attack";
            // 
            // lblT1614
            // 
            this.lblT1614.AutoSize = true;
            this.lblT1614.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblT1614.Location = new System.Drawing.Point(598, 164);
            this.lblT1614.Name = "lblT1614";
            this.lblT1614.Size = new System.Drawing.Size(341, 22);
            this.lblT1614.TabIndex = 1;
            this.lblT1614.Text = "T1614 System Location Discovery Attack";
            // 
            // btn1518
            // 
            this.btn1518.BackColor = System.Drawing.Color.Red;
            this.btn1518.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1518.Location = new System.Drawing.Point(183, 253);
            this.btn1518.Name = "btn1518";
            this.btn1518.Size = new System.Drawing.Size(192, 78);
            this.btn1518.TabIndex = 2;
            this.btn1518.Text = "T1518";
            this.btn1518.UseVisualStyleBackColor = false;
            this.btn1518.Click += new System.EventHandler(this.btn1518_Click);
            // 
            // btnT1614
            // 
            this.btnT1614.BackColor = System.Drawing.Color.Red;
            this.btnT1614.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnT1614.Location = new System.Drawing.Point(667, 253);
            this.btnT1614.Name = "btnT1614";
            this.btnT1614.Size = new System.Drawing.Size(192, 78);
            this.btnT1614.TabIndex = 3;
            this.btnT1614.Text = "T1614";
            this.btnT1614.UseVisualStyleBackColor = false;
            this.btnT1614.Click += new System.EventHandler(this.btnT1614_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 672);
            this.Controls.Add(this.btnT1614);
            this.Controls.Add(this.btn1518);
            this.Controls.Add(this.lblT1614);
            this.Controls.Add(this.lblT1518);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblT1518;
        private System.Windows.Forms.Label lblT1614;
        private System.Windows.Forms.Button btn1518;
        private System.Windows.Forms.Button btnT1614;
    }
}

