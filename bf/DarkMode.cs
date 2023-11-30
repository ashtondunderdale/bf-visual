namespace bf;

internal class DarkMode
{
    public static void darkModeCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        Color darkBackgroundColor = Color.FromArgb(33, 37, 41);
        Color darkBoxColor = Color.FromArgb(64, 68, 75);
        Color darkTextColor = Color.White;

        Color lightBackgroundColor = Color.White;
        Color lightBoxColor = Color.FromArgb(230, 230, 230);
        Color lightTextColor = Color.Black;

        if (Brainfuck.darkModeCheckBox.Checked)
        {
            //Brainfuck.BackColor = darkBackgroundColor;

            Brainfuck.inputBox.BackColor = darkBoxColor;
            Brainfuck.inputBox.ForeColor = darkTextColor;

            Brainfuck.arrayBox.ForeColor = darkTextColor;
            Brainfuck.arrayBox.BackColor = darkBoxColor;

            Brainfuck.errorBox.ForeColor = darkTextColor;
            Brainfuck.errorBox.BackColor = darkBoxColor;

            Brainfuck.outputBox.BackColor = darkBoxColor;
            Brainfuck.outputBox.ForeColor = darkTextColor;

            Brainfuck.label1.ForeColor = darkTextColor;
            Brainfuck.label2.ForeColor = darkTextColor;
            Brainfuck.label3.ForeColor = darkTextColor;

            Brainfuck.darkModeCheckBox.ForeColor = darkTextColor;

            Brainfuck.runButton.ForeColor = darkTextColor;
            Brainfuck.runButton.BackColor = darkBoxColor;

            Brainfuck.programInputBox.BackColor = darkBoxColor;
            Brainfuck.programInputBox.ForeColor = darkTextColor;

            Brainfuck.pointerLocationBox.BackColor = darkBoxColor;
            Brainfuck.pointerLocationBox.ForeColor = darkTextColor;

            Brainfuck.dataValueBox.BackColor = darkBoxColor;
            Brainfuck.dataValueBox.ForeColor = darkTextColor;
        }
        else
        {
            //Brainfuck.BackColor = lightBackgroundColor;

            Brainfuck.inputBox.BackColor = lightBoxColor;
            Brainfuck.inputBox.ForeColor = lightTextColor;

            Brainfuck.arrayBox.ForeColor = lightTextColor;
            Brainfuck.arrayBox.BackColor = lightBoxColor;


            Brainfuck.errorBox.ForeColor = lightTextColor;
            Brainfuck.errorBox.BackColor = lightBoxColor;

            Brainfuck.outputBox.BackColor = lightBoxColor;
            Brainfuck.outputBox.ForeColor = lightTextColor;

            Brainfuck.label1.ForeColor = lightTextColor;
            Brainfuck.label2.ForeColor = lightTextColor;
            Brainfuck.label3.ForeColor = lightTextColor;

            Brainfuck.darkModeCheckBox.ForeColor = lightTextColor;

            Brainfuck.runButton.ForeColor = lightTextColor;
            Brainfuck.runButton.BackColor = lightBoxColor;

            Brainfuck.programInputBox.BackColor = lightBoxColor;
            Brainfuck.programInputBox.ForeColor = lightTextColor;

            Brainfuck.pointerLocationBox.BackColor = lightBoxColor;
            Brainfuck.pointerLocationBox.ForeColor = lightTextColor;

            Brainfuck.dataValueBox.BackColor = lightBoxColor;
            Brainfuck.dataValueBox.ForeColor = lightTextColor;
        }
    }
}
