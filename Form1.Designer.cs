namespace YourLocalHero
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label classLabel;
            System.Windows.Forms.Label alignmentLabel;
            System.Windows.Forms.Label hiring_FeeLabel;
            System.Windows.Forms.Label aboutLabel;
            System.Windows.Forms.Label strengthLabel;
            System.Windows.Forms.Label dexterityLabel;
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label intelligenceLabel;
            System.Windows.Forms.Label wisdomLabel;
            System.Windows.Forms.Label charismaLabel;
            System.Windows.Forms.Label total_ScoreLabel;
            System.Windows.Forms.Label special_TraitsLabel;
            this.ylhLogo = new System.Windows.Forms.PictureBox();
            this.heroesDataSet = new YourLocalHero.HeroesDataSet();
            this.heroesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heroesTableAdapter = new YourLocalHero.HeroesDataSetTableAdapters.heroesTableAdapter();
            this.tableAdapterManager = new YourLocalHero.HeroesDataSetTableAdapters.TableAdapterManager();
            this.heroesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.heroesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.heroesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.classLabel1 = new System.Windows.Forms.Label();
            this.alignmentLabel1 = new System.Windows.Forms.Label();
            this.hiring_FeeLabel1 = new System.Windows.Forms.Label();
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.strengthLabel1 = new System.Windows.Forms.Label();
            this.dexterityLabel1 = new System.Windows.Forms.Label();
            this.conditionLabel1 = new System.Windows.Forms.Label();
            this.intelligenceLabel1 = new System.Windows.Forms.Label();
            this.wisdomLabel1 = new System.Windows.Forms.Label();
            this.charismaLabel1 = new System.Windows.Forms.Label();
            this.total_ScoreLabel1 = new System.Windows.Forms.Label();
            this.special_TraitsLabel1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.Label();
            this.invButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
            classLabel = new System.Windows.Forms.Label();
            alignmentLabel = new System.Windows.Forms.Label();
            hiring_FeeLabel = new System.Windows.Forms.Label();
            aboutLabel = new System.Windows.Forms.Label();
            strengthLabel = new System.Windows.Forms.Label();
            dexterityLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            intelligenceLabel = new System.Windows.Forms.Label();
            wisdomLabel = new System.Windows.Forms.Label();
            charismaLabel = new System.Windows.Forms.Label();
            total_ScoreLabel = new System.Windows.Forms.Label();
            special_TraitsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ylhLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroesBindingNavigator)).BeginInit();
            this.heroesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ylhLogo
            // 
            this.ylhLogo.Image = ((System.Drawing.Image)(resources.GetObject("ylhLogo.Image")));
            this.ylhLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("ylhLogo.InitialImage")));
            this.ylhLogo.Location = new System.Drawing.Point(12, 62);
            this.ylhLogo.Name = "ylhLogo";
            this.ylhLogo.Size = new System.Drawing.Size(1523, 113);
            this.ylhLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ylhLogo.TabIndex = 0;
            this.ylhLogo.TabStop = false;
            // 
            // heroesDataSet
            // 
            this.heroesDataSet.DataSetName = "HeroesDataSet";
            this.heroesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // heroesBindingSource
            // 
            this.heroesBindingSource.DataMember = "heroes";
            this.heroesBindingSource.DataSource = this.heroesDataSet;
            // 
            // heroesTableAdapter
            // 
            this.heroesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.heroesTableAdapter = this.heroesTableAdapter;
            this.tableAdapterManager.UpdateOrder = YourLocalHero.HeroesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // heroesBindingNavigator
            // 
            this.heroesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.heroesBindingNavigator.BindingSource = this.heroesBindingSource;
            this.heroesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.heroesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.heroesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.heroesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.heroesBindingNavigatorSaveItem});
            this.heroesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.heroesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.heroesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.heroesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.heroesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.heroesBindingNavigator.Name = "heroesBindingNavigator";
            this.heroesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.heroesBindingNavigator.Size = new System.Drawing.Size(1555, 27);
            this.heroesBindingNavigator.TabIndex = 2;
            this.heroesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // heroesBindingNavigatorSaveItem
            // 
            this.heroesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.heroesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("heroesBindingNavigatorSaveItem.Image")));
            this.heroesBindingNavigatorSaveItem.Name = "heroesBindingNavigatorSaveItem";
            this.heroesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.heroesBindingNavigatorSaveItem.Text = "Save Data";
            this.heroesBindingNavigatorSaveItem.Click += new System.EventHandler(this.heroesBindingNavigatorSaveItem_Click_1);
            // 
            // heroesDataGridView
            // 
            this.heroesDataGridView.AllowUserToAddRows = false;
            this.heroesDataGridView.AllowUserToDeleteRows = false;
            this.heroesDataGridView.AllowUserToOrderColumns = true;
            this.heroesDataGridView.AutoGenerateColumns = false;
            this.heroesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.heroesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.heroesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.heroesDataGridView.DataSource = this.heroesBindingSource;
            this.heroesDataGridView.Location = new System.Drawing.Point(796, 260);
            this.heroesDataGridView.Name = "heroesDataGridView";
            this.heroesDataGridView.ReadOnly = true;
            this.heroesDataGridView.RowHeadersWidth = 51;
            this.heroesDataGridView.RowTemplate.Height = 24;
            this.heroesDataGridView.Size = new System.Drawing.Size(739, 578);
            this.heroesDataGridView.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.White;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nameLabel.Location = new System.Drawing.Point(36, 287);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 16);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameLabel1
            // 
            this.nameLabel1.BackColor = System.Drawing.Color.White;
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel1.Location = new System.Drawing.Point(132, 260);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(264, 43);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.Text = "label1";
            this.nameLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.BackColor = System.Drawing.Color.White;
            classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            classLabel.Location = new System.Drawing.Point(36, 311);
            classLabel.Name = "classLabel";
            classLabel.Size = new System.Drawing.Size(50, 16);
            classLabel.TabIndex = 6;
            classLabel.Text = "Class:";
            // 
            // classLabel1
            // 
            this.classLabel1.BackColor = System.Drawing.Color.White;
            this.classLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Class", true));
            this.classLabel1.Location = new System.Drawing.Point(135, 311);
            this.classLabel1.Name = "classLabel1";
            this.classLabel1.Size = new System.Drawing.Size(100, 23);
            this.classLabel1.TabIndex = 7;
            this.classLabel1.Text = "label1";
            // 
            // alignmentLabel
            // 
            alignmentLabel.AutoSize = true;
            alignmentLabel.BackColor = System.Drawing.Color.White;
            alignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            alignmentLabel.Location = new System.Drawing.Point(36, 334);
            alignmentLabel.Name = "alignmentLabel";
            alignmentLabel.Size = new System.Drawing.Size(79, 16);
            alignmentLabel.TabIndex = 8;
            alignmentLabel.Text = "Alignment:";
            // 
            // alignmentLabel1
            // 
            this.alignmentLabel1.BackColor = System.Drawing.Color.White;
            this.alignmentLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Alignment", true));
            this.alignmentLabel1.Location = new System.Drawing.Point(135, 334);
            this.alignmentLabel1.Name = "alignmentLabel1";
            this.alignmentLabel1.Size = new System.Drawing.Size(100, 23);
            this.alignmentLabel1.TabIndex = 9;
            this.alignmentLabel1.Text = "label1";
            // 
            // hiring_FeeLabel
            // 
            hiring_FeeLabel.AutoSize = true;
            hiring_FeeLabel.BackColor = System.Drawing.Color.White;
            hiring_FeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            hiring_FeeLabel.Location = new System.Drawing.Point(36, 357);
            hiring_FeeLabel.Name = "hiring_FeeLabel";
            hiring_FeeLabel.Size = new System.Drawing.Size(83, 16);
            hiring_FeeLabel.TabIndex = 10;
            hiring_FeeLabel.Text = "Hiring Fee:";
            // 
            // hiring_FeeLabel1
            // 
            this.hiring_FeeLabel1.BackColor = System.Drawing.Color.White;
            this.hiring_FeeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Hiring Fee", true));
            this.hiring_FeeLabel1.Location = new System.Drawing.Point(135, 357);
            this.hiring_FeeLabel1.Name = "hiring_FeeLabel1";
            this.hiring_FeeLabel1.Size = new System.Drawing.Size(100, 23);
            this.hiring_FeeLabel1.TabIndex = 11;
            this.hiring_FeeLabel1.Text = "label1";
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.BackColor = System.Drawing.Color.White;
            aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            aboutLabel.Location = new System.Drawing.Point(36, 485);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new System.Drawing.Size(51, 16);
            aboutLabel.TabIndex = 12;
            aboutLabel.Text = "About:";
            // 
            // aboutLabel1
            // 
            this.aboutLabel1.BackColor = System.Drawing.Color.White;
            this.aboutLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "About", true));
            this.aboutLabel1.Location = new System.Drawing.Point(135, 485);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(526, 333);
            this.aboutLabel1.TabIndex = 13;
            this.aboutLabel1.Text = "label1";
            // 
            // strengthLabel
            // 
            strengthLabel.AutoSize = true;
            strengthLabel.BackColor = System.Drawing.Color.White;
            strengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            strengthLabel.Location = new System.Drawing.Point(251, 311);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new System.Drawing.Size(68, 16);
            strengthLabel.TabIndex = 14;
            strengthLabel.Text = "Strength:";
            // 
            // strengthLabel1
            // 
            this.strengthLabel1.BackColor = System.Drawing.Color.White;
            this.strengthLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Strength", true));
            this.strengthLabel1.Location = new System.Drawing.Point(350, 311);
            this.strengthLabel1.Name = "strengthLabel1";
            this.strengthLabel1.Size = new System.Drawing.Size(100, 23);
            this.strengthLabel1.TabIndex = 15;
            this.strengthLabel1.Text = "label1";
            // 
            // dexterityLabel
            // 
            dexterityLabel.AutoSize = true;
            dexterityLabel.BackColor = System.Drawing.Color.White;
            dexterityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dexterityLabel.Location = new System.Drawing.Point(251, 334);
            dexterityLabel.Name = "dexterityLabel";
            dexterityLabel.Size = new System.Drawing.Size(72, 16);
            dexterityLabel.TabIndex = 16;
            dexterityLabel.Text = "Dexterity:";
            // 
            // dexterityLabel1
            // 
            this.dexterityLabel1.BackColor = System.Drawing.Color.White;
            this.dexterityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Dexterity", true));
            this.dexterityLabel1.Location = new System.Drawing.Point(350, 334);
            this.dexterityLabel1.Name = "dexterityLabel1";
            this.dexterityLabel1.Size = new System.Drawing.Size(100, 23);
            this.dexterityLabel1.TabIndex = 17;
            this.dexterityLabel1.Text = "label1";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.BackColor = System.Drawing.Color.White;
            conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            conditionLabel.Location = new System.Drawing.Point(251, 357);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(76, 16);
            conditionLabel.TabIndex = 18;
            conditionLabel.Text = "Condition:";
            // 
            // conditionLabel1
            // 
            this.conditionLabel1.BackColor = System.Drawing.Color.White;
            this.conditionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Condition", true));
            this.conditionLabel1.Location = new System.Drawing.Point(350, 357);
            this.conditionLabel1.Name = "conditionLabel1";
            this.conditionLabel1.Size = new System.Drawing.Size(100, 23);
            this.conditionLabel1.TabIndex = 19;
            this.conditionLabel1.Text = "label1";
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.BackColor = System.Drawing.Color.White;
            intelligenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            intelligenceLabel.Location = new System.Drawing.Point(251, 380);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new System.Drawing.Size(91, 16);
            intelligenceLabel.TabIndex = 20;
            intelligenceLabel.Text = "Intelligence:";
            // 
            // intelligenceLabel1
            // 
            this.intelligenceLabel1.BackColor = System.Drawing.Color.White;
            this.intelligenceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Intelligence", true));
            this.intelligenceLabel1.Location = new System.Drawing.Point(350, 380);
            this.intelligenceLabel1.Name = "intelligenceLabel1";
            this.intelligenceLabel1.Size = new System.Drawing.Size(100, 23);
            this.intelligenceLabel1.TabIndex = 21;
            this.intelligenceLabel1.Text = "label1";
            // 
            // wisdomLabel
            // 
            wisdomLabel.AutoSize = true;
            wisdomLabel.BackColor = System.Drawing.Color.White;
            wisdomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            wisdomLabel.Location = new System.Drawing.Point(251, 403);
            wisdomLabel.Name = "wisdomLabel";
            wisdomLabel.Size = new System.Drawing.Size(67, 16);
            wisdomLabel.TabIndex = 22;
            wisdomLabel.Text = "Wisdom:";
            // 
            // wisdomLabel1
            // 
            this.wisdomLabel1.BackColor = System.Drawing.Color.White;
            this.wisdomLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Wisdom", true));
            this.wisdomLabel1.Location = new System.Drawing.Point(350, 403);
            this.wisdomLabel1.Name = "wisdomLabel1";
            this.wisdomLabel1.Size = new System.Drawing.Size(100, 23);
            this.wisdomLabel1.TabIndex = 23;
            this.wisdomLabel1.Text = "label1";
            // 
            // charismaLabel
            // 
            charismaLabel.AutoSize = true;
            charismaLabel.BackColor = System.Drawing.Color.White;
            charismaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            charismaLabel.Location = new System.Drawing.Point(251, 426);
            charismaLabel.Name = "charismaLabel";
            charismaLabel.Size = new System.Drawing.Size(76, 16);
            charismaLabel.TabIndex = 24;
            charismaLabel.Text = "Charisma:";
            // 
            // charismaLabel1
            // 
            this.charismaLabel1.BackColor = System.Drawing.Color.White;
            this.charismaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Charisma", true));
            this.charismaLabel1.Location = new System.Drawing.Point(350, 426);
            this.charismaLabel1.Name = "charismaLabel1";
            this.charismaLabel1.Size = new System.Drawing.Size(100, 23);
            this.charismaLabel1.TabIndex = 25;
            this.charismaLabel1.Text = "label1";
            // 
            // total_ScoreLabel
            // 
            total_ScoreLabel.AutoSize = true;
            total_ScoreLabel.BackColor = System.Drawing.Color.White;
            total_ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            total_ScoreLabel.Location = new System.Drawing.Point(36, 380);
            total_ScoreLabel.Name = "total_ScoreLabel";
            total_ScoreLabel.Size = new System.Drawing.Size(92, 16);
            total_ScoreLabel.TabIndex = 26;
            total_ScoreLabel.Text = "Total Score:";
            // 
            // total_ScoreLabel1
            // 
            this.total_ScoreLabel1.BackColor = System.Drawing.Color.White;
            this.total_ScoreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Total Score", true));
            this.total_ScoreLabel1.Location = new System.Drawing.Point(135, 380);
            this.total_ScoreLabel1.Name = "total_ScoreLabel1";
            this.total_ScoreLabel1.Size = new System.Drawing.Size(100, 23);
            this.total_ScoreLabel1.TabIndex = 27;
            this.total_ScoreLabel1.Text = "label1";
            // 
            // special_TraitsLabel
            // 
            special_TraitsLabel.AutoSize = true;
            special_TraitsLabel.BackColor = System.Drawing.Color.White;
            special_TraitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            special_TraitsLabel.Location = new System.Drawing.Point(36, 457);
            special_TraitsLabel.Name = "special_TraitsLabel";
            special_TraitsLabel.Size = new System.Drawing.Size(51, 16);
            special_TraitsLabel.TabIndex = 28;
            special_TraitsLabel.Text = "Traits:";
            // 
            // special_TraitsLabel1
            // 
            this.special_TraitsLabel1.BackColor = System.Drawing.Color.White;
            this.special_TraitsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heroesBindingSource, "Special Traits", true));
            this.special_TraitsLabel1.Location = new System.Drawing.Point(135, 457);
            this.special_TraitsLabel1.Name = "special_TraitsLabel1";
            this.special_TraitsLabel1.Size = new System.Drawing.Size(526, 23);
            this.special_TraitsLabel1.TabIndex = 29;
            this.special_TraitsLabel1.Text = "label1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Class";
            this.dataGridViewTextBoxColumn3.HeaderText = "Class";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Alignment";
            this.dataGridViewTextBoxColumn4.HeaderText = "Alignment";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Hiring Fee";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hiring Fee";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "About";
            this.dataGridViewTextBoxColumn6.HeaderText = "About";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Strength";
            this.dataGridViewTextBoxColumn7.HeaderText = "Strength";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Dexterity";
            this.dataGridViewTextBoxColumn8.HeaderText = "Dexterity";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Condition";
            this.dataGridViewTextBoxColumn9.HeaderText = "Condition";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Intelligence";
            this.dataGridViewTextBoxColumn10.HeaderText = "Intelligence";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Wisdom";
            this.dataGridViewTextBoxColumn11.HeaderText = "Wisdom";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Charisma";
            this.dataGridViewTextBoxColumn12.HeaderText = "Charisma";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Total Score";
            this.dataGridViewTextBoxColumn13.HeaderText = "Total Score";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Special Traits";
            this.dataGridViewTextBoxColumn14.HeaderText = "Traits";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(1164, 192);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(34, 16);
            this.version.TabIndex = 30;
            this.version.Text = "v 1.0";
            // 
            // invButton
            // 
            this.invButton.BackColor = System.Drawing.SystemColors.Window;
            this.invButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.invButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.invButton.Location = new System.Drawing.Point(393, 195);
            this.invButton.Name = "invButton";
            this.invButton.Size = new System.Drawing.Size(765, 41);
            this.invButton.TabIndex = 31;
            this.invButton.Text = "Search here for a hero in our local database!";
            this.invButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invButton.UseVisualStyleBackColor = false;
            this.invButton.Click += new System.EventHandler(this.invButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchTextBox.Location = new System.Drawing.Point(393, 195);
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.searchTextBox.Size = new System.Drawing.Size(765, 41);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "rrewrweryyy";
            this.searchTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(769, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1555, 858);
            this.Controls.Add(this.invButton);
            this.Controls.Add(this.version);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(classLabel);
            this.Controls.Add(this.classLabel1);
            this.Controls.Add(alignmentLabel);
            this.Controls.Add(this.alignmentLabel1);
            this.Controls.Add(hiring_FeeLabel);
            this.Controls.Add(this.hiring_FeeLabel1);
            this.Controls.Add(aboutLabel);
            this.Controls.Add(this.aboutLabel1);
            this.Controls.Add(strengthLabel);
            this.Controls.Add(this.strengthLabel1);
            this.Controls.Add(dexterityLabel);
            this.Controls.Add(this.dexterityLabel1);
            this.Controls.Add(conditionLabel);
            this.Controls.Add(this.conditionLabel1);
            this.Controls.Add(intelligenceLabel);
            this.Controls.Add(this.intelligenceLabel1);
            this.Controls.Add(wisdomLabel);
            this.Controls.Add(this.wisdomLabel1);
            this.Controls.Add(charismaLabel);
            this.Controls.Add(this.charismaLabel1);
            this.Controls.Add(total_ScoreLabel);
            this.Controls.Add(this.total_ScoreLabel1);
            this.Controls.Add(special_TraitsLabel);
            this.Controls.Add(this.special_TraitsLabel1);
            this.Controls.Add(this.heroesDataGridView);
            this.Controls.Add(this.heroesBindingNavigator);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ylhLogo);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Your Local Hero - Hire best heroes from the Sword Coast and beyond!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ylhLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroesBindingNavigator)).EndInit();
            this.heroesBindingNavigator.ResumeLayout(false);
            this.heroesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ylhLogo;
        private HeroesDataSet heroesDataSet;
        private System.Windows.Forms.BindingSource heroesBindingSource;
        private HeroesDataSetTableAdapters.heroesTableAdapter heroesTableAdapter;
        private HeroesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator heroesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton heroesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView heroesDataGridView;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label classLabel1;
        private System.Windows.Forms.Label alignmentLabel1;
        private System.Windows.Forms.Label hiring_FeeLabel1;
        private System.Windows.Forms.Label aboutLabel1;
        private System.Windows.Forms.Label strengthLabel1;
        private System.Windows.Forms.Label dexterityLabel1;
        private System.Windows.Forms.Label conditionLabel1;
        private System.Windows.Forms.Label intelligenceLabel1;
        private System.Windows.Forms.Label wisdomLabel1;
        private System.Windows.Forms.Label charismaLabel1;
        private System.Windows.Forms.Label total_ScoreLabel1;
        private System.Windows.Forms.Label special_TraitsLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button invButton;
        private System.Windows.Forms.RichTextBox searchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

