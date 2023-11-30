using System.Text;

namespace bf;

public partial class Brainfuck : Form
{
    const int TAPE_SIZE = 32;
    private byte[] tape = new byte[TAPE_SIZE];

    public Brainfuck()
    {
        InitializeComponent();
        runButton.Click += RunBrainfuckButton_Click;
    }

    private void Brainfuck_Load(object sender, EventArgs e)
    {
        UpdateArrayBox(tape);
        inputBox.TextChanged += InputBox_TextChanged;
    }

    private void RunBrainfuckButton_Click(object sender, EventArgs e)
    {
        string brainfuckCode = inputBox.Text;
        string output = Interpreter.RunBrainfuck(brainfuckCode);
        outputBox.Text = output;
    }

    private void InputBox_TextChanged(object sender, EventArgs e)
    {
        int dataPointer = 0;
        tape = new byte[TAPE_SIZE];

        arrayBox.Text = "";
        pointerLocationBox.Text = dataPointer.ToString();

        foreach (var command in inputBox.Text)
        {
            errorBox.Text = "";

            switch (command)
            {
                case '>':
                    if (dataPointer + 1 < tape.Length && dataPointer + 1 >= 0) dataPointer++;
                    else
                    {
                        dataPointer++;
                        errorBox.Text = (dataPointer <= 0) ? $"Data tape has been exceeded by {dataPointer}" : $"Data tape has been exceeded by {dataPointer - tape.Length + 1}";
                    }
                    break;

                case '<':
                    if (dataPointer - 1 >= 0 && dataPointer - 1 < tape.Length) dataPointer--;
                    else
                    {
                        dataPointer--;
                        errorBox.Text = (dataPointer > 0) ? $"Data tape has been exceeded by {dataPointer - tape.Length + 1}" : $"Data tape has been exceeded by {dataPointer}";
                    }
                    break;

                case '+':
                    if (dataPointer < tape.Length && dataPointer >= 0) tape[dataPointer]++;
                    else errorBox.Text = "Cannot increment value outside of byte array length";
                    break;

                case '-':
                    if (dataPointer < tape.Length && dataPointer >= 0) tape[dataPointer]--;
                    else errorBox.Text = "Cannot decrement value outside of byte array length";
                    break;

                case ',': break;
                case '[': break;
                case ']': break;

                case '.':
                    Console.Write(Convert.ToChar(tape[dataPointer]));
                    errorBox.Text = "Input required";
                    break;


                default: errorBox.Text = "Not a valid bf command character"; break;
            }

            pointerLocationBox.Text = dataPointer.ToString();
        }

        UpdateArrayBox(tape);
    }

    private void UpdateArrayBox(byte[] tape)
    {
        for (int i = 0; i < tape.Length; i++)
        {
            arrayBox.Text += $" {tape[i]} |";

            if ((i + 1) % 8 == 0 && (i + 1) % 32 != 0)
            {
                arrayBox.Text += "      ";
                arrayBox.Text += " | ";
            }

            if ((i + 1) % 32 == 0)
            {
                arrayBox.Text += "\n";
            }
        }
    }

    private void darkModeCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        Color darkBackgroundColor = Color.FromArgb(33, 37, 41);
        Color darkBoxColor = Color.FromArgb(64, 68, 75);
        Color darkTextColor = Color.White;

        Color lightBackgroundColor = Color.White;
        Color lightBoxColor = Color.FromArgb(230, 230, 230);
        Color lightTextColor = Color.Black;

        if (darkModeCheckBox.Checked)
        {


            BackColor = darkBackgroundColor;

            inputBox.BackColor = darkBoxColor;
            inputBox.ForeColor = darkTextColor;

            arrayBox.ForeColor = darkTextColor;
            arrayBox.BackColor = darkBoxColor;

            errorBox.ForeColor = darkTextColor;
            errorBox.BackColor = darkBoxColor;

            outputBox.BackColor = darkBoxColor;
            outputBox.ForeColor = darkTextColor;

            label1.ForeColor = darkTextColor;
            label2.ForeColor = darkTextColor;
            darkModeCheckBox.ForeColor = darkTextColor;

            runButton.ForeColor = darkTextColor;
            runButton.BackColor = darkBoxColor;

            programInputBox.BackColor = darkBoxColor;
            programInputBox.ForeColor = darkTextColor;
        }
        else
        {
            BackColor = lightBackgroundColor;

            inputBox.BackColor = lightBoxColor;
            inputBox.ForeColor = lightTextColor;

            arrayBox.ForeColor = lightTextColor;
            arrayBox.BackColor = lightBoxColor;


            errorBox.ForeColor = lightTextColor;
            errorBox.BackColor = lightBoxColor;

            outputBox.BackColor = lightBoxColor;
            outputBox.ForeColor = lightTextColor;

            label1.ForeColor = lightTextColor;
            label2.ForeColor = lightTextColor;
            darkModeCheckBox.ForeColor = lightTextColor;

            runButton.ForeColor = lightTextColor;
            runButton.BackColor = lightBoxColor;

            programInputBox.BackColor = lightBoxColor;
            programInputBox.ForeColor = lightTextColor;
        }
    }
}
