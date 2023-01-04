namespace mynotepad
{
    public partial class Form1 : Form
    {
       private string path;

        public Form1()
        {
            InitializeComponent();
            path = null;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult DR =   saveFD.ShowDialog();
            if (DR == DialogResult.OK)   /// if i press save
            {
                rtx_box.SaveFile(saveFD.FileName);  
                rtx_box.Clear();
                path = null;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog()==DialogResult.OK)   // if i press open
            {
                rtx_box.LoadFile(openFD.FileName);   // load the file in the pass  
                path = openFD.FileName; 
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path ==null)
            { // save as
                saveAsToolStripMenuItem_Click(null, null);

            }
            else
            {   /// save
                rtx_box.SaveFile(path);
                rtx_box.Clear();
                path = null;
                

            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtx_box.Text !="")
            {
                DialogResult d = MessageBox.Show("are u want to save changes", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (d == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);

                }

            }

            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtx_box.Text != "")
            {
                DialogResult d = MessageBox.Show("are u want to save changes", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (d == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);

                }

            }
            path = null;
            rtx_box.Clear();

        }

        private void clearAllTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtx_box.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fontD.ShowDialog() == DialogResult.OK)
            {
                if (rtx_box.SelectedText !="")
                {
                    rtx_box.SelectionFont = fontD.Font;

                }
                else
                {
                    rtx_box.Font = fontD.Font;
                }

            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rtx_box.SelectedText !="")
                {
                    rtx_box.SelectionColor= colorD.Color;

                }
                else
                {
                    rtx_box.ForeColor= colorD.Color;
                }

            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rtx_box.SelectedText != "")
                {
                    rtx_box.SelectionBackColor = colorD.Color;

                }
                else
                {
                    rtx_box.BackColor = colorD.Color;
                }

            }

        }

        
    }
}