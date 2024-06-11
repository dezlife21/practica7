using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika7
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            // Додавання стовпців для відображення даних про планшети
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Brand";
            column.Name = "Бренд";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "OS";
            column.Name = "Операційна система";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Processor";
            column.Name = "Процесор";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RAM";
            column.Name = "Оперативна пам'ять";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Storage";
            column.Name = "Пам'ять";
            dataGridView.Columns.Add(column);

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "HasCamera";
            checkBoxColumn.Name = "Камера";
            checkBoxColumn.Width = 60;
            dataGridView.Columns.Add(checkBoxColumn);

            checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "HasSIMSlot";
            checkBoxColumn.Name = "Слот для SIM-карти";
            checkBoxColumn.Width = 60;
            dataGridView.Columns.Add(checkBoxColumn);

            // Додавання прикладу даних про планшет
            bindingSourceTablets.Add(new TabletForm("Apple", "iPad Air", "iOS", "A14 Bionic", "4 GB", "64 GB", true, false));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * toolStrip1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TabletForm tablet = new TabletForm();

            fTablet tabletForm = new fTablet(tablet);
            if (tabletForm.ShowDialog() == DialogResult.OK)
            {
                bindingSourceTablets.Add(tablet);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TabletForm tablet = (TabletForm)bindingSourceTablets.List[bindingSourceTablets.Position];

            fTablet tabletForm = new fTablet(tablet);
            if (tabletForm.ShowDialog() == DialogResult.OK)
            {
                bindingSourceTablets.List[bindingSourceTablets.Position] = tablet;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindingSourceTablets.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindingSourceTablets.Clear();
            }
        }
    }
}
