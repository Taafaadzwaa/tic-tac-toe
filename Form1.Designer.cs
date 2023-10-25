namespace tic_tac_toe
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
            btnStart = new Button();
            label1 = new Label();
            buttonStart = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            player1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(688, 391);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(100, 9);
            label1.Name = "label1";
            label1.Size = new Size(587, 35);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO TIC-TAC-TOE !!!";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(213, 360);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(132, 40);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Confirm ";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(389, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(389, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(204, 99);
            label2.Name = "label2";
            label2.Size = new Size(307, 43);
            label2.TabIndex = 5;
            label2.Text = "ENTER PLAYER NAMES";
            // 
            // player1
            // 
            player1.AutoSize = true;
            player1.BackColor = Color.FromArgb(128, 128, 255);
            player1.Font = new Font("MV Boli", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            player1.Location = new Point(143, 186);
            player1.Name = "player1";
            player1.Size = new Size(96, 21);
            player1.TabIndex = 6;
            player1.Text = "PLAYER 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 128, 255);
            label3.Font = new Font("MV Boli", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(138, 273);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 7;
            label3.Text = "PLAYER 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(player1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonStart);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Start Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label label1;
        private Button buttonStart;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label player1;
        private Label label3;
    }
}