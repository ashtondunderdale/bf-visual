using System.Text;

namespace bf;

internal class Interpreter
{
    public static string RunBrainfuck(string code)
    {
        const int TAPE_SIZE = 30000;
        byte[] tape = new byte[TAPE_SIZE];
        int dataPointer = 0;
        int inputPointer = 0;
        StringBuilder output = new();

        for (int i = 0; i < code.Length; i++)
        {
            char command = code[i];

            switch (command)
            {
                case '>':
                    if (dataPointer + 1 < tape.Length)
                        dataPointer++;
                    break;

                case '<':
                    if (dataPointer - 1 >= 0)
                        dataPointer--;
                    break;

                case '+':
                    tape[dataPointer]++;
                    break;

                case '-':
                    tape[dataPointer]--;
                    break;

                case '.':
                    output.Append((char)tape[dataPointer]);
                    break;

                case ',':
                    if (inputPointer < Brainfuck.programInputBox.Text.Length)
                        tape[dataPointer] = (byte)Brainfuck.programInputBox.Text[inputPointer++];
                    else
                        tape[dataPointer] = 0;
                    break;

                case '[':
                    if (tape[dataPointer] == 0)
                    {
                        int loopDepth = 1;
                        while (loopDepth > 0)
                        {
                            i++;
                            if (code[i] == '[') loopDepth++;
                            else if (code[i] == ']') loopDepth--;
                        }
                    }
                    break;

                case ']':
                    if (tape[dataPointer] != 0)
                    {
                        int loopDepth = 1;
                        while (loopDepth > 0)
                        {
                            i--;
                            if (code[i] == ']') loopDepth++;
                            else if (code[i] == '[') loopDepth--;
                        }
                    }
                    break;

                default: break;
            }
        }
        return output.ToString();
    }
}
