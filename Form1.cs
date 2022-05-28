using System;
using System.Drawing;
using System.Windows.Forms;

namespace YourLocalHero
{
    public partial class Form1 : Form
    {
        private string version = "v 1.0";

        private bool firstMouseClick = true;
        private bool searchPrompt;
        private string searchTextBoxInitialMessage;

        private int[] searchHintDraw = { 0, 1, 2 };
        private int hintDraw;
        private string[] searchHintClass = { "fighter", "ranger", "thief", "mage", "cleric" };
        private string[] searchHintAlignment = { "chaotic", "lawful", "neutral", "chaotic good", "lawful evil" };
        private string[] searchHintName = { "Minsc", "Jaheira", "Khalid", "Xzar", "Edwin", "Imoen" };
        private Random randomHint = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            searchTextBoxInitialMessage = "Search our local database for a companion hero! Try by finding a '"
                                           + searchHintClass[randomHint.Next(0, searchHintClass.Length)] + "'!";

            lblVersion.Text = version;

            // initial position            
            ylhLogo.Location = new System.Drawing.Point(12, 230);
            searchPanel.Location = new System.Drawing.Point(290, 330);

            // formatting the search box
            searchTextBox.SelectAll();
            searchTextBox.SelectionIndent += 10;
            searchTextBox.SelectionRightIndent += 10;
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionBackColor = searchTextBox.BackColor;

            // initial search box message
            searchTextBox.Text = searchTextBoxInitialMessage;
            searchTextBox.ForeColor = Color.DimGray;
            MoveCursorToEnd();
            searchPrompt = true;

            // initial visibility settings
            VisibleHints(false);
            VisibleSearchResult(false);
            VisibleSearchResultNumber(false);
            VisibleTopBars(false);
        }

        //
        // SEARCH BOX
        //

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (searchPrompt)
            {
                string storedInput = null;
                storedInput = searchTextBox.Text.Remove(0, searchTextBox.Text.Length - 1);
                searchTextBox.Clear();
                searchTextBox.Text = storedInput;
                searchTextBox.ForeColor = Color.Black;
                searchTextBox.Text = searchTextBox.Text.Trim();
                MoveCursorToEnd();
                searchPrompt = false;
                firstMouseClick = false;
            }

            if (searchTextBox.Text == "--admin")
            {
                VisibleTopBars(true);
            }

            if (searchTextBox.Text == "--user")
            {
                VisibleTopBars(false);
            }
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            // clear by clicking

            if (searchPrompt && firstMouseClick)
            {
                searchTextBox.Text = " ";
                MoveCursorToEnd();
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //search query

            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true; //prevent multiline
                if (searchTextBox.Text != "" && !searchPrompt)
                {
                    try
                    {
                        this.heroesTableAdapter.SearchAdvanced(this.heroesDataSet.heroes, searchTextBox.Text);
                        VisibleSearchResultNumber(true);
                        VisibleHints(true);
                        if (heroesDataGridView.Rows.Count > 0)
                        {
                            ylhLogo.Location = new System.Drawing.Point(12, 12);
                            searchPanel.Location = new System.Drawing.Point(290, 115);
                            lblSearchResultNumber.Text = "Search results: " + heroesDataGridView.RowCount.ToString();

                            VisibleSearchResult(true);

                            hintDraw = randomHint.Next(0, searchHintDraw.Length - 1);
                            switch (hintDraw)
                            {
                                case 0:
                                    lblHints.Text = "Nice! How about looking for someone '" +
                                        searchHintAlignment[randomHint.Next(0, searchHintAlignment.Length)] + "'?";
                                    break;

                                case 1:
                                    lblHints.Text = "Awesome! Try searching for a powerful '" +
                                        searchHintClass[randomHint.Next(0, searchHintClass.Length)] + "' next time.";
                                    break;

                                case 2:
                                    lblHints.Text = "Great! Maybe hiring someone famous like '" +
                                        searchHintName[randomHint.Next(0, searchHintName.Length)] + "' would be interesting?";
                                    break;
                            }
                        }
                        else
                        {
                            VisibleSearchResult(false);
                            VisibleSearchResultNumber(false);
                            lblHints.Text = "No luck! Try using phrases describing name, class or alignment, like: '" +
                                    searchHintName[randomHint.Next(0, searchHintName.Length)] + "', '" +
                                    searchHintClass[randomHint.Next(0, searchHintClass.Length)] + "' or '" +
                                    searchHintAlignment[randomHint.Next(0, searchHintAlignment.Length)] + "'.";
                        }
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            }

            //prevent system sounds when pressing backspace or delete on empty search box

            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && (searchTextBox.Text == ""))
            {
                e.SuppressKeyPress = true;
            }

            //clear box on pressing delete or backspace

            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                    && (searchTextBox.Text == searchTextBoxInitialMessage)
                    && (searchPrompt))
            {
                e.SuppressKeyPress = true;
                searchPrompt = false;
                searchTextBox.Clear();
            }
        }

        //
        // GUI Functions
        //

        private void MoveCursorToEnd()
        {
            searchTextBox.SelectionStart = searchTextBox.Text.Length;
            searchTextBox.SelectionLength = 0;
        }
        private void VisibleSearchResult(bool b)
        {
            heroesDataGridView.Visible = b;
            heroesDataGridView.Enabled = b;
            panelResultDetails.Visible = b;
            panelResultDetails.Enabled = b;
        }

        private void VisibleSearchResultNumber(bool b)
        {
            lblSearchResultNumber.Enabled = b;
            lblSearchResultNumber.Visible = b;
        }

        private void VisibleHints(bool b)
        {
            lblHints.Visible = b;
            lblHints.Enabled = b;
        }
        private void VisibleTopBars(bool b)
        {
            searchBasicToolStrip.Visible = b;
            searchAdvancedToolStrip.Visible = b;
            heroesBindingNavigator.Visible = b;
        }

        //
        // TOP BARS
        //

        private void searchBasicToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.heroesTableAdapter.SearchBasic(this.heroesDataSet.heroes, qToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchAdvancedToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.heroesTableAdapter.SearchAdvanced(this.heroesDataSet.heroes, qToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void heroesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.heroesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heroesDataSet);

        }

        //
        // MISC
        //

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void classLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
