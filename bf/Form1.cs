using System.Drawing.Printing;

namespace bf
{
    public partial class Brainfuck : Form
    {
        public Brainfuck()
        {
            InitializeComponent();
        }

        private void Brainfuck_Load(object sender, EventArgs e)
        {
            inputBox.TextChanged += InputBox_TextChanged;
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            int dataPointer = 0;
            byte[] tape = new byte[10]; //32768

            outputBox.Text = "";

            foreach (var command in inputBox.Text)
            {
                switch (command)
                {
                    case '>':
                        dataPointer++;
                        break;

                    case '<':
                        dataPointer--;
                        break;

                    case '+':
                        if (dataPointer < tape.Length) tape[dataPointer]++;

                        break;

                    case '-':
                        if (dataPointer < tape.Length) tape[dataPointer]--;
                        break;
                }
            }

            for (int i = 0; i < tape.Length; i++) 
            {
                outputBox.Text += tape[i];
                outputBox.Text += " | ";
            }
        }
    }
}