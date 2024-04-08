namespace WinformsUI.Forms;

partial class SplashForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        StatusStrip = new StatusStrip();
        ProgressBar = new ToolStripProgressBar();
        StatusLabel = new ToolStripStatusLabel();
        VersionLabel = new Label();
        StatusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // StatusStrip
        // 
        StatusStrip.Items.AddRange(new ToolStripItem[] { ProgressBar, StatusLabel });
        StatusStrip.Location = new Point(0, 428);
        StatusStrip.Name = "StatusStrip";
        StatusStrip.RenderMode = ToolStripRenderMode.Professional;
        StatusStrip.Size = new Size(800, 22);
        StatusStrip.TabIndex = 0;
        StatusStrip.Text = "statusStrip1";
        // 
        // ProgressBar
        // 
        ProgressBar.Name = "ProgressBar";
        ProgressBar.Size = new Size(100, 16);
        // 
        // StatusLabel
        // 
        StatusLabel.Name = "StatusLabel";
        StatusLabel.Size = new Size(118, 17);
        StatusLabel.Text = "toolStripStatusLabel1";
        // 
        // VersionLabel
        // 
        VersionLabel.AutoSize = true;
        VersionLabel.Location = new Point(12, 9);
        VersionLabel.Name = "VersionLabel";
        VersionLabel.Size = new Size(75, 15);
        VersionLabel.TabIndex = 1;
        VersionLabel.Text = "version: 0.0.0";
        // 
        // SplashView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(VersionLabel);
        Controls.Add(StatusStrip);
        Name = "SplashView";
        Text = "Splash";
        Load += SplashView_Load;
        StatusStrip.ResumeLayout(false);
        StatusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private StatusStrip StatusStrip;
    private ToolStripProgressBar ProgressBar;
    private ToolStripStatusLabel StatusLabel;
    private Label VersionLabel;
}
