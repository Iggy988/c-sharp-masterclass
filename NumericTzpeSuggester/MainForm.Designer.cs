namespace NumericTzpeSuggester;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        MinValueTB = new TextBox();
        MaxValueTB = new TextBox();
        MinValueLabel = new Label();
        MaxValueLabel = new Label();
        IntegralsOnlyCBox = new CheckBox();
        MustBePreciseCBox = new CheckBox();
        SuggestedTypeLabel = new Label();
        ResultLabel = new Label();
        SuspendLayout();
        // 
        // MinValueTB
        // 
        MinValueTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        MinValueTB.Location = new Point(194, 80);
        MinValueTB.Name = "MinValueTB";
        MinValueTB.Size = new Size(562, 35);
        MinValueTB.TabIndex = 0;
        MinValueTB.TextChanged += TextBox_TextChanged;
        // 
        // MaxValueTB
        // 
        MaxValueTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        MaxValueTB.Location = new Point(194, 148);
        MaxValueTB.Name = "MaxValueTB";
        MaxValueTB.Size = new Size(562, 35);
        MaxValueTB.TabIndex = 0;
        MaxValueTB.TextChanged += TextBox_TextChanged;
        // 
        // MinValueLabel
        // 
        MinValueLabel.AutoSize = true;
        MinValueLabel.BackColor = Color.Transparent;
        MinValueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        MinValueLabel.Location = new Point(45, 83);
        MinValueLabel.Name = "MinValueLabel";
        MinValueLabel.Size = new Size(113, 30);
        MinValueLabel.TabIndex = 1;
        MinValueLabel.Text = "Min Value:";
        // 
        // MaxValueLabel
        // 
        MaxValueLabel.AutoSize = true;
        MaxValueLabel.BackColor = Color.Transparent;
        MaxValueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        MaxValueLabel.Location = new Point(45, 148);
        MaxValueLabel.Name = "MaxValueLabel";
        MaxValueLabel.Size = new Size(117, 30);
        MaxValueLabel.TabIndex = 1;
        MaxValueLabel.Text = "Max Value:";
        // 
        // IntegralsOnlyCBox
        // 
        IntegralsOnlyCBox.AutoSize = true;
        IntegralsOnlyCBox.BackColor = Color.Transparent;
        IntegralsOnlyCBox.CheckAlign = ContentAlignment.MiddleRight;
        IntegralsOnlyCBox.Checked = true;
        IntegralsOnlyCBox.CheckState = CheckState.Checked;
        IntegralsOnlyCBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        IntegralsOnlyCBox.ImageAlign = ContentAlignment.TopRight;
        IntegralsOnlyCBox.Location = new Point(36, 223);
        IntegralsOnlyCBox.Name = "IntegralsOnlyCBox";
        IntegralsOnlyCBox.Size = new Size(157, 34);
        IntegralsOnlyCBox.TabIndex = 2;
        IntegralsOnlyCBox.Text = "Integral only?";
        IntegralsOnlyCBox.UseVisualStyleBackColor = false;
        IntegralsOnlyCBox.CheckedChanged += IntegralsOnlyCBox_CheckedChanged;
        // 
        // MustBePreciseCBox
        // 
        MustBePreciseCBox.AutoSize = true;
        MustBePreciseCBox.BackColor = Color.Transparent;
        MustBePreciseCBox.CheckAlign = ContentAlignment.MiddleRight;
        MustBePreciseCBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        MustBePreciseCBox.ImageAlign = ContentAlignment.TopRight;
        MustBePreciseCBox.Location = new Point(36, 273);
        MustBePreciseCBox.Name = "MustBePreciseCBox";
        MustBePreciseCBox.Size = new Size(188, 34);
        MustBePreciseCBox.TabIndex = 2;
        MustBePreciseCBox.Text = "Must be precise?";
        MustBePreciseCBox.UseVisualStyleBackColor = false;
        MustBePreciseCBox.Visible = false;
        MustBePreciseCBox.CheckedChanged += MustBePreciseCBox_CheckedChanged;
        // 
        // SuggestedTypeLabel
        // 
        SuggestedTypeLabel.AutoSize = true;
        SuggestedTypeLabel.BackColor = Color.Transparent;
        SuggestedTypeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        SuggestedTypeLabel.Location = new Point(45, 330);
        SuggestedTypeLabel.Name = "SuggestedTypeLabel";
        SuggestedTypeLabel.Size = new Size(171, 30);
        SuggestedTypeLabel.TabIndex = 1;
        SuggestedTypeLabel.Text = "Suggested type:";
        // 
        // ResultLabel
        // 
        ResultLabel.AutoSize = true;
        ResultLabel.BackColor = Color.Transparent;
        ResultLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        ResultLabel.Location = new Point(213, 330);
        ResultLabel.Name = "ResultLabel";
        ResultLabel.Size = new Size(178, 30);
        ResultLabel.TabIndex = 1;
        ResultLabel.Text = "not enough data";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(800, 447);
        Controls.Add(MustBePreciseCBox);
        Controls.Add(IntegralsOnlyCBox);
        Controls.Add(ResultLabel);
        Controls.Add(SuggestedTypeLabel);
        Controls.Add(MaxValueLabel);
        Controls.Add(MinValueLabel);
        Controls.Add(MaxValueTB);
        Controls.Add(MinValueTB);
        Name = "MainForm";
        Text = "Numeric types";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox MinValueTB;
    private TextBox MaxValueTB;
    private Label MinValueLabel;
    private Label MaxValueLabel;
    private CheckBox IntegralsOnlyCBox;
    private CheckBox MustBePreciseCBox;
    private Label SuggestedTypeLabel;
    private Label ResultLabel;
}
