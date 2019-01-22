namespace Contacts
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label ім_я_та_ФаміліяLabel;
            System.Windows.Forms.Label вікLabel;
            System.Windows.Forms.Label місце_проживанняLabel;
            System.Windows.Forms.Label номер_телефонуLabel;
            System.Windows.Forms.Label країна_праціLabel;
            System.Windows.Forms.Label документиLabel;
            System.Windows.Forms.Label постійний_клієнтLabel;
            System.Windows.Forms.Label останій_дзвінокLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contactDBDataSet = new Contacts.ContactDBDataSet();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new Contacts.ContactDBDataSetTableAdapters.PeopleTableAdapter();
            this.tableAdapterManager = new Contacts.ContactDBDataSetTableAdapters.TableAdapterManager();
            this.peopleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.peopleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ім_я_та_ФаміліяTextBox = new System.Windows.Forms.TextBox();
            this.вікTextBox = new System.Windows.Forms.TextBox();
            this.місце_проживанняTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефонуTextBox = new System.Windows.Forms.TextBox();
            this.країна_праціTextBox = new System.Windows.Forms.TextBox();
            this.документиTextBox = new System.Windows.Forms.TextBox();
            this.постійний_клієнтCheckBox = new System.Windows.Forms.CheckBox();
            this.останій_дзвінокDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idLabel = new System.Windows.Forms.Label();
            ім_я_та_ФаміліяLabel = new System.Windows.Forms.Label();
            вікLabel = new System.Windows.Forms.Label();
            місце_проживанняLabel = new System.Windows.Forms.Label();
            номер_телефонуLabel = new System.Windows.Forms.Label();
            країна_праціLabel = new System.Windows.Forms.Label();
            документиLabel = new System.Windows.Forms.Label();
            постійний_клієнтLabel = new System.Windows.Forms.Label();
            останій_дзвінокLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingNavigator)).BeginInit();
            this.peopleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 190);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // ім_я_та_ФаміліяLabel
            // 
            ім_я_та_ФаміліяLabel.AutoSize = true;
            ім_я_та_ФаміліяLabel.Location = new System.Drawing.Point(12, 216);
            ім_я_та_ФаміліяLabel.Name = "ім_я_та_ФаміліяLabel";
            ім_я_та_ФаміліяLabel.Size = new System.Drawing.Size(87, 13);
            ім_я_та_ФаміліяLabel.TabIndex = 5;
            ім_я_та_ФаміліяLabel.Text = "Ім\'я та Фамілія:";
            // 
            // вікLabel
            // 
            вікLabel.AutoSize = true;
            вікLabel.Location = new System.Drawing.Point(12, 242);
            вікLabel.Name = "вікLabel";
            вікLabel.Size = new System.Drawing.Size(25, 13);
            вікLabel.TabIndex = 7;
            вікLabel.Text = "Вік:";
            // 
            // місце_проживанняLabel
            // 
            місце_проживанняLabel.AutoSize = true;
            місце_проживанняLabel.Location = new System.Drawing.Point(12, 268);
            місце_проживанняLabel.Name = "місце_проживанняLabel";
            місце_проживанняLabel.Size = new System.Drawing.Size(104, 13);
            місце_проживанняLabel.TabIndex = 9;
            місце_проживанняLabel.Text = "Місце проживання:";
            // 
            // номер_телефонуLabel
            // 
            номер_телефонуLabel.AutoSize = true;
            номер_телефонуLabel.Location = new System.Drawing.Point(12, 294);
            номер_телефонуLabel.Name = "номер_телефонуLabel";
            номер_телефонуLabel.Size = new System.Drawing.Size(95, 13);
            номер_телефонуLabel.TabIndex = 11;
            номер_телефонуLabel.Text = "Номер телефону:";
            // 
            // країна_праціLabel
            // 
            країна_праціLabel.AutoSize = true;
            країна_праціLabel.Location = new System.Drawing.Point(12, 320);
            країна_праціLabel.Name = "країна_праціLabel";
            країна_праціLabel.Size = new System.Drawing.Size(73, 13);
            країна_праціLabel.TabIndex = 13;
            країна_праціLabel.Text = "Країна праці:";
            // 
            // документиLabel
            // 
            документиLabel.AutoSize = true;
            документиLabel.Location = new System.Drawing.Point(12, 346);
            документиLabel.Name = "документиLabel";
            документиLabel.Size = new System.Drawing.Size(67, 13);
            документиLabel.TabIndex = 15;
            документиLabel.Text = "Документи:";
            // 
            // постійний_клієнтLabel
            // 
            постійний_клієнтLabel.AutoSize = true;
            постійний_клієнтLabel.Location = new System.Drawing.Point(12, 374);
            постійний_клієнтLabel.Name = "постійний_клієнтLabel";
            постійний_клієнтLabel.Size = new System.Drawing.Size(95, 13);
            постійний_клієнтLabel.TabIndex = 17;
            постійний_клієнтLabel.Text = "Постійний клієнт:";
            // 
            // останій_дзвінокLabel
            // 
            останій_дзвінокLabel.AutoSize = true;
            останій_дзвінокLabel.Location = new System.Drawing.Point(12, 403);
            останій_дзвінокLabel.Name = "останій_дзвінокLabel";
            останій_дзвінокLabel.Size = new System.Drawing.Size(90, 13);
            останій_дзвінокLabel.TabIndex = 19;
            останій_дзвінокLabel.Text = "Останій дзвінок:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contactDBDataSet
            // 
            this.contactDBDataSet.DataSetName = "ContactDBDataSet";
            this.contactDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.contactDBDataSet;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PeopleTableAdapter = this.peopleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Contacts.ContactDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // peopleBindingNavigator
            // 
            this.peopleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.peopleBindingNavigator.BindingSource = this.peopleBindingSource;
            this.peopleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.peopleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.peopleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.peopleBindingNavigatorSaveItem});
            this.peopleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.peopleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.peopleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.peopleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.peopleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.peopleBindingNavigator.Name = "peopleBindingNavigator";
            this.peopleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.peopleBindingNavigator.Size = new System.Drawing.Size(1349, 25);
            this.peopleBindingNavigator.TabIndex = 1;
            this.peopleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // peopleBindingNavigatorSaveItem
            // 
            this.peopleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.peopleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleBindingNavigatorSaveItem.Image")));
            this.peopleBindingNavigatorSaveItem.Name = "peopleBindingNavigatorSaveItem";
            this.peopleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.peopleBindingNavigatorSaveItem.Text = "Save Data";
            this.peopleBindingNavigatorSaveItem.Click += new System.EventHandler(this.peopleBindingNavigatorSaveItem_Click);
            // 
            // peopleDataGridView
            // 
            this.peopleDataGridView.AllowUserToOrderColumns = true;
            this.peopleDataGridView.AutoGenerateColumns = false;
            this.peopleDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.peopleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn8});
            this.peopleDataGridView.DataSource = this.peopleBindingSource;
            this.peopleDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.peopleDataGridView.Location = new System.Drawing.Point(339, 28);
            this.peopleDataGridView.Name = "peopleDataGridView";
            this.peopleDataGridView.Size = new System.Drawing.Size(1000, 1000);
            this.peopleDataGridView.TabIndex = 2;
            this.peopleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.peopleDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ім\'я та Фамілія";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ім\'я та Фамілія";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Вік";
            this.dataGridViewTextBoxColumn3.HeaderText = "Вік";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Місце проживання";
            this.dataGridViewTextBoxColumn4.HeaderText = "Місце проживання";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Номер телефону";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер телефону";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Країна праці";
            this.dataGridViewTextBoxColumn6.HeaderText = "Країна праці";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Документи";
            this.dataGridViewTextBoxColumn7.HeaderText = "Документи";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Постійний клієнт";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Постійний клієнт";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Останій дзвінок";
            this.dataGridViewTextBoxColumn8.HeaderText = "Останій дзвінок";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(122, 187);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(32, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // ім_я_та_ФаміліяTextBox
            // 
            this.ім_я_та_ФаміліяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Ім\'я та Фамілія", true));
            this.ім_я_та_ФаміліяTextBox.Location = new System.Drawing.Point(122, 213);
            this.ім_я_та_ФаміліяTextBox.Name = "ім_я_та_ФаміліяTextBox";
            this.ім_я_та_ФаміліяTextBox.Size = new System.Drawing.Size(200, 20);
            this.ім_я_та_ФаміліяTextBox.TabIndex = 6;
            // 
            // вікTextBox
            // 
            this.вікTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Вік", true));
            this.вікTextBox.Location = new System.Drawing.Point(122, 239);
            this.вікTextBox.Name = "вікTextBox";
            this.вікTextBox.Size = new System.Drawing.Size(32, 20);
            this.вікTextBox.TabIndex = 8;
            // 
            // місце_проживанняTextBox
            // 
            this.місце_проживанняTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Місце проживання", true));
            this.місце_проживанняTextBox.Location = new System.Drawing.Point(122, 265);
            this.місце_проживанняTextBox.Name = "місце_проживанняTextBox";
            this.місце_проживанняTextBox.Size = new System.Drawing.Size(200, 20);
            this.місце_проживанняTextBox.TabIndex = 10;
            // 
            // номер_телефонуTextBox
            // 
            this.номер_телефонуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Номер телефону", true));
            this.номер_телефонуTextBox.Location = new System.Drawing.Point(122, 291);
            this.номер_телефонуTextBox.Name = "номер_телефонуTextBox";
            this.номер_телефонуTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_телефонуTextBox.TabIndex = 12;
            // 
            // країна_праціTextBox
            // 
            this.країна_праціTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Країна праці", true));
            this.країна_праціTextBox.Location = new System.Drawing.Point(122, 317);
            this.країна_праціTextBox.Name = "країна_праціTextBox";
            this.країна_праціTextBox.Size = new System.Drawing.Size(200, 20);
            this.країна_праціTextBox.TabIndex = 14;
            // 
            // документиTextBox
            // 
            this.документиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Документи", true));
            this.документиTextBox.Location = new System.Drawing.Point(122, 343);
            this.документиTextBox.Name = "документиTextBox";
            this.документиTextBox.Size = new System.Drawing.Size(200, 20);
            this.документиTextBox.TabIndex = 16;
            // 
            // постійний_клієнтCheckBox
            // 
            this.постійний_клієнтCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.peopleBindingSource, "Постійний клієнт", true));
            this.постійний_клієнтCheckBox.Location = new System.Drawing.Point(122, 369);
            this.постійний_клієнтCheckBox.Name = "постійний_клієнтCheckBox";
            this.постійний_клієнтCheckBox.Size = new System.Drawing.Size(200, 24);
            this.постійний_клієнтCheckBox.TabIndex = 18;
            this.постійний_клієнтCheckBox.UseVisualStyleBackColor = true;
            // 
            // останій_дзвінокDateTimePicker
            // 
            this.останій_дзвінокDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peopleBindingSource, "Останій дзвінок", true));
            this.останій_дзвінокDateTimePicker.Location = new System.Drawing.Point(122, 399);
            this.останій_дзвінокDateTimePicker.Name = "останій_дзвінокDateTimePicker";
            this.останій_дзвінокDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.останій_дзвінокDateTimePicker.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(ім_я_та_ФаміліяLabel);
            this.Controls.Add(this.ім_я_та_ФаміліяTextBox);
            this.Controls.Add(вікLabel);
            this.Controls.Add(this.вікTextBox);
            this.Controls.Add(місце_проживанняLabel);
            this.Controls.Add(this.місце_проживанняTextBox);
            this.Controls.Add(номер_телефонуLabel);
            this.Controls.Add(this.номер_телефонуTextBox);
            this.Controls.Add(країна_праціLabel);
            this.Controls.Add(this.країна_праціTextBox);
            this.Controls.Add(документиLabel);
            this.Controls.Add(this.документиTextBox);
            this.Controls.Add(постійний_клієнтLabel);
            this.Controls.Add(this.постійний_клієнтCheckBox);
            this.Controls.Add(останій_дзвінокLabel);
            this.Controls.Add(this.останій_дзвінокDateTimePicker);
            this.Controls.Add(this.peopleDataGridView);
            this.Controls.Add(this.peopleBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingNavigator)).EndInit();
            this.peopleBindingNavigator.ResumeLayout(false);
            this.peopleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ContactDBDataSet contactDBDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private ContactDBDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private ContactDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator peopleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton peopleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView peopleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox ім_я_та_ФаміліяTextBox;
        private System.Windows.Forms.TextBox вікTextBox;
        private System.Windows.Forms.TextBox місце_проживанняTextBox;
        private System.Windows.Forms.TextBox номер_телефонуTextBox;
        private System.Windows.Forms.TextBox країна_праціTextBox;
        private System.Windows.Forms.TextBox документиTextBox;
        private System.Windows.Forms.CheckBox постійний_клієнтCheckBox;
        private System.Windows.Forms.DateTimePicker останій_дзвінокDateTimePicker;
    }
}

