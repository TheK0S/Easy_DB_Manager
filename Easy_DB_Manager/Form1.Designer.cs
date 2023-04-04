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
            Create = new TabPage();
            read = new TabPage();
            add = new TabPage();
            update = new TabPage();
            delete = new TabPage();
            connectionPanel = new Panel();
            connection_SuccesfullMassage = new Label();
            connection_ErrorMassage = new Label();
            connection_DataBaseNameField = new TextBox();
            label12 = new Label();
            label11 = new Label();
            connection_IdField = new TextBox();
            label10 = new Label();
            connection_PasswordField = new TextBox();
            label7 = new Label();
            connection_ServerName = new TextBox();
            label1 = new Label();
            createPanel = new Panel();
            label22 = new Label();
            create_ColumnsName = new TextBox();
            create_SuccesfullMassage = new Label();
            create_ErrorMassage = new Label();
            create_Table = new Button();
            label6 = new Label();
            create_DataBaseNameFieldFromTable = new TextBox();
            create_NewDB = new Button();
            label4 = new Label();
            create_TableNameField = new TextBox();
            label5 = new Label();
            label3 = new Label();
            create_DateBaseNameField = new TextBox();
            label2 = new Label();
            addPanel = new Panel();
            add_SuccesfullMassage = new Label();
            label27 = new Label();
            add_ErrorMassage = new Label();
            add_ColumnValues = new TextBox();
            add_addEntry = new Button();
            label29 = new Label();
            add_TableNameField = new TextBox();
            add_ColumnNameField = new TextBox();
            label30 = new Label();
            add_NameBDField = new TextBox();
            label31 = new Label();
            readPanel = new Panel();
            read_labelColumnName = new Label();
            read_ColumnsNameField = new TextBox();
            read_SuccesfullMassage = new Label();
            read_ErrorMassage = new Label();
            read_readData = new Button();
            read_customColumns = new RadioButton();
            read_allColumns = new RadioButton();
            read_readTableList = new Button();
            read_TableNameField = new TextBox();
            label8 = new Label();
            read_NameBDField = new TextBox();
            label9 = new Label();
            updatePanel = new Panel();
            label23 = new Label();
            update_FilterColumnValueField = new TextBox();
            update_SuccesfullMassage = new Label();
            label21 = new Label();
            update_FilterColumnNameField = new TextBox();
            label19 = new Label();
            update_ErrorMassage = new Label();
            update_NewValueField = new TextBox();
            update_UpdateValue = new Button();
            label20 = new Label();
            update_TableNameField = new TextBox();
            update_ColumnNameField = new TextBox();
            label13 = new Label();
            update_DBNameField = new TextBox();
            label14 = new Label();
            deletePanel = new Panel();
            delete_SuccesfullMassage = new Label();
            delete_DeleteDataBase = new Button();
            delete_ErrorMassage = new Label();
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
            Create.SuspendLayout();
            read.SuspendLayout();
            add.SuspendLayout();
            update.SuspendLayout();
            delete.SuspendLayout();
            connectionPanel.SuspendLayout();
            createPanel.SuspendLayout();
            addPanel.SuspendLayout();
            readPanel.SuspendLayout();
            updatePanel.SuspendLayout();
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
            panel1.Size = new Size(1262, 659);
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
            tabControl1.Size = new Size(1262, 659);
            tabControl1.TabIndex = 0;
            // 
            // connection
            // 
            connection.Controls.Add(connectionPanel);
            connection.Location = new Point(4, 29);
            connection.Name = "connection";
            connection.Padding = new Padding(3);
            connection.Size = new Size(1254, 626);
            connection.TabIndex = 0;
            connection.Text = "Подключение";
            connection.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            Create.Controls.Add(createPanel);
            Create.Location = new Point(4, 29);
            Create.Name = "Create";
            Create.Padding = new Padding(3);
            Create.Size = new Size(1254, 626);
            Create.TabIndex = 1;
            Create.Text = "Создать";
            Create.UseVisualStyleBackColor = true;
            // 
            // read
            // 
            read.Controls.Add(readPanel);
            read.Location = new Point(4, 29);
            read.Name = "read";
            read.Padding = new Padding(3);
            read.Size = new Size(1254, 626);
            read.TabIndex = 2;
            read.Text = "Читать";
            read.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            add.Controls.Add(addPanel);
            add.Location = new Point(4, 29);
            add.Name = "add";
            add.Padding = new Padding(3);
            add.Size = new Size(1254, 626);
            add.TabIndex = 3;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            update.Controls.Add(updatePanel);
            update.Location = new Point(4, 29);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(1254, 626);
            update.TabIndex = 4;
            update.Text = "Изменить";
            update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Controls.Add(deletePanel);
            delete.Location = new Point(4, 29);
            delete.Name = "delete";
            delete.Padding = new Padding(3);
            delete.Size = new Size(1254, 626);
            delete.TabIndex = 5;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            // 
            // connectionPanel
            // 
            connectionPanel.Controls.Add(connection_SuccesfullMassage);
            connectionPanel.Controls.Add(connection_ErrorMassage);
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
            connectionPanel.Size = new Size(1248, 620);
            connectionPanel.TabIndex = 2;
            connectionPanel.Visible = false;
            // 
            // connection_SuccesfullMassage
            // 
            connection_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            connection_SuccesfullMassage.Dock = DockStyle.Top;
            connection_SuccesfullMassage.ForeColor = Color.SeaGreen;
            connection_SuccesfullMassage.Location = new Point(0, 0);
            connection_SuccesfullMassage.Name = "connection_SuccesfullMassage";
            connection_SuccesfullMassage.Size = new Size(1248, 23);
            connection_SuccesfullMassage.TabIndex = 12;
            connection_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            connection_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            connection_SuccesfullMassage.Visible = false;
            // 
            // connection_ErrorMassage
            // 
            connection_ErrorMassage.BackColor = Color.LavenderBlush;
            connection_ErrorMassage.Dock = DockStyle.Bottom;
            connection_ErrorMassage.ForeColor = Color.Red;
            connection_ErrorMassage.Location = new Point(0, 577);
            connection_ErrorMassage.Name = "connection_ErrorMassage";
            connection_ErrorMassage.Size = new Size(1248, 43);
            connection_ErrorMassage.TabIndex = 11;
            connection_ErrorMassage.Text = "Error";
            connection_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            connection_ErrorMassage.Visible = false;
            // 
            // connection_DataBaseNameField
            // 
            connection_DataBaseNameField.Anchor = AnchorStyles.None;
            connection_DataBaseNameField.Location = new Point(607, 210);
            connection_DataBaseNameField.Margin = new Padding(10);
            connection_DataBaseNameField.Name = "connection_DataBaseNameField";
            connection_DataBaseNameField.Size = new Size(308, 27);
            connection_DataBaseNameField.TabIndex = 9;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.Location = new Point(269, 217);
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
            label11.Location = new Point(455, 268);
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
            connection_IdField.Location = new Point(607, 357);
            connection_IdField.Margin = new Padding(10);
            connection_IdField.Name = "connection_IdField";
            connection_IdField.Size = new Size(308, 27);
            connection_IdField.TabIndex = 6;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.Location = new Point(269, 362);
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
            connection_PasswordField.Location = new Point(607, 415);
            connection_PasswordField.Margin = new Padding(10);
            connection_PasswordField.Name = "connection_PasswordField";
            connection_PasswordField.Size = new Size(308, 27);
            connection_PasswordField.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Location = new Point(269, 421);
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
            connection_ServerName.Location = new Point(607, 147);
            connection_ServerName.Margin = new Padding(10);
            connection_ServerName.Name = "connection_ServerName";
            connection_ServerName.Size = new Size(308, 27);
            connection_ServerName.TabIndex = 2;
            connection_ServerName.Text = "DESKTOP-HHO6PH0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(269, 143);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(245, 44);
            label1.TabIndex = 0;
            label1.Text = "Введите имя сервера для подключения к базе данных";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createPanel
            // 
            createPanel.Controls.Add(label22);
            createPanel.Controls.Add(create_ColumnsName);
            createPanel.Controls.Add(create_SuccesfullMassage);
            createPanel.Controls.Add(create_ErrorMassage);
            createPanel.Controls.Add(create_Table);
            createPanel.Controls.Add(label6);
            createPanel.Controls.Add(create_DataBaseNameFieldFromTable);
            createPanel.Controls.Add(create_NewDB);
            createPanel.Controls.Add(label4);
            createPanel.Controls.Add(create_TableNameField);
            createPanel.Controls.Add(label5);
            createPanel.Controls.Add(label3);
            createPanel.Controls.Add(create_DateBaseNameField);
            createPanel.Controls.Add(label2);
            createPanel.Dock = DockStyle.Fill;
            createPanel.Location = new Point(3, 3);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(1248, 620);
            createPanel.TabIndex = 5;
            createPanel.Visible = false;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.None;
            label22.Location = new Point(255, 408);
            label22.Margin = new Padding(10);
            label22.Name = "label22";
            label22.Size = new Size(288, 56);
            label22.TabIndex = 15;
            label22.Text = "Введи имена столбцов и их параметры разделяя столбцы запятой";
            label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_ColumnsName
            // 
            create_ColumnsName.Anchor = AnchorStyles.None;
            create_ColumnsName.Location = new Point(563, 422);
            create_ColumnsName.Margin = new Padding(10);
            create_ColumnsName.Name = "create_ColumnsName";
            create_ColumnsName.Size = new Size(308, 27);
            create_ColumnsName.TabIndex = 14;
            // 
            // create_SuccesfullMassage
            // 
            create_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            create_SuccesfullMassage.Dock = DockStyle.Top;
            create_SuccesfullMassage.ForeColor = Color.SeaGreen;
            create_SuccesfullMassage.Location = new Point(0, 0);
            create_SuccesfullMassage.Name = "create_SuccesfullMassage";
            create_SuccesfullMassage.Size = new Size(1248, 23);
            create_SuccesfullMassage.TabIndex = 13;
            create_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            create_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            create_SuccesfullMassage.Visible = false;
            // 
            // create_ErrorMassage
            // 
            create_ErrorMassage.BackColor = Color.LavenderBlush;
            create_ErrorMassage.Dock = DockStyle.Bottom;
            create_ErrorMassage.ForeColor = Color.Red;
            create_ErrorMassage.Location = new Point(0, 577);
            create_ErrorMassage.Name = "create_ErrorMassage";
            create_ErrorMassage.Size = new Size(1248, 43);
            create_ErrorMassage.TabIndex = 12;
            create_ErrorMassage.Text = "Error";
            create_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            create_ErrorMassage.Visible = false;
            // 
            // create_Table
            // 
            create_Table.Anchor = AnchorStyles.None;
            create_Table.BackColor = Color.Gainsboro;
            create_Table.Location = new Point(638, 469);
            create_Table.Margin = new Padding(10);
            create_Table.Name = "create_Table";
            create_Table.Size = new Size(153, 32);
            create_Table.TabIndex = 10;
            create_Table.Text = "Создать таблицу";
            create_Table.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Location = new Point(382, 327);
            label6.Margin = new Padding(10);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 9;
            label6.Text = "Имя базы данных";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_DataBaseNameFieldFromTable
            // 
            create_DataBaseNameFieldFromTable.Anchor = AnchorStyles.None;
            create_DataBaseNameFieldFromTable.Location = new Point(563, 324);
            create_DataBaseNameFieldFromTable.Margin = new Padding(10);
            create_DataBaseNameFieldFromTable.Name = "create_DataBaseNameFieldFromTable";
            create_DataBaseNameFieldFromTable.Size = new Size(308, 27);
            create_DataBaseNameFieldFromTable.TabIndex = 8;
            // 
            // create_NewDB
            // 
            create_NewDB.Anchor = AnchorStyles.None;
            create_NewDB.BackColor = Color.Gainsboro;
            create_NewDB.Location = new Point(638, 194);
            create_NewDB.Margin = new Padding(10);
            create_NewDB.Name = "create_NewDB";
            create_NewDB.Size = new Size(153, 32);
            create_NewDB.TabIndex = 4;
            create_NewDB.Text = "Создать БД";
            create_NewDB.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Location = new Point(382, 378);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 7;
            label4.Text = "Имя таблицы";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_TableNameField
            // 
            create_TableNameField.Anchor = AnchorStyles.None;
            create_TableNameField.Location = new Point(563, 375);
            create_TableNameField.Margin = new Padding(10);
            create_TableNameField.Name = "create_TableNameField";
            create_TableNameField.Size = new Size(308, 27);
            create_TableNameField.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(561, 267);
            label5.Margin = new Padding(10);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 5;
            label5.Text = "Создать таблицу";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Location = new Point(382, 150);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 4;
            label3.Text = "Имя базы данных";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // create_DateBaseNameField
            // 
            create_DateBaseNameField.Anchor = AnchorStyles.None;
            create_DateBaseNameField.Location = new Point(563, 147);
            create_DateBaseNameField.Margin = new Padding(10);
            create_DateBaseNameField.Name = "create_DateBaseNameField";
            create_DateBaseNameField.Size = new Size(308, 27);
            create_DateBaseNameField.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(544, 85);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 0;
            label2.Text = "Создать базу данных";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addPanel
            // 
            addPanel.Controls.Add(add_SuccesfullMassage);
            addPanel.Controls.Add(label27);
            addPanel.Controls.Add(add_ErrorMassage);
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
            addPanel.Size = new Size(1248, 620);
            addPanel.TabIndex = 30;
            addPanel.Visible = false;
            // 
            // add_SuccesfullMassage
            // 
            add_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            add_SuccesfullMassage.Dock = DockStyle.Top;
            add_SuccesfullMassage.ForeColor = Color.SeaGreen;
            add_SuccesfullMassage.Location = new Point(0, 0);
            add_SuccesfullMassage.Name = "add_SuccesfullMassage";
            add_SuccesfullMassage.Size = new Size(1248, 23);
            add_SuccesfullMassage.TabIndex = 25;
            add_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            add_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            add_SuccesfullMassage.Visible = false;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.None;
            label27.Location = new Point(281, 255);
            label27.Margin = new Padding(10);
            label27.Name = "label27";
            label27.Size = new Size(238, 31);
            label27.TabIndex = 21;
            label27.Text = "Имена столбцов через запятую";
            label27.TextAlign = ContentAlignment.MiddleRight;
            // 
            // add_ErrorMassage
            // 
            add_ErrorMassage.BackColor = Color.LavenderBlush;
            add_ErrorMassage.Dock = DockStyle.Bottom;
            add_ErrorMassage.ForeColor = Color.Red;
            add_ErrorMassage.Location = new Point(0, 577);
            add_ErrorMassage.Name = "add_ErrorMassage";
            add_ErrorMassage.Size = new Size(1248, 43);
            add_ErrorMassage.TabIndex = 16;
            add_ErrorMassage.Text = "Error";
            add_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            add_ErrorMassage.Visible = false;
            // 
            // add_ColumnValues
            // 
            add_ColumnValues.Anchor = AnchorStyles.None;
            add_ColumnValues.Location = new Point(553, 330);
            add_ColumnValues.Margin = new Padding(10);
            add_ColumnValues.Name = "add_ColumnValues";
            add_ColumnValues.Size = new Size(308, 27);
            add_ColumnValues.TabIndex = 20;
            // 
            // add_addEntry
            // 
            add_addEntry.Anchor = AnchorStyles.None;
            add_addEntry.BackColor = Color.Gainsboro;
            add_addEntry.Location = new Point(465, 437);
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
            label29.Location = new Point(208, 320);
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
            add_TableNameField.Location = new Point(553, 189);
            add_TableNameField.Margin = new Padding(10);
            add_TableNameField.Name = "add_TableNameField";
            add_TableNameField.Size = new Size(308, 27);
            add_TableNameField.TabIndex = 4;
            // 
            // add_ColumnNameField
            // 
            add_ColumnNameField.Anchor = AnchorStyles.None;
            add_ColumnNameField.Location = new Point(553, 257);
            add_ColumnNameField.Margin = new Padding(10);
            add_ColumnNameField.Name = "add_ColumnNameField";
            add_ColumnNameField.Size = new Size(308, 27);
            add_ColumnNameField.TabIndex = 18;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.None;
            label30.Location = new Point(363, 192);
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
            add_NameBDField.Location = new Point(553, 139);
            add_NameBDField.Margin = new Padding(10);
            add_NameBDField.Name = "add_NameBDField";
            add_NameBDField.Size = new Size(308, 27);
            add_NameBDField.TabIndex = 2;
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.None;
            label31.Location = new Point(363, 143);
            label31.Margin = new Padding(10);
            label31.Name = "label31";
            label31.Size = new Size(155, 20);
            label31.TabIndex = 0;
            label31.Text = "Имя базы данных";
            label31.TextAlign = ContentAlignment.MiddleRight;
            // 
            // readPanel
            // 
            readPanel.Controls.Add(read_labelColumnName);
            readPanel.Controls.Add(read_ColumnsNameField);
            readPanel.Controls.Add(read_SuccesfullMassage);
            readPanel.Controls.Add(read_ErrorMassage);
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
            readPanel.Size = new Size(1248, 620);
            readPanel.TabIndex = 6;
            readPanel.Visible = false;
            // 
            // read_labelColumnName
            // 
            read_labelColumnName.Anchor = AnchorStyles.None;
            read_labelColumnName.Location = new Point(215, 339);
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
            read_ColumnsNameField.Location = new Point(534, 350);
            read_ColumnsNameField.Margin = new Padding(10);
            read_ColumnsNameField.Name = "read_ColumnsNameField";
            read_ColumnsNameField.Size = new Size(308, 27);
            read_ColumnsNameField.TabIndex = 17;
            read_ColumnsNameField.Visible = false;
            // 
            // read_SuccesfullMassage
            // 
            read_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            read_SuccesfullMassage.Dock = DockStyle.Top;
            read_SuccesfullMassage.ForeColor = Color.SeaGreen;
            read_SuccesfullMassage.Location = new Point(0, 0);
            read_SuccesfullMassage.Name = "read_SuccesfullMassage";
            read_SuccesfullMassage.Size = new Size(1248, 23);
            read_SuccesfullMassage.TabIndex = 16;
            read_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            read_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            read_SuccesfullMassage.Visible = false;
            // 
            // read_ErrorMassage
            // 
            read_ErrorMassage.BackColor = Color.LavenderBlush;
            read_ErrorMassage.Dock = DockStyle.Bottom;
            read_ErrorMassage.ForeColor = Color.Red;
            read_ErrorMassage.Location = new Point(0, 577);
            read_ErrorMassage.Name = "read_ErrorMassage";
            read_ErrorMassage.Size = new Size(1248, 43);
            read_ErrorMassage.TabIndex = 13;
            read_ErrorMassage.Text = "Error";
            read_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            read_ErrorMassage.Visible = false;
            // 
            // read_readData
            // 
            read_readData.Anchor = AnchorStyles.None;
            read_readData.BackColor = Color.Gainsboro;
            read_readData.Location = new Point(556, 419);
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
            read_customColumns.Location = new Point(690, 312);
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
            read_allColumns.Location = new Point(543, 312);
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
            read_readTableList.Location = new Point(534, 171);
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
            read_TableNameField.Location = new Point(534, 257);
            read_TableNameField.Margin = new Padding(10);
            read_TableNameField.Name = "read_TableNameField";
            read_TableNameField.Size = new Size(308, 27);
            read_TableNameField.TabIndex = 4;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Location = new Point(361, 260);
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
            read_NameBDField.Location = new Point(534, 124);
            read_NameBDField.Margin = new Padding(10);
            read_NameBDField.Name = "read_NameBDField";
            read_NameBDField.Size = new Size(308, 27);
            read_NameBDField.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.Location = new Point(361, 127);
            label9.Margin = new Padding(10);
            label9.Name = "label9";
            label9.Size = new Size(155, 20);
            label9.TabIndex = 0;
            label9.Text = "Имя базы данных";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updatePanel
            // 
            updatePanel.Controls.Add(label23);
            updatePanel.Controls.Add(update_FilterColumnValueField);
            updatePanel.Controls.Add(update_SuccesfullMassage);
            updatePanel.Controls.Add(label21);
            updatePanel.Controls.Add(update_FilterColumnNameField);
            updatePanel.Controls.Add(label19);
            updatePanel.Controls.Add(update_ErrorMassage);
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
            updatePanel.Size = new Size(1248, 620);
            updatePanel.TabIndex = 13;
            updatePanel.Visible = false;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.None;
            label23.Location = new Point(283, 382);
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
            update_FilterColumnValueField.Location = new Point(501, 379);
            update_FilterColumnValueField.Margin = new Padding(10);
            update_FilterColumnValueField.Name = "update_FilterColumnValueField";
            update_FilterColumnValueField.Size = new Size(308, 27);
            update_FilterColumnValueField.TabIndex = 26;
            // 
            // update_SuccesfullMassage
            // 
            update_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            update_SuccesfullMassage.Dock = DockStyle.Top;
            update_SuccesfullMassage.ForeColor = Color.SeaGreen;
            update_SuccesfullMassage.Location = new Point(0, 0);
            update_SuccesfullMassage.Name = "update_SuccesfullMassage";
            update_SuccesfullMassage.Size = new Size(1248, 23);
            update_SuccesfullMassage.TabIndex = 25;
            update_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            update_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            update_SuccesfullMassage.Visible = false;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.None;
            label21.Location = new Point(283, 335);
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
            update_FilterColumnNameField.Location = new Point(501, 332);
            update_FilterColumnNameField.Margin = new Padding(10);
            update_FilterColumnNameField.Name = "update_FilterColumnNameField";
            update_FilterColumnNameField.Size = new Size(308, 27);
            update_FilterColumnNameField.TabIndex = 23;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.Location = new Point(320, 236);
            label19.Margin = new Padding(10);
            label19.Name = "label19";
            label19.Size = new Size(147, 20);
            label19.TabIndex = 21;
            label19.Text = "Имя столбца";
            label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // update_ErrorMassage
            // 
            update_ErrorMassage.BackColor = Color.LavenderBlush;
            update_ErrorMassage.Dock = DockStyle.Bottom;
            update_ErrorMassage.ForeColor = Color.Red;
            update_ErrorMassage.Location = new Point(0, 577);
            update_ErrorMassage.Name = "update_ErrorMassage";
            update_ErrorMassage.Size = new Size(1248, 43);
            update_ErrorMassage.TabIndex = 16;
            update_ErrorMassage.Text = "Error";
            update_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            update_ErrorMassage.Visible = false;
            // 
            // update_NewValueField
            // 
            update_NewValueField.Anchor = AnchorStyles.None;
            update_NewValueField.Location = new Point(501, 283);
            update_NewValueField.Margin = new Padding(10);
            update_NewValueField.Name = "update_NewValueField";
            update_NewValueField.Size = new Size(308, 27);
            update_NewValueField.TabIndex = 20;
            // 
            // update_UpdateValue
            // 
            update_UpdateValue.Anchor = AnchorStyles.None;
            update_UpdateValue.BackColor = Color.Gainsboro;
            update_UpdateValue.Location = new Point(501, 443);
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
            label20.Location = new Point(266, 281);
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
            update_TableNameField.Location = new Point(501, 183);
            update_TableNameField.Margin = new Padding(10);
            update_TableNameField.Name = "update_TableNameField";
            update_TableNameField.Size = new Size(308, 27);
            update_TableNameField.TabIndex = 4;
            // 
            // update_ColumnNameField
            // 
            update_ColumnNameField.Anchor = AnchorStyles.None;
            update_ColumnNameField.Location = new Point(501, 234);
            update_ColumnNameField.Margin = new Padding(10);
            update_ColumnNameField.Name = "update_ColumnNameField";
            update_ColumnNameField.Size = new Size(308, 27);
            update_ColumnNameField.TabIndex = 18;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.Location = new Point(311, 188);
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
            update_DBNameField.Location = new Point(501, 133);
            update_DBNameField.Margin = new Padding(10);
            update_DBNameField.Name = "update_DBNameField";
            update_DBNameField.Size = new Size(308, 27);
            update_DBNameField.TabIndex = 2;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.Location = new Point(311, 138);
            label14.Margin = new Padding(10);
            label14.Name = "label14";
            label14.Size = new Size(155, 20);
            label14.TabIndex = 0;
            label14.Text = "Имя базы данных";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deletePanel
            // 
            deletePanel.Controls.Add(delete_SuccesfullMassage);
            deletePanel.Controls.Add(delete_DeleteDataBase);
            deletePanel.Controls.Add(delete_ErrorMassage);
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
            deletePanel.Size = new Size(1248, 620);
            deletePanel.TabIndex = 14;
            deletePanel.Visible = false;
            // 
            // delete_SuccesfullMassage
            // 
            delete_SuccesfullMassage.BackColor = Color.FromArgb(192, 255, 192);
            delete_SuccesfullMassage.Dock = DockStyle.Top;
            delete_SuccesfullMassage.ForeColor = Color.SeaGreen;
            delete_SuccesfullMassage.Location = new Point(0, 0);
            delete_SuccesfullMassage.Name = "delete_SuccesfullMassage";
            delete_SuccesfullMassage.Size = new Size(1248, 23);
            delete_SuccesfullMassage.TabIndex = 19;
            delete_SuccesfullMassage.Text = "Выполнено                                 нажми для подтверждения";
            delete_SuccesfullMassage.TextAlign = ContentAlignment.MiddleCenter;
            delete_SuccesfullMassage.Visible = false;
            // 
            // delete_DeleteDataBase
            // 
            delete_DeleteDataBase.Anchor = AnchorStyles.None;
            delete_DeleteDataBase.BackColor = Color.Gainsboro;
            delete_DeleteDataBase.Location = new Point(605, 167);
            delete_DeleteDataBase.Margin = new Padding(10);
            delete_DeleteDataBase.Name = "delete_DeleteDataBase";
            delete_DeleteDataBase.Size = new Size(177, 32);
            delete_DeleteDataBase.TabIndex = 18;
            delete_DeleteDataBase.Text = "Удалить базу данных";
            delete_DeleteDataBase.UseVisualStyleBackColor = false;
            // 
            // delete_ErrorMassage
            // 
            delete_ErrorMassage.BackColor = Color.LavenderBlush;
            delete_ErrorMassage.Dock = DockStyle.Bottom;
            delete_ErrorMassage.ForeColor = Color.Red;
            delete_ErrorMassage.Location = new Point(0, 577);
            delete_ErrorMassage.Name = "delete_ErrorMassage";
            delete_ErrorMassage.Size = new Size(1248, 43);
            delete_ErrorMassage.TabIndex = 17;
            delete_ErrorMassage.Text = "Error";
            delete_ErrorMassage.TextAlign = ContentAlignment.MiddleCenter;
            delete_ErrorMassage.Visible = false;
            // 
            // delete_DeleteRows
            // 
            delete_DeleteRows.Anchor = AnchorStyles.None;
            delete_DeleteRows.BackColor = Color.Gainsboro;
            delete_DeleteRows.Location = new Point(605, 435);
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
            label17.Location = new Point(361, 338);
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
            delete_RowsValueField.Location = new Point(542, 388);
            delete_RowsValueField.Margin = new Padding(10);
            delete_RowsValueField.Name = "delete_RowsValueField";
            delete_RowsValueField.Size = new Size(308, 27);
            delete_RowsValueField.TabIndex = 15;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.Location = new Point(300, 376);
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
            delete_ColumnNameField.Location = new Point(542, 334);
            delete_ColumnNameField.Margin = new Padding(10);
            delete_ColumnNameField.Name = "delete_ColumnNameField";
            delete_ColumnNameField.Size = new Size(308, 27);
            delete_ColumnNameField.TabIndex = 13;
            // 
            // delete_DeleteTable
            // 
            delete_DeleteTable.Anchor = AnchorStyles.None;
            delete_DeleteTable.BackColor = Color.Gainsboro;
            delete_DeleteTable.Location = new Point(605, 271);
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
            delete_TableNameField.Location = new Point(542, 224);
            delete_TableNameField.Margin = new Padding(10);
            delete_TableNameField.Name = "delete_TableNameField";
            delete_TableNameField.Size = new Size(308, 27);
            delete_TableNameField.TabIndex = 4;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.Location = new Point(361, 224);
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
            delete_DBNameField.Location = new Point(542, 120);
            delete_DBNameField.Margin = new Padding(10);
            delete_DBNameField.Name = "delete_DBNameField";
            delete_DBNameField.Size = new Size(308, 27);
            delete_DBNameField.TabIndex = 2;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.Location = new Point(349, 123);
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
            ClientSize = new Size(1262, 659);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            connection.ResumeLayout(false);
            Create.ResumeLayout(false);
            read.ResumeLayout(false);
            add.ResumeLayout(false);
            update.ResumeLayout(false);
            delete.ResumeLayout(false);
            connectionPanel.ResumeLayout(false);
            connectionPanel.PerformLayout();
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            readPanel.ResumeLayout(false);
            readPanel.PerformLayout();
            updatePanel.ResumeLayout(false);
            updatePanel.PerformLayout();
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
        private Label connection_SuccesfullMassage;
        private Label connection_ErrorMassage;
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
        private Label create_SuccesfullMassage;
        private Label create_ErrorMassage;
        private Button create_Table;
        private Label label6;
        private TextBox create_DataBaseNameFieldFromTable;
        private Button create_NewDB;
        private Label label4;
        private TextBox create_TableNameField;
        private Label label5;
        private Label label3;
        private TextBox create_DateBaseNameField;
        private Label label2;
        private Panel readPanel;
        private Label read_labelColumnName;
        private TextBox read_ColumnsNameField;
        private Label read_SuccesfullMassage;
        private Label read_ErrorMassage;
        private Button read_readData;
        private RadioButton read_customColumns;
        private RadioButton read_allColumns;
        private Button read_readTableList;
        private TextBox read_TableNameField;
        private Label label8;
        private TextBox read_NameBDField;
        private Label label9;
        private Panel addPanel;
        private Label add_SuccesfullMassage;
        private Label label27;
        private Label add_ErrorMassage;
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
        private Label update_SuccesfullMassage;
        private Label label21;
        private TextBox update_FilterColumnNameField;
        private Label label19;
        private Label update_ErrorMassage;
        private TextBox update_NewValueField;
        private Button update_UpdateValue;
        private Label label20;
        private TextBox update_TableNameField;
        private TextBox update_ColumnNameField;
        private Label label13;
        private TextBox update_DBNameField;
        private Label label14;
        private Panel deletePanel;
        private Label delete_SuccesfullMassage;
        private Button delete_DeleteDataBase;
        private Label delete_ErrorMassage;
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
    }
}