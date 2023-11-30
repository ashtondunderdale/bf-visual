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
            errorBox = new RichTextBox();
            label1 = new Label();
            pointerLocationBox = new TextBox();
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
            // errorBox
            // 
            errorBox.Location = new Point(336, 12);
            errorBox.Name = "errorBox";
            errorBox.Size = new Size(452, 110);
            errorBox.TabIndex = 2;
            errorBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 354);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Pointer Location";
            // 
            // pointerLocationBox
            // 
            pointerLocationBox.Location = new Point(134, 351);
            pointerLocationBox.Name = "pointerLocationBox";
            pointerLocationBox.Size = new Size(25, 27);
            pointerLocationBox.TabIndex = 4;
            // 
            // Brainfuck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pointerLocationBox);
            Controls.Add(label1);
            Controls.Add(errorBox);
            Controls.Add(outputBox);
            Controls.Add(inputBox);
            Name = "Brainfuck";
            Text = "Brainfuck";
            Load += Brainfuck_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox inputBox;
        private RichTextBox outputBox;
        private RichTextBox errorBox;
        private Label label1;
        private TextBox pointerLocationBox;
    }
}