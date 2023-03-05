namespace TPMOD3_1302210028
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
            Inputan = new TextBox();
            button = new Button();
            PerintahInput = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // Inputan
            // 
            Inputan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Inputan.Location = new Point(263, 143);
            Inputan.Name = "Inputan";
            Inputan.Size = new Size(235, 39);
            Inputan.TabIndex = 2;
            Inputan.TextChanged += Inputan_TextChanged;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button.Location = new Point(316, 233);
            button.Name = "button";
            button.Size = new Size(122, 42);
            button.TabIndex = 3;
            button.Text = "Input";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // PerintahInput
            // 
            PerintahInput.AutoSize = true;
            PerintahInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PerintahInput.Location = new Point(290, 72);
            PerintahInput.Name = "PerintahInput";
            PerintahInput.Size = new Size(185, 32);
            PerintahInput.TabIndex = 4;
            PerintahInput.Text = "Inputkan Nama!";
            PerintahInput.Click += label1_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(263, 327);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(21, 32);
            lblResult.TabIndex = 5;
            lblResult.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(PerintahInput);
            Controls.Add(button);
            Controls.Add(Inputan);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Inputan;
        private Button button;
        private Label PerintahInput;
        private Label lblResult;
    }
}