namespace Lab2_Ex2
{
    partial class RSAPublicKey
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
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(85, 184);
            button1.Name = "button1";
            button1.Size = new Size(204, 115);
            button1.TabIndex = 0;
            button1.Text = "Random Key Numeric";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(458, 184);
            button3.Name = "button3";
            button3.Size = new Size(204, 115);
            button3.TabIndex = 2;
            button3.Text = "Random Key String";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // RSAPublicKey
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "RSAPublicKey";
            Text = "RSA Public-Key";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
    }
}