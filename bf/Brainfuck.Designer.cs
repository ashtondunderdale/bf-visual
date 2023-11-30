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
            darkModeCheckBox = new CheckBox();
            label3 = new Label();
            dataValueBox = new TextBox();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(12, 12);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(352, 465);
            inputBox.TabIndex = 0;
            inputBox.Text = "";
            // 
            // arrayBox
            // 
            arrayBox.Location = new Point(475, 418);
            arrayBox.Name = "arrayBox";
            arrayBox.ReadOnly = true;
            arrayBox.Size = new Size(930, 117);
            arrayBox.TabIndex = 1;
            arrayBox.Text = "";
            // 
            // errorBox
            // 
            errorBox.Location = new Point(1099, 313);
            errorBox.Name = "errorBox";
            errorBox.ReadOnly = true;
            errorBox.Size = new Size(306, 99);
            errorBox.TabIndex = 2;
            errorBox.Text = "";
            // 
            // pointerLocationBox
            // 
            pointerLocationBox.Location = new Point(597, 389);
            pointerLocationBox.Name = "pointerLocationBox";
            pointerLocationBox.Size = new Size(37, 27);
            pointerLocationBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 392);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Pointer Location";
            // 
            // outputBox
            // 
            outputBox.Location = new Point(12, 483);
            outputBox.Name = "outputBox";
            outputBox.ReadOnly = true;
            outputBox.Size = new Size(352, 61);
            outputBox.TabIndex = 5;
            outputBox.Text = "";
            // 
            // runButton
            // 
            runButton.Location = new Point(370, 14);
            runButton.Name = "runButton";
            runButton.Size = new Size(122, 29);
            runButton.TabIndex = 6;
            runButton.Text = "Run Brainfuck";
            runButton.UseVisualStyleBackColor = true;
            // 
            // programInputBox
            // 
            programInputBox.Location = new Point(419, 49);
            programInputBox.Name = "programInputBox";
            programInputBox.Size = new Size(73, 26);
            programInputBox.TabIndex = 7;
            programInputBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 8;
            label2.Text = "Input";
            // 
            // darkModeCheckBox
            // 
            darkModeCheckBox.AutoSize = true;
            darkModeCheckBox.Location = new Point(1300, 14);
            darkModeCheckBox.Name = "darkModeCheckBox";
            darkModeCheckBox.Size = new Size(105, 24);
            darkModeCheckBox.TabIndex = 9;
            darkModeCheckBox.Text = "Dark Mode";
            darkModeCheckBox.UseVisualStyleBackColor = true;
            darkModeCheckBox.CheckedChanged += DarkMode.darkModeCheckBox_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(664, 392);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 10;
            label3.Text = "Data Value";
            // 
            // dataValueBox
            // 
            dataValueBox.Location = new Point(751, 389);
            dataValueBox.Name = "dataValueBox";
            dataValueBox.Size = new Size(37, 27);
            dataValueBox.TabIndex = 12;
            // 
            // Brainfuck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 556);
            Controls.Add(dataValueBox);
            Controls.Add(label3);
            Controls.Add(darkModeCheckBox);
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

        public static Label label3;
        public static TextBox dataValueBox;
        public static RichTextBox inputBox;
        public static RichTextBox arrayBox;
        public static RichTextBox errorBox;
        public static TextBox pointerLocationBox;
        public static Label label1;
        public static RichTextBox outputBox;
        public static Button runButton;
        public static Label label2;
        public static CheckBox darkModeCheckBox;
        public static RichTextBox programInputBox;
    }
}