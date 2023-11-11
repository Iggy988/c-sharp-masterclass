namespace WinFormsApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }


    private int _counter = 0;

    private void button1_Click(object sender, EventArgs e)
    {
        _counter++;
        CounterLabel.Text = _counter.ToString();
    }

    private void CounterLabel_Click(object sender, EventArgs e)
    {
        _counter--;
        CounterLabel.Text = _counter.ToString();

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        button1.Visible = !checkBox1.Checked;

        bool isChecked = checkBox1.Checked;

    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!IsValid(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private bool IsValid(char keyChar)
    {
        return char.IsControl(keyChar) ||
            (char.IsDigit(keyChar) && textBox1.Text.Length < 4);
    }
}


