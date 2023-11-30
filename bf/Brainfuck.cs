using System.Text;

namespace bf;

public partial class Brainfuck : Form
{
    const int TAPE_SIZE = 32;
    private byte[] tape = new byte[TAPE_SIZE];
    int dataPointer = 0;

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
        DarkMode.darkModeCheckBox_CheckedChanged(sender, e);
        string output = Interpreter.RunBrainfuck(brainfuckCode);
        outputBox.Text = output;
    }


    private void InputBox_TextChanged(object sender, EventArgs e)
    {
        dataPointer = 0;
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

                case '.': break;
                case '[': break;
                case ']': break;

                case ',':
                    Console.Write(Convert.ToChar(tape[dataPointer]));
                    errorBox.Text = "Input required";
                    break;


                default: errorBox.Text = "Not a valid bf command character"; break;
            }

            pointerLocationBox.Text = dataPointer.ToString();

            if (dataPointer >= 0 && dataPointer < tape.Length)
            {
                dataValueBox.Text = tape[dataPointer].ToString();
            }
        }

        UpdateArrayBox(tape);
    }

    private void UpdateArrayBox(byte[] tape)
    {
        arrayBox.Text = "";

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

}
