using System.Drawing.Printing;

namespace bf;

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
        pointerLocationBox.Text = dataPointer.ToString();

        foreach (var command in inputBox.Text)
        {
            errorBox.Text = "";

            switch (command)
            {
                case '>':
                    if (dataPointer + 1 < tape.Length && dataPointer + 1 >= 0)
                    {
                        dataPointer++;
                    }
                    else
                    {
                        if (dataPointer <= 0)
                        {
                            dataPointer++;
                            errorBox.Text = $"Data tape has been exceeded by {dataPointer}";
                        }
                        else 
                        {
                            dataPointer++;
                            errorBox.Text = $"Data tape has been exceeded by {dataPointer - tape.Length + 1}";
                        }
                    }
                    break;

                case '<':
                    if (dataPointer - 1 >= 0 && dataPointer - 1 < tape.Length)
                    {
                        dataPointer--;
                    }
                    else
                    {
                        if (dataPointer >= 0) 
                        {
                            dataPointer--;
                            errorBox.Text = $"Data tape has been exceeded by {dataPointer - tape.Length + 1}";
                        }
                        else 
                        {
                            dataPointer--;
                            errorBox.Text = $"Data tape has been exceeded by {dataPointer}";
                        }
                    }
                    break;

                case '+':
                    if (dataPointer < tape.Length && dataPointer >= 0)
                    {
                        tape[dataPointer]++;
                    }
                    else
                    {
                        errorBox.Text = "Cannot increment value outside of byte array length";
                    }

                    break;

                case '-':
                    if (dataPointer < tape.Length && dataPointer >= 0)
                    {
                        tape[dataPointer]--;
                    }
                    else
                    {
                        errorBox.Text = "Cannot decrement value outside of byte array length";
                    }
                    break;

                default:
                    errorBox.Text = "Not a valid bf command character";
                    break;
            }
            pointerLocationBox.Text = dataPointer.ToString();
        }

        for (int i = 0; i < tape.Length; i++)
        {
            outputBox.Text += tape[i];
            outputBox.Text += " | ";
        }
    }
}