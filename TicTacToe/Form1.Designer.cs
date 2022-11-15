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
            this.btn_0_0 = new System.Windows.Forms.Button();
            this.btn_0_1 = new System.Windows.Forms.Button();
            this.btn_0_2 = new System.Windows.Forms.Button();
            this.btn_1_2 = new System.Windows.Forms.Button();
            this.btn_1_1 = new System.Windows.Forms.Button();
            this.btn_1_0 = new System.Windows.Forms.Button();
            this.btn_2_2 = new System.Windows.Forms.Button();
            this.btn_2_1 = new System.Windows.Forms.Button();
            this.btn_2_0 = new System.Windows.Forms.Button();
            this.lbl_currentPlayerTxt = new System.Windows.Forms.Label();
            this.lbl_currentPlayer = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_0_0
            // 
            this.btn_0_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_0_0.Location = new System.Drawing.Point(12, 12);
            this.btn_0_0.Name = "btn_0_0";
            this.btn_0_0.Size = new System.Drawing.Size(133, 121);
            this.btn_0_0.TabIndex = 0;
            this.btn_0_0.UseVisualStyleBackColor = true;
            this.btn_0_0.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_0_1
            // 
            this.btn_0_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_0_1.Location = new System.Drawing.Point(151, 12);
            this.btn_0_1.Name = "btn_0_1";
            this.btn_0_1.Size = new System.Drawing.Size(133, 121);
            this.btn_0_1.TabIndex = 1;
            this.btn_0_1.UseVisualStyleBackColor = true;
            this.btn_0_1.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_0_2
            // 
            this.btn_0_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_0_2.Location = new System.Drawing.Point(290, 12);
            this.btn_0_2.Name = "btn_0_2";
            this.btn_0_2.Size = new System.Drawing.Size(133, 121);
            this.btn_0_2.TabIndex = 2;
            this.btn_0_2.UseVisualStyleBackColor = true;
            this.btn_0_2.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_1_2
            // 
            this.btn_1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_1_2.Location = new System.Drawing.Point(290, 139);
            this.btn_1_2.Name = "btn_1_2";
            this.btn_1_2.Size = new System.Drawing.Size(133, 121);
            this.btn_1_2.TabIndex = 5;
            this.btn_1_2.UseVisualStyleBackColor = true;
            this.btn_1_2.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_1_1
            // 
            this.btn_1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_1_1.Location = new System.Drawing.Point(151, 139);
            this.btn_1_1.Name = "btn_1_1";
            this.btn_1_1.Size = new System.Drawing.Size(133, 121);
            this.btn_1_1.TabIndex = 4;
            this.btn_1_1.UseVisualStyleBackColor = true;
            this.btn_1_1.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_1_0
            // 
            this.btn_1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_1_0.Location = new System.Drawing.Point(12, 139);
            this.btn_1_0.Name = "btn_1_0";
            this.btn_1_0.Size = new System.Drawing.Size(133, 121);
            this.btn_1_0.TabIndex = 3;
            this.btn_1_0.UseVisualStyleBackColor = true;
            this.btn_1_0.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_2_2
            // 
            this.btn_2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_2_2.Location = new System.Drawing.Point(290, 266);
            this.btn_2_2.Name = "btn_2_2";
            this.btn_2_2.Size = new System.Drawing.Size(133, 121);
            this.btn_2_2.TabIndex = 8;
            this.btn_2_2.UseVisualStyleBackColor = true;
            this.btn_2_2.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_2_1
            // 
            this.btn_2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_2_1.Location = new System.Drawing.Point(151, 266);
            this.btn_2_1.Name = "btn_2_1";
            this.btn_2_1.Size = new System.Drawing.Size(133, 121);
            this.btn_2_1.TabIndex = 7;
            this.btn_2_1.UseVisualStyleBackColor = true;
            this.btn_2_1.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_2_0
            // 
            this.btn_2_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_2_0.Location = new System.Drawing.Point(12, 266);
            this.btn_2_0.Name = "btn_2_0";
            this.btn_2_0.Size = new System.Drawing.Size(133, 121);
            this.btn_2_0.TabIndex = 6;
            this.btn_2_0.UseVisualStyleBackColor = true;
            this.btn_2_0.Click += new System.EventHandler(this.btn_7_Click);
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
            this.Controls.Add(this.btn_2_2);
            this.Controls.Add(this.btn_2_1);
            this.Controls.Add(this.btn_2_0);
            this.Controls.Add(this.btn_1_2);
            this.Controls.Add(this.btn_1_1);
            this.Controls.Add(this.btn_1_0);
            this.Controls.Add(this.btn_0_2);
            this.Controls.Add(this.btn_0_1);
            this.Controls.Add(this.btn_0_0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_0_0;
        private System.Windows.Forms.Button btn_0_1;
        private System.Windows.Forms.Button btn_0_2;
        private System.Windows.Forms.Button btn_1_2;
        private System.Windows.Forms.Button btn_1_1;
        private System.Windows.Forms.Button btn_1_0;
        private System.Windows.Forms.Button btn_2_2;
        private System.Windows.Forms.Button btn_2_1;
        private System.Windows.Forms.Button btn_2_0;
        private System.Windows.Forms.Label lbl_currentPlayerTxt;
        private System.Windows.Forms.Label lbl_currentPlayer;
        private System.Windows.Forms.Button btn_reset;
    }
}

