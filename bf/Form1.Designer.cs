namespace bf
{
    partial class Brainfuck
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            inputBox = new RichTextBox();
            outputBox = new RichTextBox();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(12, 12);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(318, 110);
            inputBox.TabIndex = 0;
            inputBox.Text = "";
            // 
            // outputBox
            // 
            outputBox.Location = new Point(12, 128);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(776, 45);
            outputBox.TabIndex = 1;
            outputBox.Text = "";
            // 
            // Brainfuck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputBox);
            Controls.Add(inputBox);
            Name = "Brainfuck";
            Text = "Brainfuck";
            Load += Brainfuck_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox inputBox;
        private RichTextBox outputBox;
    }
}