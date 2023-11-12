using System.Numerics;

namespace NumericTzpeSuggester;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void IntegralsOnlyCBox_CheckedChanged(object sender, EventArgs e)
    {
        MustBePreciseCBox.Visible = !IntegralsOnlyCBox.Checked;

        RecalculateSuggestedType();
    }

    private void MustBePreciseCBox_CheckedChanged(object sender, EventArgs e)
    {
        RecalculateSuggestedType();
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        RecalculateSuggestedType();
        SetColorOfMaxValueTextField();
    }

    private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        var textBox = (TextBox)sender;
        if (!IsValidInput(e.KeyChar, textBox))
        {
            e.Handled = true;
        }
    }

    private static bool IsValidInput(char keyChar, TextBox textBox)
    {
        return 
            char.IsControl(keyChar) || 
            char.IsDigit(keyChar) ||
            (keyChar == '-' && textBox.SelectionStart == 0);
    }

    private void SetColorOfMaxValueTextField()
    {
        bool isValid = true;

        if (IsInputComplete())
        {
            var minValue = BigInteger.Parse(MinValueTB.Text);
            var maxValue = BigInteger.Parse(MaxValueTB.Text);

            if (maxValue < minValue)
            {
                isValid = false;
            }
        }

        MaxValueTB.BackColor = isValid ? Color.White : Color.IndianRed;
    }

    private bool IsInputComplete()
    {
        return 
            MinValueTB.Text.Length > 0 &&
            MinValueTB.Text != "-" &&
            MaxValueTB.Text.Length > 0 && 
            MaxValueTB.Text != "-"; 

    }

    private void RecalculateSuggestedType()
    {
        if (IsInputComplete())
        {
            var minValue = BigInteger.Parse(MinValueTB.Text);
            var maxValue = BigInteger.Parse(MaxValueTB.Text);
           
            if (maxValue >= minValue)
            { 
                ResultLabel.Text = NumericTypeSuggesterr.GetName(
                    minValue,
                    maxValue,
                    IntegralsOnlyCBox.Checked,
                    MustBePreciseCBox.Checked);
                return;
            }
        }
        ResultLabel.Text = "not enough data";
    }


}
