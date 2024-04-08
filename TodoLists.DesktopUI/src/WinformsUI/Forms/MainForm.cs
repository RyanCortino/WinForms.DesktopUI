namespace WinformsUI.Forms;

public partial class MainForm : Form, IMainView
{
    private int _childFormNumber = 0;

    public MainForm()
    {
        InitializeComponent();
    }

    public void InitializeView() { }

    private void ShowNewForm(object sender, EventArgs e)
    {
        Form childForm = new() { MdiParent = this, Text = "Window " + _childFormNumber++ };

        childForm.Show();
    }

    private void OpenFile(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog =
            new()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

        if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        {
            _ = openFileDialog.FileName;
        }
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(
            Environment.SpecialFolder.Personal
        );
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        {
            _ = saveFileDialog.FileName;
        }
    }

    private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e) { }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e) { }

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e) { }

    private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        toolStrip.Visible = toolBarToolStripMenuItem.Checked;
    }

    private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        statusStrip.Visible = statusBarToolStripMenuItem.Checked;
    }

    private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.Cascade);
    }

    private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileVertical);
    }

    private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.ArrangeIcons);
    }

    private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
        foreach (Form childForm in MdiChildren)
        {
            childForm.Close();
        }
    }
}
