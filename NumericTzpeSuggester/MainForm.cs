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
        ValidateMinAndMaxValues();
    }

    private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        var textBox = (TextBox)sender;
        if (!IsValidInput(e.KeyChar, textBox))
        {
            e.Handled = true;
        }
    }

    private bool IsValidInput(char keyChar, TextBox textBox)
    {
        return 
            char.IsControl(keyChar) || 
            char.IsDigit(keyChar) ||
            (keyChar == '-' && textBox.SelectionStart == 0);
    }

    private void ValidateMinAndMaxValues()
    {

    }

    private void RecalculateSuggestedType()
    {

    }


}
