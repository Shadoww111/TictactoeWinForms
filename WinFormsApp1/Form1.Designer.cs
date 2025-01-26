namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            button12 = new Button();
            button10 = new Button();
            panel5 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            b9 = new Button();
            b8 = new Button();
            b7 = new Button();
            b6 = new Button();
            b5 = new Button();
            b4 = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-2, 2);
            label1.Name = "label1";
            label1.Size = new Size(335, 73);
            label1.TabIndex = 0;
            label1.Text = "TicTacToe";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(22, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(1022, 503);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(620, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(380, 462);
            panel4.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(button12);
            panel6.Controls.Add(button10);
            panel6.Location = new Point(23, 163);
            panel6.Name = "panel6";
            panel6.Size = new Size(329, 265);
            panel6.TabIndex = 1;
            // 
            // button12
            // 
            button12.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(16, 145);
            button12.Name = "button12";
            button12.Size = new Size(302, 100);
            button12.TabIndex = 2;
            button12.Text = "Exit";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(14, 15);
            button10.Name = "button10";
            button10.Size = new Size(304, 115);
            button10.TabIndex = 0;
            button10.Text = "New Game";
            button10.UseVisualStyleBackColor = true;
            button10.Click += reset_click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(21, 19);
            panel5.Name = "panel5";
            panel5.Size = new Size(331, 123);
            panel5.TabIndex = 0;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(185, 65);
            label5.Name = "label5";
            label5.Size = new Size(135, 39);
            label5.TabIndex = 3;
            label5.Text = "0";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(185, 13);
            label4.Name = "label4";
            label4.Size = new Size(135, 39);
            label4.TabIndex = 2;
            label4.Text = "0";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 65);
            label3.Name = "label3";
            label3.Size = new Size(180, 39);
            label3.TabIndex = 1;
            label3.Text = "Player O : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 11);
            label2.Name = "label2";
            label2.Size = new Size(176, 39);
            label2.TabIndex = 0;
            label2.Text = "Player X : ";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(b9);
            panel3.Controls.Add(b8);
            panel3.Controls.Add(b7);
            panel3.Controls.Add(b6);
            panel3.Controls.Add(b5);
            panel3.Controls.Add(b4);
            panel3.Controls.Add(b3);
            panel3.Controls.Add(b2);
            panel3.Controls.Add(b1);
            panel3.Location = new Point(16, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 462);
            panel3.TabIndex = 0;
            // 
            // b9
            // 
            b9.BackColor = SystemColors.ActiveCaption;
            b9.Font = new Font("Microsoft Sans Serif", 48F);
            b9.Location = new Point(383, 310);
            b9.Name = "b9";
            b9.Size = new Size(168, 139);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = false;
            b9.Click += button_click;
            // 
            // b8
            // 
            b8.BackColor = SystemColors.ActiveCaption;
            b8.Font = new Font("Microsoft Sans Serif", 48F);
            b8.Location = new Point(198, 310);
            b8.Name = "b8";
            b8.Size = new Size(168, 139);
            b8.TabIndex = 7;
            b8.UseVisualStyleBackColor = false;
            b8.Click += button_click;
            // 
            // b7
            // 
            b7.BackColor = SystemColors.ActiveCaption;
            b7.Font = new Font("Microsoft Sans Serif", 48F);
            b7.Location = new Point(15, 310);
            b7.Name = "b7";
            b7.Size = new Size(168, 139);
            b7.TabIndex = 6;
            b7.UseVisualStyleBackColor = false;
            b7.Click += button_click;
            // 
            // b6
            // 
            b6.BackColor = SystemColors.ActiveCaption;
            b6.Font = new Font("Microsoft Sans Serif", 48F);
            b6.Location = new Point(383, 164);
            b6.Name = "b6";
            b6.Size = new Size(168, 139);
            b6.TabIndex = 5;
            b6.UseVisualStyleBackColor = false;
            b6.Click += button_click;
            // 
            // b5
            // 
            b5.BackColor = SystemColors.ActiveCaption;
            b5.Font = new Font("Microsoft Sans Serif", 48F);
            b5.Location = new Point(198, 164);
            b5.Name = "b5";
            b5.Size = new Size(168, 139);
            b5.TabIndex = 4;
            b5.UseVisualStyleBackColor = false;
            b5.Click += button_click;
            // 
            // b4
            // 
            b4.BackColor = SystemColors.ActiveCaption;
            b4.Font = new Font("Microsoft Sans Serif", 48F);
            b4.Location = new Point(15, 164);
            b4.Name = "b4";
            b4.Size = new Size(168, 139);
            b4.TabIndex = 3;
            b4.UseVisualStyleBackColor = false;
            b4.Click += button_click;
            // 
            // b3
            // 
            b3.BackColor = SystemColors.ActiveCaption;
            b3.Font = new Font("Microsoft Sans Serif", 48F);
            b3.Location = new Point(382, 16);
            b3.Name = "b3";
            b3.Size = new Size(168, 139);
            b3.TabIndex = 2;
            b3.UseVisualStyleBackColor = false;
            b3.Click += button_click;
            // 
            // b2
            // 
            b2.BackColor = SystemColors.ActiveCaption;
            b2.Font = new Font("Microsoft Sans Serif", 48F);
            b2.Location = new Point(197, 16);
            b2.Name = "b2";
            b2.Size = new Size(168, 139);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = false;
            b2.Click += button_click;
            // 
            // b1
            // 
            b1.BackColor = SystemColors.ActiveCaption;
            b1.Font = new Font("Microsoft Sans Serif", 48F);
            b1.Location = new Point(14, 16);
            b1.Name = "b1";
            b1.Size = new Size(168, 139);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = false;
            b1.Click += button_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1058, 624);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tictactoe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Panel panel3;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button button12;
        private Button button10;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}
