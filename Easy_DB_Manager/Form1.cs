using System.Data.Linq;
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
        }

        //public void ShowMessageBox(string textMesseget, string headerMSB, bool isError)
        //{
        //    MessageBox.Show(textMesseget, headerMSB, MessageBoxIcon.)
        //}

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
            columns.Add($"{create_ColumnsName.Text ?? ""} " +
                $"{create_dataTypes.SelectedValue?.ToString() ?? ""} ({create_dataTypeRange.Value}) " +
                $"{create_primaryKey.Text} " +
                $"");

            create_labelCurrentColumns.Text = "";

            foreach (var item in columns)
            {
                create_labelCurrentColumns.Text += item + "\n";
            }
        }
    }
}