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
}


