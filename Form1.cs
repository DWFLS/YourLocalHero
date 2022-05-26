using System;
using System.Windows.Forms;

namespace YourLocalHero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void heroesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.heroesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heroesDataSet);

        }

        private void heroesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.heroesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heroesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'heroesDataSet.heroes' table. You can move, or remove it, as needed.
            this.heroesTableAdapter.Fill(this.heroesDataSet.heroes);

            searchTextBox.SelectAll();
            searchTextBox.SelectionIndent += 10;//play with this values to match yours
            searchTextBox.SelectionRightIndent += 10;//this too
            searchTextBox.SelectionLength = 0;
            //this is a little hack because without this
            //i've got the first line of my richTB selected anyway.
            searchTextBox.SelectionBackColor = searchTextBox.BackColor;

        }

        private void invButton_Click(object sender, EventArgs e)
        {
            invButton.Enabled = false;
            invButton.Visible = false;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.heroesTableAdapter.FillBy(this.heroesDataSet.heroes, nAMEToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.heroesTableAdapter.FillBy1(this.heroesDataSet.heroes, nAMEToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.heroesTableAdapter.FillBy2(this.heroesDataSet.heroes, nAMEToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
