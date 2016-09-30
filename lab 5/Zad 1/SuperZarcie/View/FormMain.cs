using SuperZarcie.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperZarcie
{
    public partial class FormMain : Form
    {
        DataClassesSuperZarcieDataContext dataContext = new DataClassesSuperZarcieDataContext();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            IQueryable<Meal> query = Model.Meal.GetAllMeals(dataContext);
            dataGridViewDisplay.DataSource = null;
            dataGridViewDisplay.DataSource = query;
        }
    }
}
