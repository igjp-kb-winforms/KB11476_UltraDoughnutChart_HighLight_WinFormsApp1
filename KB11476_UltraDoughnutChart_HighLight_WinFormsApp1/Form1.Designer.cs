namespace KB11476_UltraDoughnutChart_HighLight_WinFormsApp1;

partial class Form1
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
        ultraDoughnutChart1 = new Infragistics.Win.DataVisualization.UltraDoughnutChart();
        ((System.ComponentModel.ISupportInitialize)ultraDoughnutChart1).BeginInit();
        SuspendLayout();
        // 
        // ultraDoughnutChart1
        // 
        ultraDoughnutChart1.BackColor = Color.White;
        ultraDoughnutChart1.Dock = DockStyle.Fill;
        ultraDoughnutChart1.Location = new Point(0, 0);
        ultraDoughnutChart1.Name = "ultraDoughnutChart1";
        ultraDoughnutChart1.Size = new Size(800, 450);
        ultraDoughnutChart1.TabIndex = 0;
        ultraDoughnutChart1.Text = "ultraDoughnutChart1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ultraDoughnutChart1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)ultraDoughnutChart1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Infragistics.Win.DataVisualization.UltraDoughnutChart ultraDoughnutChart1;
}
