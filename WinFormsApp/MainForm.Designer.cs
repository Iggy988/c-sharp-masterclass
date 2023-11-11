namespace WinFormsApp;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        CounterLabel = new Label();
        button1 = new Button();
        checkBox1 = new CheckBox();
        textBox1 = new TextBox();
        SuspendLayout();
        // 
        // CounterLabel
        // 
        CounterLabel.AutoSize = true;
        CounterLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
        CounterLabel.Location = new Point(149, 115);
        CounterLabel.Name = "CounterLabel";
        CounterLabel.Size = new Size(33, 37);
        CounterLabel.TabIndex = 0;
        CounterLabel.Text = "0";
        CounterLabel.Click += CounterLabel_Click;
        // 
        // button1
        // 
        button1.Location = new Point(244, 129);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        checkBox1.Location = new Point(149, 204);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(137, 32);
        checkBox1.TabIndex = 2;
        checkBox1.Text = "Hide button";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(364, 213);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(194, 23);
        textBox1.TabIndex = 3;
        textBox1.KeyPress += textBox1_KeyPress;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(textBox1);
        Controls.Add(checkBox1);
        Controls.Add(button1);
        Controls.Add(CounterLabel);
        Name = "MainForm";
        Text = "Our first app";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label CounterLabel;
    private Button button1;
    private CheckBox checkBox1;
    private TextBox textBox1;
}
