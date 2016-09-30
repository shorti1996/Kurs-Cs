using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WojciechLiebertLab4
{
    public partial class FormMain : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter sqlAdapter;
        int cellColumn = 0;
        String selectedColumnName = String.Empty;
        public FormMain()
        {
            InitializeComponent();
            //initialize sql connection
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-C63SA6V\SQLEXPRESS;Initial Catalog=Zad1;Integrated Security=True");
            FillComboBoxDatabaseQuery();
            comboBoxOperationQuery.SelectedIndex = 0;
            //DOESN'T WORK THE WAY IT SHOULD
            splitContainerQuery.SplitterDistance = 260;
        }

        /// <summary>
        /// Populate comboBox with database's table names
        /// </summary>
        private void FillComboBoxDatabaseQuery()
        {
            comboBoxDatabaseQuery.DataSource = null;
            comboBoxDatabaseQuery.DataSource = DatabaseTables.GetAllTableNames(sqlAdapter, sqlConnection);
        }

        private void buttonGetFromServer_Click(object sender, EventArgs e)
        {
            //Pet
            dataGridViewPet.DataSource = null;
            dataGridViewPet.DataSource = AllData.GetAllData("Pet", sqlAdapter, sqlConnection);
            //Owner
            dataGridViewOwner.DataSource = null;
            dataGridViewOwner.DataSource = AllData.GetAllData("Owner", sqlAdapter, sqlConnection);
            //Vet
            dataGridViewVet.DataSource = null;
            dataGridViewVet.DataSource = AllData.GetAllData("Vet", sqlAdapter, sqlConnection);
            //Visit
            dataGridViewVisit.DataSource = null;
            dataGridViewVisit.DataSource = AllData.GetAllData("Visit", sqlAdapter, sqlConnection);
        }

        /// <summary>
        /// Change visible table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDatabaseQuery_TextChanged(object sender, EventArgs e)
        {
            dataGridViewQuery.DataSource = null;
            dataGridViewQuery.DataSource = AllData.GetAllData(comboBoxDatabaseQuery.Text, sqlAdapter, sqlConnection);
        }

        /// <summary>
        /// Get index and name of selected cell's row and fill textBoxColumn with the name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewQuery_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cellColumn = dataGridViewQuery.SelectedCells[0].ColumnIndex;
            String text = string.Empty;
            selectedColumnName = dataGridViewQuery.Columns[cellColumn].Name;
            textBoxColumn.Text = selectedColumnName;
        }

        /// <summary>
        /// Apply filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilterQuery_TextChanged(object sender, EventArgs e)
        {
            dataGridViewQuery.DataSource = null;
            dataGridViewQuery.DataSource = AllData.GetAllData(comboBoxDatabaseQuery.Text, selectedColumnName, comboBoxOperationQuery.Text, textBoxFilterQuery.Text, sqlAdapter, sqlConnection);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            dataGridViewVet.DataSource = null;
            dataGridViewVet.DataSource = AllData.GetAllData(comboBoxDatabaseQuery.Text, sqlAdapter, sqlConnection);
            WojciechLiebertLab4.Insert.InsertData(sqlAdapter, sqlConnection, comboBoxDatabaseQuery.Text, textBoxInsert.Text);
            //(example for me) INSERT INTO Medicine(Id, Name, Disease) VALUES(20, 2, 1)
        }
    }
}
