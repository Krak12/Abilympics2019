using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abilympics2019
{
    public partial class TechnicianMenu : Form
    {
        public TechnicianMenu()
        {
            InitializeComponent();
        }

        private void AssignedOrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assignedOrdersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void TechnicianMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.AssignedOrders". При необходимости она может быть перемещена или удалена.
            this.assignedOrdersTableAdapter.Fill(this.dbDataSet.AssignedOrders);

        }

        //переходы по tabPage
        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        //закрытие формы
        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
