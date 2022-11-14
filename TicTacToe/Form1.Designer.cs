namespace TicTacToe
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.lbl_currentPlayerTxt = new System.Windows.Forms.Label();
            this.lbl_currentPlayer = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 12);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(133, 121);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "btn_1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.Click_1);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(151, 12);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(133, 121);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "btn_2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.Click_1);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(290, 12);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(133, 121);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "btn_3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.Click_1);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(290, 139);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(133, 121);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "btn_6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.Click_1);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(151, 139);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(133, 121);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "btn_5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.Click_1);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(12, 139);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(133, 121);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "btn_4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.Click_1);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(290, 266);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(133, 121);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "btn_9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.Click_1);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(151, 266);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(133, 121);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "btn_8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.Click_1);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 266);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(133, 121);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "btn_7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.Click_1);
            // 
            // lbl_currentPlayerTxt
            // 
            this.lbl_currentPlayerTxt.AutoSize = true;
            this.lbl_currentPlayerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_currentPlayerTxt.Location = new System.Drawing.Point(486, 36);
            this.lbl_currentPlayerTxt.Name = "lbl_currentPlayerTxt";
            this.lbl_currentPlayerTxt.Size = new System.Drawing.Size(151, 29);
            this.lbl_currentPlayerTxt.TabIndex = 9;
            this.lbl_currentPlayerTxt.Text = "Ruch gracza:";
            // 
            // lbl_currentPlayer
            // 
            this.lbl_currentPlayer.AutoSize = true;
            this.lbl_currentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_currentPlayer.Location = new System.Drawing.Point(643, 36);
            this.lbl_currentPlayer.Name = "lbl_currentPlayer";
            this.lbl_currentPlayer.Size = new System.Drawing.Size(0, 29);
            this.lbl_currentPlayer.TabIndex = 10;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_reset.Location = new System.Drawing.Point(491, 350);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(182, 37);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_currentPlayer);
            this.Controls.Add(this.lbl_currentPlayerTxt);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Label lbl_currentPlayerTxt;
        private System.Windows.Forms.Label lbl_currentPlayer;
        private System.Windows.Forms.Button btn_reset;
    }
}

