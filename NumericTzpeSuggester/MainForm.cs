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


    private void ValidateMinAndMaxValues()
    {

    }

    private void RecalculateSuggestedType()
    {

    }

}  
