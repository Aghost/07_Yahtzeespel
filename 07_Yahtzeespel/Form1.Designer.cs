namespace _07_Yahtzeespel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_RollDie = new System.Windows.Forms.Button();
            this.Die1 = new System.Windows.Forms.PictureBox();
            this.Die2 = new System.Windows.Forms.PictureBox();
            this.Die3 = new System.Windows.Forms.PictureBox();
            this.Die4 = new System.Windows.Forms.PictureBox();
            this.Die5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Die1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die5)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_RollDie
            // 
            this.Btn_RollDie.Location = new System.Drawing.Point(9, 300);
            this.Btn_RollDie.Name = "Btn_RollDie";
            this.Btn_RollDie.Size = new System.Drawing.Size(64, 25);
            this.Btn_RollDie.TabIndex = 0;
            this.Btn_RollDie.Text = "Roll Dice";
            this.Btn_RollDie.UseVisualStyleBackColor = true;
            this.Btn_RollDie.Click += new System.EventHandler(this.Btn_RollDie_Click);
            // 
            // Die1
            // 
            this.Die1.ErrorImage = null;
            this.Die1.InitialImage = null;
            this.Die1.Location = new System.Drawing.Point(9, 230);
            this.Die1.Name = "Die1";
            this.Die1.Size = new System.Drawing.Size(64, 64);
            this.Die1.TabIndex = 1;
            this.Die1.TabStop = false;
            this.Die1.Click += new System.EventHandler(this.Btn_Die_Click);
            // 
            // Die2
            // 
            this.Die2.Location = new System.Drawing.Point(79, 230);
            this.Die2.Name = "Die2";
            this.Die2.Size = new System.Drawing.Size(64, 64);
            this.Die2.TabIndex = 1;
            this.Die2.TabStop = false;
            this.Die2.Click += new System.EventHandler(this.Btn_Die_Click);
            // 
            // Die3
            // 
            this.Die3.Location = new System.Drawing.Point(149, 230);
            this.Die3.Name = "Die3";
            this.Die3.Size = new System.Drawing.Size(64, 64);
            this.Die3.TabIndex = 1;
            this.Die3.TabStop = false;
            this.Die3.Click += new System.EventHandler(this.Btn_Die_Click);
            // 
            // Die4
            // 
            this.Die4.Location = new System.Drawing.Point(219, 230);
            this.Die4.Name = "Die4";
            this.Die4.Size = new System.Drawing.Size(64, 64);
            this.Die4.TabIndex = 1;
            this.Die4.TabStop = false;
            this.Die4.Click += new System.EventHandler(this.Btn_Die_Click);
            // 
            // Die5
            // 
            this.Die5.Location = new System.Drawing.Point(289, 230);
            this.Die5.Name = "Die5";
            this.Die5.Size = new System.Drawing.Size(64, 64);
            this.Die5.TabIndex = 1;
            this.Die5.TabStop = false;
            this.Die5.Click += new System.EventHandler(this.Btn_Die_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 337);
            this.Controls.Add(this.Die5);
            this.Controls.Add(this.Die4);
            this.Controls.Add(this.Die3);
            this.Controls.Add(this.Die2);
            this.Controls.Add(this.Die1);
            this.Controls.Add(this.Btn_RollDie);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Die1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_RollDie;
        private System.Windows.Forms.PictureBox Die1;
        private System.Windows.Forms.PictureBox Die2;
        private System.Windows.Forms.PictureBox Die3;
        private System.Windows.Forms.PictureBox Die4;
        private System.Windows.Forms.PictureBox Die5;
    }
}

