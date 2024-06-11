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
    public partial class fTablet : Form
    {
        public TabletForm TheTablet;
        public fTablet(TabletForm t)
        {
            TheTablet = t;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fTown_Load(object sender, EventArgs e)
        {
            if (TheTablet != null)
            {
                tbBrand.Text = TheTablet.Brand;
                tbModel.Text = TheTablet.Model;
                tbOS.Text = TheTablet.OS;
                tbProcessor.Text = TheTablet.Processor;
                tbRAM.Text = TheTablet.RAM;
                tbStorage.Text = TheTablet.Storage;
                chbHasCamera.Checked = TheTablet.HasCamera;
                chbHasSIMSlot.Checked = TheTablet.HasSIMSlot;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheTablet.Brand = tbBrand.Text.Trim();
            TheTablet.Model = tbModel.Text.Trim();
            TheTablet.OS = tbOS.Text.Trim();
            TheTablet.Processor = tbProcessor.Text.Trim();
            TheTablet.RAM = tbRAM.Text.Trim();
            TheTablet.Storage = tbStorage.Text.Trim();
            TheTablet.HasCamera = chbHasCamera.Checked;
            TheTablet.HasSIMSlot = chbHasSIMSlot.Checked;
            DialogResult = DialogResult.OK;
        }

        private void tbBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbModel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
