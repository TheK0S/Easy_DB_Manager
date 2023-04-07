namespace Easy_DB_Manager
{
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
            panel1 = new Panel();
            tabControl1 = new TabControl();
            connection = new TabPage();
            connectionPanel = new Panel();
            connection_DataBaseNameField = new TextBox();
            label12 = new Label();
            label11 = new Label();
            connection_IdField = new TextBox();
            label10 = new Label();
            connection_PasswordField = new TextBox();
            label7 = new Label();
            connection_ServerName = new TextBox();
            label1 = new Label();
            Create = new TabPage();
            createPanel = new Panel();
            create_labelCurrentColumns = new Label();
            create_defaultValueField = new TextBox();
            create_dataTypeRange = new NumericUpDown();
            create_dataTypes = new ComboBox();
            label25 = new Label();
            create_foreignColumnLabel = new Label();
            create_foreignColumnNameField = new TextBox();
            create_foreignTableNameField = new TextBox();
            create_foreignTableLabel = new Label();
            label2 = new Label();
            create_removeColumn = new Button();
            create_addColumn = new Button();
            create_foreignKey = new CheckBox();
            create_identity = new CheckBox();
            create_default = new CheckBox();
            create_notNull = new CheckBox();
            create_unique = new CheckBox();
            create_primaryKey = new CheckBox();
            label22 = new Label();
            create_ColumnsName = new TextBox();
            create_Table = new Button();
            create_NewDB = new Button();
            label4 = new Label();
            create_TableNameField = new TextBox();
            label3 = new Label();
            create_DateBaseNameField = new TextBox();
            read = new TabPage();
            readPanel = new Panel();
            read_labelColumnName = new Label();
            read_ColumnsNameField = new TextBox();
            read_readData = new Button();
            read_customColumns = new RadioButton();
            read_allColumns = new RadioButton();
            read_readTableList = new Button();
            read_TableNameField = new TextBox();
            label8 = new Label();
            read_NameBDField = new TextBox();
            label9 = new Label();
            add = new TabPage();
            addPanel = new Panel();
            label27 = new Label();
            add_ColumnValues = new TextBox();
            add_addEntry = new Button();
            label29 = new Label();
            add_TableNameField = new TextBox();
            add_ColumnNameField = new TextBox();
            label30 = new Label();
            add_NameBDField = new TextBox();
            label31 = new Label();
            update = new TabPage();
            updatePanel = new Panel();
            label23 = new Label();
            update_FilterColumnValueField = new TextBox();
            label21 = new Label();
            update_FilterColumnNameField = new TextBox();
            label19 = new Label();
            update_NewValueField = new TextBox();
            update_UpdateValue = new Button();
            label20 = new Label();
            update_TableNameField = new TextBox();
            update_ColumnNameField = new TextBox();
            label13 = new Label();
            update_DBNameField = new TextBox();
            label14 = new Label();
            delete = new TabPage();
            deletePanel = new Panel();
            delete_DeleteDataBase = new Button();
            delete_DeleteRows = new Button();
            label17 = new Label();
            delete_RowsValueField = new TextBox();
            label18 = new Label();
            delete_ColumnNameField = new TextBox();
            delete_DeleteTable = new Button();
            delete_TableNameField = new TextBox();
            label15 = new Label();
            delete_DBNameField = new TextBox();
            label16 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            connection.SuspendLayout();
            connectionPanel.SuspendLayout();
            Create.SuspendLayout();
            createPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)create_dataTypeRange).BeginInit();
            read.SuspendLayout();
            readPanel.SuspendLayout();
            add.SuspendLayout();
            addPanel.SuspendLayout();
            update.SuspendLayout();
            updatePanel.SuspendLayout();
            delete.SuspendLayout();
            deletePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 547);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(connection);
            tabControl1.Controls.Add(Create);
            tabControl1.Controls.Add(read);
            tabControl1.Controls.Add(add);
            tabControl1.Controls.Add(update);
            tabControl1.Controls.Add(delete);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(808, 547);
            tabControl1.TabIndex = 0;
            // 
            // connection
            // 
            connection.BackColor = SystemColors.Window;
            connection.Controls.Add(connectionPanel);
            connection.ForeColor = SystemColors.ControlText;
            connection.Location = new Point(4, 29);
            connection.Name = "connection";
            connection.Padding = new Padding(3);
            connection.Size = new Size(800, 514);
            connection.TabIndex = 0;
            connection.Text = "Подключение";
            // 
            // connectionPanel
            // 
            connectionPanel.BackColor = SystemColors.Window;
            connectionPanel.Controls.Add(connection_DataBaseNameField);
            connectionPanel.Controls.Add(label12);
            connectionPanel.Controls.Add(label11);
            connectionPanel.Controls.Add(connection_IdField);
            connectionPanel.Controls.Add(label10);
            connectionPanel.Controls.Add(connection_PasswordField);
            connectionPanel.Controls.Add(label7);
            connectionPanel.Controls.Add(connection_ServerName);
            connectionPanel.Controls.Add(label1);
            connectionPanel.Dock = DockStyle.Fill;
            connectionPanel.Location = new Point(3, 3);
            connectionPanel.Name = "connectionPanel";
            connectionPanel.Size = new Size(794, 508);
            connectionPanel.TabIndex = 2;
            // 
            // connection_DataBaseNameField
            // 
            connection_DataBaseNameField.Anchor = AnchorStyles.None;
            connection_DataBaseNameField.Location = new Point(380, 154);
            connection_DataBaseNameField.Margin = new Padding(10);
            connection_DataBaseNameField.Name = "connection_DataBaseNameField";
            connection_DataBaseNameField.Size = new Size(308, 27);
            connection_DataBaseNameField.TabIndex = 9;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(42, 161);
            label12.Margin = new Padding(10);
            label12.Name = "label12";
            label12.Size = new Size(245, 25);
            label12.TabIndex = 8;
            label12.Text = "Введите имя базы данных";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(228, 212);
            label11.Margin = new Padding(10);
            label11.Name = "label11";
            label11.Size = new Size(308, 54);
            label11.TabIndex = 7;
            label11.Text = "Для подключения с проверкой подлинности SQL Server";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // connection_IdField
            // 
            connection_IdField.Anchor = AnchorStyles.None;
            connection_IdField.Location = new Point(380, 301);
            connection_IdField.Margin = new Padding(10);
            connection_IdField.Name = "connection_IdField";
            connection_IdField.Size = new Size(308, 27);
            connection_IdField.TabIndex = 6;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(42, 306);
            label10.Margin = new Padding(10);
            label10.Name = "label10";
            label10.Size = new Size(245, 20);
            label10.TabIndex = 5;
            label10.Text = "Введите ID";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // connection_PasswordField
            // 
            connection_PasswordField.Anchor = AnchorStyles.None;
            connection_PasswordField.Location = new Point(380, 359);
            connection_PasswordField.Margin = new Padding(10);
            connection_PasswordField.Name = "connection_PasswordField";
            connection_PasswordField.Size = new Size(308, 27);
            connection_PasswordField.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(42, 365);
            label7.Margin = new Padding(10);
            label7.Name = "label7";
            label7.Size = new Size(245, 20);
            label7.TabIndex = 3;
            label7.Text = "Введите пароль";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // connection_ServerName
            // 
            connection_ServerName.Anchor = AnchorStyles.None;
            connection_ServerName.Location = new Point(380, 91);
            connection_ServerName.Margin = new Padding(10);
            connection_ServerName.Name = "connection_ServerName";
            connection_ServerName.Size = new Size(308, 27);
            connection_ServerName.TabIndex = 2;
            connection_ServerName.Text = "DESKTOP-HHO6PH0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(42, 87);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(245, 44);
            label1.TabIndex = 0;
            label1.Text = "Введите имя сервера для подключения к базе данных";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Create
            // 
            Create.BackColor = SystemColors.Window;
            Create.Controls.Add(createPanel);
            Create.ForeColor = SystemColors.ControlText;
            Create.Location = new Point(4, 29);
            Create.Name = "Create";
            Create.Padding = new Padding(3);
            Create.Size = new Size(800, 514);
            Create.TabIndex = 1;
            Create.Text = "Создать";
            // 
            // createPanel
            // 
            createPanel.AutoScroll = true;
            createPanel.AutoSize = true;
            createPanel.BackColor = SystemColors.Window;
            createPanel.Controls.Add(create_labelCurrentColumns);
            createPanel.Controls.Add(create_defaultValueField);
            createPanel.Controls.Add(create_dataTypeRange);
            createPanel.Controls.Add(create_dataTypes);
            createPanel.Controls.Add(label25);
            createPanel.Controls.Add(create_foreignColumnLabel);
            createPanel.Controls.Add(create_foreignColumnNameField);
            createPanel.Controls.Add(create_foreignTableNameField);
            createPanel.Controls.Add(create_foreignTableLabel);
            createPanel.Controls.Add(label2);
            createPanel.Controls.Add(create_removeColumn);
            createPanel.Controls.Add(create_addColumn);
            createPanel.Controls.Add(create_foreignKey);
            createPanel.Controls.Add(create_identity);
            createPanel.Controls.Add(create_default);
            createPanel.Controls.Add(create_notNull);
            createPanel.Controls.Add(create_unique);
            createPanel.Controls.Add(create_primaryKey);
            createPanel.Controls.Add(label22);
            createPanel.Controls.Add(create_ColumnsName);
            createPanel.Controls.Add(create_Table);
            createPanel.Controls.Add(create_NewDB);
            createPanel.Controls.Add(label4);
            createPanel.Controls.Add(create_TableNameField);
            createPanel.Controls.Add(label3);
            createPanel.Controls.Add(create_DateBaseNameField);
            createPanel.Dock = DockStyle.Fill;
            createPanel.ForeColor = Color.LightGray;
            createPanel.Location = new Point(3, 3);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(794, 508);
            createPanel.TabIndex = 5;
            // 
            // create_labelCurrentColumns
            // 
            create_labelCurrentColumns.Anchor = AnchorStyles.Top;
            create_labelCurrentColumns.AutoSize = true;
            create_labelCurrentColumns.ForeColor = SystemColors.ControlText;
            create_labelCurrentColumns.Location = new Point(54, 430);
            create_labelCurrentColumns.Margin = new Padding(10);
            create_labelCurrentColumns.Name = "create_labelCurrentColumns";
            create_labelCurrentColumns.Size = new Size(511, 20);
            create_labelCurrentColumns.TabIndex = 16;
            create_labelCurrentColumns.Text = "Здесь будет информация о выбранных столбцах для создания таблицы";
            // 
            // create_defaultValueField
            // 
            create_defaultValueField.ForeColor = SystemColors.ControlText;
            create_defaultValueField.Location = new Point(412, 287);
            create_defaultValueField.Margin = new Padding(10);
            create_defaultValueField.Name = "create_defaultValueField";
            create_defaultValueField.Size = new Size(100, 27);
            create_defaultValueField.TabIndex = 33;
            create_defaultValueField.Visible = false;
            // 
            // create_dataTypeRange
            // 
            create_dataTypeRange.Location = new Point(392, 360);
            create_dataTypeRange.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            create_dataTypeRange.Name = "create_dataTypeRange";
            create_dataTypeRange.Size = new Size(120, 27);
            create_dataTypeRange.TabIndex = 32;
            // 
            // create_dataTypes
            // 
            create_dataTypes.FormattingEnabled = true;
            create_dataTypes.Items.AddRange(new object[] { "NVARCHAR", "VARCHAR", "TEXT", "INT", "SMALLINT", "FLOAT", "REAL", "MONEY", "DATE", "TIME", "DATETIME", "IMAGE" });
            create_dataTypes.Location = new Point(204, 360);
            create_dataTypes.Name = "create_dataTypes";
            create_dataTypes.Size = new Size(169, 28);
            create_dataTypes.TabIndex = 31;
            // 
            // label25
            // 
            label25.ForeColor = SystemColors.ControlText;
            label25.Location = new Point(30, 363);
            label25.Margin = new Padding(10);
            label25.Name = "label25";
            label25.Size = new Size(154, 25);
            label25.TabIndex = 30;
            label25.Text = "Тип данных столбца";
            label25.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_foreignColumnLabel
            // 
            create_foreignColumnLabel.ForeColor = SystemColors.ControlText;
            create_foreignColumnLabel.Location = new Point(397, 321);
            create_foreignColumnLabel.Margin = new Padding(10);
            create_foreignColumnLabel.Name = "create_foreignColumnLabel";
            create_foreignColumnLabel.Size = new Size(130, 25);
            create_foreignColumnLabel.TabIndex = 29;
            create_foreignColumnLabel.Text = "Foreign столбец";
            create_foreignColumnLabel.TextAlign = ContentAlignment.MiddleCenter;
            create_foreignColumnLabel.Visible = false;
            // 
            // create_foreignColumnNameField
            // 
            create_foreignColumnNameField.ForeColor = SystemColors.ControlText;
            create_foreignColumnNameField.Location = new Point(547, 320);
            create_foreignColumnNameField.Margin = new Padding(10);
            create_foreignColumnNameField.Name = "create_foreignColumnNameField";
            create_foreignColumnNameField.Size = new Size(169, 27);
            create_foreignColumnNameField.TabIndex = 28;
            create_foreignColumnNameField.Visible = false;
            // 
            // create_foreignTableNameField
            // 
            create_foreignTableNameField.ForeColor = SystemColors.ControlText;
            create_foreignTableNameField.Location = new Point(204, 320);
            create_foreignTableNameField.Margin = new Padding(10);
            create_foreignTableNameField.Name = "create_foreignTableNameField";
            create_foreignTableNameField.Size = new Size(169, 27);
            create_foreignTableNameField.TabIndex = 27;
            create_foreignTableNameField.Visible = false;
            // 
            // create_foreignTableLabel
            // 
            create_foreignTableLabel.ForeColor = SystemColors.ControlText;
            create_foreignTableLabel.Location = new Point(54, 321);
            create_foreignTableLabel.Margin = new Padding(10);
            create_foreignTableLabel.Name = "create_foreignTableLabel";
            create_foreignTableLabel.Size = new Size(130, 25);
            create_foreignTableLabel.TabIndex = 26;
            create_foreignTableLabel.Text = "Foreign таблица";
            create_foreignTableLabel.TextAlign = ContentAlignment.MiddleCenter;
            create_foreignTableLabel.Visible = false;
            // 
            // label2
            // 
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(238, 146);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(245, 25);
            label2.TabIndex = 25;
            label2.Text = "Выбранные столбцы";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // create_removeColumn
            // 
            create_removeColumn.BackColor = Color.Gainsboro;
            create_removeColumn.ForeColor = SystemColors.ControlText;
            create_removeColumn.Location = new Point(563, 236);
            create_removeColumn.Margin = new Padding(10);
            create_removeColumn.Name = "create_removeColumn";
            create_removeColumn.Size = new Size(153, 32);
            create_removeColumn.TabIndex = 24;
            create_removeColumn.Text = "Удалить столбец";
            create_removeColumn.UseVisualStyleBackColor = false;
            create_removeColumn.Click += create_removeColumn_Click;
            // 
            // create_addColumn
            // 
            create_addColumn.BackColor = Color.Gainsboro;
            create_addColumn.ForeColor = SystemColors.ControlText;
            create_addColumn.Location = new Point(563, 188);
            create_addColumn.Margin = new Padding(10);
            create_addColumn.Name = "create_addColumn";
            create_addColumn.Size = new Size(153, 32);
            create_addColumn.TabIndex = 23;
            create_addColumn.Text = "Добавить столбец";
            create_addColumn.UseVisualStyleBackColor = false;
            create_addColumn.Click += create_addColumn_Click;
            // 
            // create_foreignKey
            // 
            create_foreignKey.AutoSize = true;
            create_foreignKey.ForeColor = SystemColors.ControlText;
            create_foreignKey.Location = new Point(44, 290);
            create_foreignKey.Name = "create_foreignKey";
            create_foreignKey.Size = new Size(106, 24);
            create_foreignKey.TabIndex = 22;
            create_foreignKey.Text = "Foreign Key";
            create_foreignKey.UseVisualStyleBackColor = true;
            create_foreignKey.CheckedChanged += create_foreignKey_CheckedChanged;
            // 
            // create_identity
            // 
            create_identity.AutoSize = true;
            create_identity.ForeColor = SystemColors.ControlText;
            create_identity.Location = new Point(319, 261);
            create_identity.Name = "create_identity";
            create_identity.Size = new Size(78, 24);
            create_identity.TabIndex = 21;
            create_identity.Text = "Identity";
            create_identity.UseVisualStyleBackColor = true;
            // 
            // create_default
            // 
            create_default.AutoSize = true;
            create_default.ForeColor = SystemColors.ControlText;
            create_default.Location = new Point(319, 290);
            create_default.Name = "create_default";
            create_default.Size = new Size(77, 24);
            create_default.TabIndex = 20;
            create_default.Text = "Default";
            create_default.UseVisualStyleBackColor = true;
            create_default.CheckedChanged += create_default_CheckedChanged;
            // 
            // create_notNull
            // 
            create_notNull.AutoSize = true;
            create_notNull.ForeColor = SystemColors.ControlText;
            create_notNull.Location = new Point(180, 261);
            create_notNull.Name = "create_notNull";
            create_notNull.Size = new Size(84, 24);
            create_notNull.TabIndex = 19;
            create_notNull.Text = "Not Null";
            create_notNull.UseVisualStyleBackColor = true;
            // 
            // create_unique
            // 
            create_unique.AutoSize = true;
            create_unique.ForeColor = SystemColors.ControlText;
            create_unique.Location = new Point(180, 290);
            create_unique.Name = "create_unique";
            create_unique.Size = new Size(75, 24);
            create_unique.TabIndex = 18;
            create_unique.Text = "Unique";
            create_unique.UseVisualStyleBackColor = true;
            // 
            // create_primaryKey
            // 
            create_primaryKey.AutoSize = true;
            create_primaryKey.ForeColor = SystemColors.ControlText;
            create_primaryKey.Location = new Point(44, 260);
            create_primaryKey.Name = "create_primaryKey";
            create_primaryKey.Size = new Size(106, 24);
            create_primaryKey.TabIndex = 17;
            create_primaryKey.Text = "Primary Key";
            create_primaryKey.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.ForeColor = SystemColors.ControlText;
            label22.Location = new Point(23, 192);
            label22.Margin = new Padding(10);
            label22.Name = "label22";
            label22.Size = new Size(161, 25);
            label22.TabIndex = 15;
            label22.Text = "Имя столбца";
            label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_ColumnsName
            // 
            create_ColumnsName.ForeColor = SystemColors.ControlText;
            create_ColumnsName.Location = new Point(204, 191);
            create_ColumnsName.Margin = new Padding(10);
            create_ColumnsName.Name = "create_ColumnsName";
            create_ColumnsName.Size = new Size(308, 27);
            create_ColumnsName.TabIndex = 14;
            // 
            // create_Table
            // 
            create_Table.BackColor = Color.Gainsboro;
            create_Table.ForeColor = SystemColors.ControlText;
            create_Table.Location = new Point(563, 96);
            create_Table.Margin = new Padding(10);
            create_Table.Name = "create_Table";
            create_Table.Size = new Size(153, 32);
            create_Table.TabIndex = 10;
            create_Table.Text = "Создать таблицу";
            create_Table.UseVisualStyleBackColor = false;
            create_Table.Click += create_Table_Click;
            // 
            // create_NewDB
            // 
            create_NewDB.BackColor = Color.Gainsboro;
            create_NewDB.ForeColor = SystemColors.ControlText;
            create_NewDB.Location = new Point(563, 50);
            create_NewDB.Margin = new Padding(10);
            create_NewDB.Name = "create_NewDB";
            create_NewDB.Size = new Size(153, 32);
            create_NewDB.TabIndex = 4;
            create_NewDB.Text = "Создать БД";
            create_NewDB.UseVisualStyleBackColor = false;
            create_NewDB.Click += create_NewDB_Click;
            // 
            // label4
            // 
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(23, 102);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 7;
            label4.Text = "Имя таблицы";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_TableNameField
            // 
            create_TableNameField.ForeColor = SystemColors.ControlText;
            create_TableNameField.Location = new Point(204, 99);
            create_TableNameField.Margin = new Padding(10);
            create_TableNameField.Name = "create_TableNameField";
            create_TableNameField.Size = new Size(308, 27);
            create_TableNameField.TabIndex = 6;
            // 
            // label3
            // 
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(23, 55);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 4;
            label3.Text = "Имя базы данных";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_DateBaseNameField
            // 
            create_DateBaseNameField.ForeColor = SystemColors.ControlText;
            create_DateBaseNameField.Location = new Point(204, 52);
            create_DateBaseNameField.Margin = new Padding(10);
            create_DateBaseNameField.Name = "create_DateBaseNameField";
            create_DateBaseNameField.Size = new Size(308, 27);
            create_DateBaseNameField.TabIndex = 2;
            // 
            // read
            // 
            read.Controls.Add(readPanel);
            read.Location = new Point(4, 29);
            read.Name = "read";
            read.Padding = new Padding(3);
            read.Size = new Size(800, 514);
            read.TabIndex = 2;
            read.Text = "Читать";
            read.UseVisualStyleBackColor = true;
            // 
            // readPanel
            // 
            readPanel.Controls.Add(read_labelColumnName);
            readPanel.Controls.Add(read_ColumnsNameField);
            readPanel.Controls.Add(read_readData);
            readPanel.Controls.Add(read_customColumns);
            readPanel.Controls.Add(read_allColumns);
            readPanel.Controls.Add(read_readTableList);
            readPanel.Controls.Add(read_TableNameField);
            readPanel.Controls.Add(label8);
            readPanel.Controls.Add(read_NameBDField);
            readPanel.Controls.Add(label9);
            readPanel.Dock = DockStyle.Fill;
            readPanel.Location = new Point(3, 3);
            readPanel.Name = "readPanel";
            readPanel.Size = new Size(794, 508);
            readPanel.TabIndex = 6;
            // 
            // read_labelColumnName
            // 
            read_labelColumnName.Anchor = AnchorStyles.None;
            read_labelColumnName.Location = new Point(-5, 283);
            read_labelColumnName.Margin = new Padding(10);
            read_labelColumnName.Name = "read_labelColumnName";
            read_labelColumnName.Size = new Size(301, 50);
            read_labelColumnName.TabIndex = 18;
            read_labelColumnName.Text = "Введите имена столбцов через запятую";
            read_labelColumnName.TextAlign = ContentAlignment.MiddleRight;
            read_labelColumnName.Visible = false;
            // 
            // read_ColumnsNameField
            // 
            read_ColumnsNameField.Anchor = AnchorStyles.None;
            read_ColumnsNameField.Location = new Point(314, 294);
            read_ColumnsNameField.Margin = new Padding(10);
            read_ColumnsNameField.Name = "read_ColumnsNameField";
            read_ColumnsNameField.Size = new Size(308, 27);
            read_ColumnsNameField.TabIndex = 17;
            read_ColumnsNameField.Visible = false;
            // 
            // read_readData
            // 
            read_readData.Anchor = AnchorStyles.None;
            read_readData.BackColor = Color.Gainsboro;
            read_readData.Location = new Point(336, 363);
            read_readData.Margin = new Padding(10);
            read_readData.Name = "read_readData";
            read_readData.Size = new Size(142, 32);
            read_readData.TabIndex = 15;
            read_readData.Text = "Читать данные";
            read_readData.UseVisualStyleBackColor = false;
            // 
            // read_customColumns
            // 
            read_customColumns.Anchor = AnchorStyles.None;
            read_customColumns.AutoSize = true;
            read_customColumns.Location = new Point(470, 256);
            read_customColumns.Name = "read_customColumns";
            read_customColumns.Size = new Size(150, 24);
            read_customColumns.TabIndex = 13;
            read_customColumns.Text = "Выбрать столбцы";
            read_customColumns.UseVisualStyleBackColor = true;
            // 
            // read_allColumns
            // 
            read_allColumns.Anchor = AnchorStyles.None;
            read_allColumns.AutoSize = true;
            read_allColumns.Checked = true;
            read_allColumns.Location = new Point(323, 256);
            read_allColumns.Name = "read_allColumns";
            read_allColumns.Size = new Size(114, 24);
            read_allColumns.TabIndex = 12;
            read_allColumns.TabStop = true;
            read_allColumns.Text = "Все столбцы";
            read_allColumns.UseVisualStyleBackColor = true;
            // 
            // read_readTableList
            // 
            read_readTableList.Anchor = AnchorStyles.None;
            read_readTableList.BackColor = Color.Gainsboro;
            read_readTableList.Location = new Point(314, 115);
            read_readTableList.Margin = new Padding(10);
            read_readTableList.Name = "read_readTableList";
            read_readTableList.Size = new Size(308, 32);
            read_readTableList.TabIndex = 11;
            read_readTableList.Text = "Читать список таблиц из БД";
            read_readTableList.UseVisualStyleBackColor = false;
            // 
            // read_TableNameField
            // 
            read_TableNameField.Anchor = AnchorStyles.None;
            read_TableNameField.Location = new Point(314, 201);
            read_TableNameField.Margin = new Padding(10);
            read_TableNameField.Name = "read_TableNameField";
            read_TableNameField.Size = new Size(308, 27);
            read_TableNameField.TabIndex = 4;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Location = new Point(141, 204);
            label8.Margin = new Padding(10);
            label8.Name = "label8";
            label8.Size = new Size(155, 20);
            label8.TabIndex = 3;
            label8.Text = "Имя таблицы";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // read_NameBDField
            // 
            read_NameBDField.Anchor = AnchorStyles.None;
            read_NameBDField.Location = new Point(314, 68);
            read_NameBDField.Margin = new Padding(10);
            read_NameBDField.Name = "read_NameBDField";
            read_NameBDField.Size = new Size(308, 27);
            read_NameBDField.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.Location = new Point(141, 71);
            label9.Margin = new Padding(10);
            label9.Name = "label9";
            label9.Size = new Size(155, 20);
            label9.TabIndex = 0;
            label9.Text = "Имя базы данных";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // add
            // 
            add.Controls.Add(addPanel);
            add.Location = new Point(4, 29);
            add.Name = "add";
            add.Padding = new Padding(3);
            add.Size = new Size(800, 514);
            add.TabIndex = 3;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            // 
            // addPanel
            // 
            addPanel.Controls.Add(label27);
            addPanel.Controls.Add(add_ColumnValues);
            addPanel.Controls.Add(add_addEntry);
            addPanel.Controls.Add(label29);
            addPanel.Controls.Add(add_TableNameField);
            addPanel.Controls.Add(add_ColumnNameField);
            addPanel.Controls.Add(label30);
            addPanel.Controls.Add(add_NameBDField);
            addPanel.Controls.Add(label31);
            addPanel.Dock = DockStyle.Fill;
            addPanel.Location = new Point(3, 3);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(794, 508);
            addPanel.TabIndex = 30;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.None;
            label27.Location = new Point(54, 199);
            label27.Margin = new Padding(10);
            label27.Name = "label27";
            label27.Size = new Size(238, 31);
            label27.TabIndex = 21;
            label27.Text = "Имена столбцов через запятую";
            label27.TextAlign = ContentAlignment.MiddleRight;
            // 
            // add_ColumnValues
            // 
            add_ColumnValues.Anchor = AnchorStyles.None;
            add_ColumnValues.Location = new Point(326, 274);
            add_ColumnValues.Margin = new Padding(10);
            add_ColumnValues.Name = "add_ColumnValues";
            add_ColumnValues.Size = new Size(308, 27);
            add_ColumnValues.TabIndex = 20;
            // 
            // add_addEntry
            // 
            add_addEntry.Anchor = AnchorStyles.None;
            add_addEntry.BackColor = Color.Gainsboro;
            add_addEntry.Location = new Point(238, 381);
            add_addEntry.Margin = new Padding(10);
            add_addEntry.Name = "add_addEntry";
            add_addEntry.Size = new Size(308, 32);
            add_addEntry.TabIndex = 11;
            add_addEntry.Text = "Добавить запись";
            add_addEntry.UseVisualStyleBackColor = false;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.None;
            label29.Location = new Point(-19, 264);
            label29.Margin = new Padding(10);
            label29.Name = "label29";
            label29.Size = new Size(311, 44);
            label29.TabIndex = 19;
            label29.Text = "Значения столбцов через запятую в порядке указанном  в предидущем поле";
            label29.TextAlign = ContentAlignment.MiddleRight;
            // 
            // add_TableNameField
            // 
            add_TableNameField.Anchor = AnchorStyles.None;
            add_TableNameField.Location = new Point(326, 133);
            add_TableNameField.Margin = new Padding(10);
            add_TableNameField.Name = "add_TableNameField";
            add_TableNameField.Size = new Size(308, 27);
            add_TableNameField.TabIndex = 4;
            // 
            // add_ColumnNameField
            // 
            add_ColumnNameField.Anchor = AnchorStyles.None;
            add_ColumnNameField.Location = new Point(326, 201);
            add_ColumnNameField.Margin = new Padding(10);
            add_ColumnNameField.Name = "add_ColumnNameField";
            add_ColumnNameField.Size = new Size(308, 27);
            add_ColumnNameField.TabIndex = 18;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.None;
            label30.Location = new Point(136, 136);
            label30.Margin = new Padding(10);
            label30.Name = "label30";
            label30.Size = new Size(155, 20);
            label30.TabIndex = 3;
            label30.Text = "Имя таблицы";
            label30.TextAlign = ContentAlignment.MiddleRight;
            // 
            // add_NameBDField
            // 
            add_NameBDField.Anchor = AnchorStyles.None;
            add_NameBDField.Location = new Point(326, 83);
            add_NameBDField.Margin = new Padding(10);
            add_NameBDField.Name = "add_NameBDField";
            add_NameBDField.Size = new Size(308, 27);
            add_NameBDField.TabIndex = 2;
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.None;
            label31.Location = new Point(136, 87);
            label31.Margin = new Padding(10);
            label31.Name = "label31";
            label31.Size = new Size(155, 20);
            label31.TabIndex = 0;
            label31.Text = "Имя базы данных";
            label31.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update
            // 
            update.Controls.Add(updatePanel);
            update.Location = new Point(4, 29);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(800, 514);
            update.TabIndex = 4;
            update.Text = "Изменить";
            update.UseVisualStyleBackColor = true;
            // 
            // updatePanel
            // 
            updatePanel.Controls.Add(label23);
            updatePanel.Controls.Add(update_FilterColumnValueField);
            updatePanel.Controls.Add(label21);
            updatePanel.Controls.Add(update_FilterColumnNameField);
            updatePanel.Controls.Add(label19);
            updatePanel.Controls.Add(update_NewValueField);
            updatePanel.Controls.Add(update_UpdateValue);
            updatePanel.Controls.Add(label20);
            updatePanel.Controls.Add(update_TableNameField);
            updatePanel.Controls.Add(update_ColumnNameField);
            updatePanel.Controls.Add(label13);
            updatePanel.Controls.Add(update_DBNameField);
            updatePanel.Controls.Add(label14);
            updatePanel.Dock = DockStyle.Fill;
            updatePanel.Location = new Point(3, 3);
            updatePanel.Name = "updatePanel";
            updatePanel.Size = new Size(794, 508);
            updatePanel.TabIndex = 13;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.None;
            label23.Location = new Point(86, 298);
            label23.Margin = new Padding(10);
            label23.Name = "label23";
            label23.Size = new Size(183, 20);
            label23.TabIndex = 27;
            label23.Text = "Значение для отбора";
            label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update_FilterColumnValueField
            // 
            update_FilterColumnValueField.Anchor = AnchorStyles.None;
            update_FilterColumnValueField.Location = new Point(304, 295);
            update_FilterColumnValueField.Margin = new Padding(10);
            update_FilterColumnValueField.Name = "update_FilterColumnValueField";
            update_FilterColumnValueField.Size = new Size(308, 27);
            update_FilterColumnValueField.TabIndex = 26;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.None;
            label21.Location = new Point(86, 251);
            label21.Margin = new Padding(10);
            label21.Name = "label21";
            label21.Size = new Size(183, 20);
            label21.TabIndex = 24;
            label21.Text = "Имя столбца для отбора";
            label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update_FilterColumnNameField
            // 
            update_FilterColumnNameField.Anchor = AnchorStyles.None;
            update_FilterColumnNameField.Location = new Point(304, 248);
            update_FilterColumnNameField.Margin = new Padding(10);
            update_FilterColumnNameField.Name = "update_FilterColumnNameField";
            update_FilterColumnNameField.Size = new Size(308, 27);
            update_FilterColumnNameField.TabIndex = 23;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.Location = new Point(123, 152);
            label19.Margin = new Padding(10);
            label19.Name = "label19";
            label19.Size = new Size(147, 20);
            label19.TabIndex = 21;
            label19.Text = "Имя столбца";
            label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update_NewValueField
            // 
            update_NewValueField.Anchor = AnchorStyles.None;
            update_NewValueField.Location = new Point(304, 199);
            update_NewValueField.Margin = new Padding(10);
            update_NewValueField.Name = "update_NewValueField";
            update_NewValueField.Size = new Size(308, 27);
            update_NewValueField.TabIndex = 20;
            // 
            // update_UpdateValue
            // 
            update_UpdateValue.Anchor = AnchorStyles.None;
            update_UpdateValue.BackColor = Color.Gainsboro;
            update_UpdateValue.Location = new Point(304, 359);
            update_UpdateValue.Margin = new Padding(10);
            update_UpdateValue.Name = "update_UpdateValue";
            update_UpdateValue.Size = new Size(308, 32);
            update_UpdateValue.TabIndex = 11;
            update_UpdateValue.Text = "Изменить значение";
            update_UpdateValue.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.Location = new Point(69, 197);
            label20.Margin = new Padding(10);
            label20.Name = "label20";
            label20.Size = new Size(201, 28);
            label20.TabIndex = 19;
            label20.Text = "Новое значение столбца";
            label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update_TableNameField
            // 
            update_TableNameField.Anchor = AnchorStyles.None;
            update_TableNameField.Location = new Point(304, 99);
            update_TableNameField.Margin = new Padding(10);
            update_TableNameField.Name = "update_TableNameField";
            update_TableNameField.Size = new Size(308, 27);
            update_TableNameField.TabIndex = 4;
            // 
            // update_ColumnNameField
            // 
            update_ColumnNameField.Anchor = AnchorStyles.None;
            update_ColumnNameField.Location = new Point(304, 150);
            update_ColumnNameField.Margin = new Padding(10);
            update_ColumnNameField.Name = "update_ColumnNameField";
            update_ColumnNameField.Size = new Size(308, 27);
            update_ColumnNameField.TabIndex = 18;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.Location = new Point(114, 104);
            label13.Margin = new Padding(10);
            label13.Name = "label13";
            label13.Size = new Size(155, 20);
            label13.TabIndex = 3;
            label13.Text = "Имя таблицы";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update_DBNameField
            // 
            update_DBNameField.Anchor = AnchorStyles.None;
            update_DBNameField.Location = new Point(304, 49);
            update_DBNameField.Margin = new Padding(10);
            update_DBNameField.Name = "update_DBNameField";
            update_DBNameField.Size = new Size(308, 27);
            update_DBNameField.TabIndex = 2;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.Location = new Point(114, 54);
            label14.Margin = new Padding(10);
            label14.Name = "label14";
            label14.Size = new Size(155, 20);
            label14.TabIndex = 0;
            label14.Text = "Имя базы данных";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // delete
            // 
            delete.Controls.Add(deletePanel);
            delete.Location = new Point(4, 29);
            delete.Name = "delete";
            delete.Padding = new Padding(3);
            delete.Size = new Size(800, 514);
            delete.TabIndex = 5;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            // 
            // deletePanel
            // 
            deletePanel.Controls.Add(delete_DeleteDataBase);
            deletePanel.Controls.Add(delete_DeleteRows);
            deletePanel.Controls.Add(label17);
            deletePanel.Controls.Add(delete_RowsValueField);
            deletePanel.Controls.Add(label18);
            deletePanel.Controls.Add(delete_ColumnNameField);
            deletePanel.Controls.Add(delete_DeleteTable);
            deletePanel.Controls.Add(delete_TableNameField);
            deletePanel.Controls.Add(label15);
            deletePanel.Controls.Add(delete_DBNameField);
            deletePanel.Controls.Add(label16);
            deletePanel.Dock = DockStyle.Fill;
            deletePanel.Location = new Point(3, 3);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(794, 508);
            deletePanel.TabIndex = 14;
            // 
            // delete_DeleteDataBase
            // 
            delete_DeleteDataBase.Anchor = AnchorStyles.None;
            delete_DeleteDataBase.BackColor = Color.Gainsboro;
            delete_DeleteDataBase.Location = new Point(378, 111);
            delete_DeleteDataBase.Margin = new Padding(10);
            delete_DeleteDataBase.Name = "delete_DeleteDataBase";
            delete_DeleteDataBase.Size = new Size(177, 32);
            delete_DeleteDataBase.TabIndex = 18;
            delete_DeleteDataBase.Text = "Удалить базу данных";
            delete_DeleteDataBase.UseVisualStyleBackColor = false;
            // 
            // delete_DeleteRows
            // 
            delete_DeleteRows.Anchor = AnchorStyles.None;
            delete_DeleteRows.BackColor = Color.Gainsboro;
            delete_DeleteRows.Location = new Point(378, 379);
            delete_DeleteRows.Margin = new Padding(10);
            delete_DeleteRows.Name = "delete_DeleteRows";
            delete_DeleteRows.Size = new Size(177, 32);
            delete_DeleteRows.TabIndex = 17;
            delete_DeleteRows.Text = "Удалить строки";
            delete_DeleteRows.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.Location = new Point(134, 282);
            label17.Margin = new Padding(10);
            label17.Name = "label17";
            label17.Size = new Size(147, 20);
            label17.TabIndex = 16;
            label17.Text = "Имя столбца";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // delete_RowsValueField
            // 
            delete_RowsValueField.Anchor = AnchorStyles.None;
            delete_RowsValueField.Location = new Point(315, 332);
            delete_RowsValueField.Margin = new Padding(10);
            delete_RowsValueField.Name = "delete_RowsValueField";
            delete_RowsValueField.Size = new Size(308, 27);
            delete_RowsValueField.TabIndex = 15;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.Location = new Point(73, 320);
            label18.Margin = new Padding(10);
            label18.Name = "label18";
            label18.Size = new Size(207, 47);
            label18.TabIndex = 14;
            label18.Text = "Значение столбца в строке, которую нужно удалить";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // delete_ColumnNameField
            // 
            delete_ColumnNameField.Anchor = AnchorStyles.None;
            delete_ColumnNameField.Location = new Point(315, 278);
            delete_ColumnNameField.Margin = new Padding(10);
            delete_ColumnNameField.Name = "delete_ColumnNameField";
            delete_ColumnNameField.Size = new Size(308, 27);
            delete_ColumnNameField.TabIndex = 13;
            // 
            // delete_DeleteTable
            // 
            delete_DeleteTable.Anchor = AnchorStyles.None;
            delete_DeleteTable.BackColor = Color.Gainsboro;
            delete_DeleteTable.Location = new Point(378, 215);
            delete_DeleteTable.Margin = new Padding(10);
            delete_DeleteTable.Name = "delete_DeleteTable";
            delete_DeleteTable.Size = new Size(177, 32);
            delete_DeleteTable.TabIndex = 11;
            delete_DeleteTable.Text = "Удалить таблицу";
            delete_DeleteTable.UseVisualStyleBackColor = false;
            // 
            // delete_TableNameField
            // 
            delete_TableNameField.Anchor = AnchorStyles.None;
            delete_TableNameField.Location = new Point(315, 168);
            delete_TableNameField.Margin = new Padding(10);
            delete_TableNameField.Name = "delete_TableNameField";
            delete_TableNameField.Size = new Size(308, 27);
            delete_TableNameField.TabIndex = 4;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.Location = new Point(134, 168);
            label15.Margin = new Padding(10);
            label15.Name = "label15";
            label15.Size = new Size(147, 20);
            label15.TabIndex = 3;
            label15.Text = "Имя таблицы";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // delete_DBNameField
            // 
            delete_DBNameField.Anchor = AnchorStyles.None;
            delete_DBNameField.Location = new Point(315, 64);
            delete_DBNameField.Margin = new Padding(10);
            delete_DBNameField.Name = "delete_DBNameField";
            delete_DBNameField.Size = new Size(308, 27);
            delete_DBNameField.TabIndex = 2;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.Location = new Point(122, 67);
            label16.Margin = new Padding(10);
            label16.Name = "label16";
            label16.Size = new Size(159, 20);
            label16.TabIndex = 0;
            label16.Text = "Имя базы данных";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(808, 547);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            connection.ResumeLayout(false);
            connectionPanel.ResumeLayout(false);
            connectionPanel.PerformLayout();
            Create.ResumeLayout(false);
            Create.PerformLayout();
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)create_dataTypeRange).EndInit();
            read.ResumeLayout(false);
            readPanel.ResumeLayout(false);
            readPanel.PerformLayout();
            add.ResumeLayout(false);
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            update.ResumeLayout(false);
            updatePanel.ResumeLayout(false);
            updatePanel.PerformLayout();
            delete.ResumeLayout(false);
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage connection;
        private TabPage Create;
        private TabPage read;
        private TabPage add;
        private TabPage update;
        private TabPage delete;
        private Panel connectionPanel;
        private TextBox connection_DataBaseNameField;
        private Label label12;
        private Label label11;
        private TextBox connection_IdField;
        private Label label10;
        private TextBox connection_PasswordField;
        private Label label7;
        private TextBox connection_ServerName;
        private Label label1;
        private Panel createPanel;
        private Label label22;
        private TextBox create_ColumnsName;
        private Button create_Table;
        private Button create_NewDB;
        private Label label4;
        private TextBox create_TableNameField;
        private Label label3;
        private TextBox create_DateBaseNameField;
        private Panel readPanel;
        private Label read_labelColumnName;
        private TextBox read_ColumnsNameField;
        private Button read_readData;
        private RadioButton read_customColumns;
        private RadioButton read_allColumns;
        private Button read_readTableList;
        private TextBox read_TableNameField;
        private Label label8;
        private TextBox read_NameBDField;
        private Label label9;
        private Panel addPanel;
        private Label label27;
        private TextBox add_ColumnValues;
        private Button add_addEntry;
        private Label label29;
        private TextBox add_TableNameField;
        private TextBox add_ColumnNameField;
        private Label label30;
        private TextBox add_NameBDField;
        private Label label31;
        private Panel updatePanel;
        private Label label23;
        private TextBox update_FilterColumnValueField;
        private Label label21;
        private TextBox update_FilterColumnNameField;
        private Label label19;
        private TextBox update_NewValueField;
        private Button update_UpdateValue;
        private Label label20;
        private TextBox update_TableNameField;
        private TextBox update_ColumnNameField;
        private Label label13;
        private TextBox update_DBNameField;
        private Label label14;
        private Panel deletePanel;
        private Button delete_DeleteDataBase;
        private Button delete_DeleteRows;
        private Label label17;
        private TextBox delete_RowsValueField;
        private Label label18;
        private TextBox delete_ColumnNameField;
        private Button delete_DeleteTable;
        private TextBox delete_TableNameField;
        private Label label15;
        private TextBox delete_DBNameField;
        private Label label16;
        private Button create_removeColumn;
        private Button create_addColumn;
        private CheckBox create_foreignKey;
        private CheckBox create_identity;
        private CheckBox create_notNull;
        private CheckBox create_unique;
        private CheckBox create_primaryKey;
        private Label create_labelCurrentColumns;
        private Label create_foreignColumnLabel;
        private TextBox create_foreignColumnNameField;
        private TextBox create_foreignTableNameField;
        private Label create_foreignTableLabel;
        private Label label2;
        private ComboBox create_dataTypes;
        private Label label25;
        private NumericUpDown create_dataTypeRange;
        private TextBox create_defaultValueField;
        private CheckBox create_default;
    }
}