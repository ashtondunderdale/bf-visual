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
            arrayBox = new RichTextBox();
            errorBox = new RichTextBox();
            pointerLocationBox = new TextBox();
            label1 = new Label();
            outputBox = new RichTextBox();
            runButton = new Button();
            programInputBox = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(12, 12);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(352, 523);
            inputBox.TabIndex = 0;
            inputBox.Text = "";
            // 
            // arrayBox
            // 
            arrayBox.Location = new Point(475, 335);
            arrayBox.Name = "arrayBox";
            arrayBox.Size = new Size(930, 200);
            arrayBox.TabIndex = 1;
            arrayBox.Text = "";
            // 
            // errorBox
            // 
            errorBox.Location = new Point(1099, 12);
            errorBox.Name = "errorBox";
            errorBox.Size = new Size(306, 99);
            errorBox.TabIndex = 2;
            errorBox.Text = "";
            // 
            // pointerLocationBox
            // 
            pointerLocationBox.Location = new Point(475, 299);
            pointerLocationBox.Name = "pointerLocationBox";
            pointerLocationBox.Size = new Size(37, 27);
            pointerLocationBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(518, 302);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Pointer";
            // 
            // outputBox
            // 
            outputBox.Location = new Point(379, 12);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(210, 86);
            outputBox.TabIndex = 5;
            outputBox.Text = "";
            // 
            // runButton
            // 
            runButton.Location = new Point(467, 136);
            runButton.Name = "runButton";
            runButton.Size = new Size(122, 29);
            runButton.TabIndex = 6;
            runButton.Text = "Run Brainfuck";
            runButton.UseVisualStyleBackColor = true;
            // 
            // programInputBox
            // 
            programInputBox.Location = new Point(379, 104);
            programInputBox.Name = "programInputBox";
            programInputBox.Size = new Size(161, 26);
            programInputBox.TabIndex = 7;
            programInputBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 107);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 8;
            label2.Text = "Input";
            // 
            // Brainfuck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 556);
            Controls.Add(label2);
            Controls.Add(programInputBox);
            Controls.Add(runButton);
            Controls.Add(outputBox);
            Controls.Add(pointerLocationBox);
            Controls.Add(label1);
            Controls.Add(errorBox);
            Controls.Add(arrayBox);
            Controls.Add(inputBox);
            Name = "Brainfuck";
            Text = "Brainfuck";
            Load += Brainfuck_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RichTextBox inputBox;
        public RichTextBox arrayBox;
        public RichTextBox errorBox;
        public TextBox pointerLocationBox;
        public Label label1;
        public RichTextBox outputBox;
        public Button runButton;
        public static RichTextBox programInputBox;
        public Label label2;
    }
}