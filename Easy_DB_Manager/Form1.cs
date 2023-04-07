using System.Data.Linq;
using System.Security.Policy;
using LinqToDB;
using LinqToDB.SqlQuery;

namespace Easy_DB_Manager
{
    public partial class Form1 : Form
    {
        List<string> columns = new List<string>();
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("Message text",
            //    "Header", MessageBoxButtons.OK,
            //    MessageBoxIcon.Error,
            //    MessageBoxDefaultButton.Button1,
            //    MessageBoxOptions.DefaultDesktopOnly);

            create_DateBaseNameField.DataBindings.Add(new Binding("Text", connection_DataBaseNameField, "Text"));
            read_NameBDField.DataBindings.Add(new Binding("Text", connection_DataBaseNameField, "Text"));
            add_NameBDField.DataBindings.Add(new Binding("Text", connection_DataBaseNameField, "Text"));
            update_DBNameField.DataBindings.Add(new Binding("Text", connection_DataBaseNameField, "Text"));
            delete_DBNameField.DataBindings.Add(new Binding("Text", connection_DataBaseNameField, "Text"));

            read_TableNameField.DataBindings.Add(new Binding("Text", create_TableNameField, "Text"));
            add_TableNameField.DataBindings.Add(new Binding("Text", create_TableNameField, "Text"));
            update_TableNameField.DataBindings.Add(new Binding("Text", create_TableNameField, "Text"));
            delete_TableNameField.DataBindings.Add(new Binding("Text", create_TableNameField, "Text"));
        }

        void PrintColumnsList()
        {
            create_labelCurrentColumns.Text = "";

            foreach (var item in columns)
                create_labelCurrentColumns.Text += item + "\n";
        }

        private void create_NewDB_Click(object sender, EventArgs e)
        {
            _ = DB.CreateDB(connection_ServerName.Text, create_DateBaseNameField.Text);
        }

        private void create_foreignKey_CheckedChanged(object sender, EventArgs e)
        {
            create_foreignTableLabel.Visible = create_foreignKey.Checked;
            create_foreignTableNameField.Visible = create_foreignKey.Checked;
            create_foreignColumnLabel.Visible = create_foreignKey.Checked;
            create_foreignColumnNameField.Visible = create_foreignKey.Checked;
        }

        private void create_default_CheckedChanged(object sender, EventArgs e)
        {
            create_defaultValueField.Visible = create_default.Checked;
        }

        private void create_addColumn_Click(object sender, EventArgs e)
        {
            string columnFormation = $"{create_ColumnsName.Text ?? ""}  {create_dataTypes.SelectedItem.ToString() ?? ""}";

            if (create_dataTypes.SelectedItem.ToString() == "NVARCHAR" || create_dataTypes.SelectedItem.ToString() == "VARCHAR")
                columnFormation += $"({(int)create_dataTypeRange.Value})";
            if (create_primaryKey.Checked) columnFormation += "  PRIMARY KEY";
            if (create_foreignKey.Checked) columnFormation += $"  FOREIGN KEY REFERENCES {create_foreignTableNameField.Text ?? ""}({create_foreignColumnNameField.Text ?? ""})";
            if (create_notNull.Checked) columnFormation += "  NOT NULL";
            if (create_unique.Checked) columnFormation += "  UNIQUE";
            if (create_identity.Checked) columnFormation += "  IDENTITY";
            if (create_default.Checked)
            {
                if (create_dataTypes.SelectedItem.ToString() == "INT" || create_dataTypes.SelectedItem.ToString() == "SMALLINT" || create_dataTypes.SelectedItem.ToString() == "FLOAT"
                    || create_dataTypes.SelectedItem.ToString() == "REAL" || create_dataTypes.SelectedItem.ToString() == "MONEY")
                {
                    columnFormation += $"  DEFAULT {create_defaultValueField.Text ?? ""}";
                }
                else
                {
                    columnFormation += $"  DEFAULT '{create_defaultValueField.Text ?? ""}'";
                }
            }
            columns.Add(columnFormation);

            PrintColumnsList();
        }

        private void create_removeColumn_Click(object sender, EventArgs e)
        {
            columns.RemoveAt(columns.Count - 1);
            PrintColumnsList();
        }

        private void create_Table_Click(object sender, EventArgs e)
        {
            string strCommand = "";

            for (int i = 0; i < columns.Count; i++)
            {
                strCommand += columns[i];

                if (i < columns.Count - 1)
                    strCommand += ", ";
                else
                    strCommand += " ";
            }

            _ = DB.CreateTable(create_TableNameField.Text, strCommand, connection_ServerName.Text, create_DateBaseNameField.Text);
        }

        private void read_readTableList_Click(object sender, EventArgs e)
        {
            _ = DB.ReadAllTablesFromDB(connection_ServerName.Text, read_NameBDField.Text);
        }

        private void read_readData_Click(object sender, EventArgs e)
        {
            string columns = "";

            _ = DB.ReadDataOfTable(connection_ServerName.Text, read_NameBDField.Text, read_TableNameField.Text, columns, read_allColumns.Checked);
        }

        private void update_UpdateValue_Click(object sender, EventArgs e)
        {
            _ = DB.UpdateValue(connection_ServerName.Text, update_DBNameField.Text, update_TableNameField.Text,
                update_ColumnNameField.Text, update_NewValueField.Text, update_FilterColumnNameField.Text, update_FilterColumnValueField.Text);
        }

        private void delete_DeleteDataBase_Click(object sender, EventArgs e)
        {
            _ = DB.DropDB(connection_ServerName.Text, delete_DBNameField.Text);
        }

        private void delete_DeleteTable_Click(object sender, EventArgs e)
        {
            _ = DB.DropTable(connection_ServerName.Text, delete_DBNameField.Text, delete_TableNameField.Text);
        }

        private void delete_DeleteRows_Click(object sender, EventArgs e)
        {
            _ = DB.DeleteFromTable(connection_ServerName.Text, delete_DBNameField.Text, delete_TableNameField.Text, delete_ColumnNameField.Text, delete_RowsValueField.Text);
        }

        private void add_addEntry_Click(object sender, EventArgs e)
        {
            _ = DB.AddDataInTable(connection_ServerName.Text, add_NameBDField.Text, add_TableNameField.Text, add_ColumnNameField.Text, add_ColumnValues.Text);
        }
    }
}