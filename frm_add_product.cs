using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Resources;
using System.Threading;

namespace POS_Vegetable
{
    public partial class frm_add_product : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frm_add_product()
        {
            //if (language.lang=="si-LK")
            //{
            //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("si-LK");
            //}
            //else
            //{
            //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            //}
            InitializeComponent();

        }


        private void frm_add_product_Load(object sender, EventArgs e)
        {
            //label27.Text = Properties.Resources.ID;
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ur-PK");
            label1.ForeColor = Color.Blue;
            label2.ForeColor = Color.Red;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.Text=="english")
            //{
            //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

            //}
            //else if (comboBox1.Text == "urdu")
            //{
            //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ur-PK");

            //}
            //this.Controls.Clear();
            //InitializeComponent();

        }

        private void btn_new_equipment_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu mnu = new ContextMenu();
            System.Windows.Forms.MenuItem mnuCopy = new System.Windows.Forms.MenuItem("Eng");
            System.Windows.Forms.MenuItem mnuCut = new System.Windows.Forms.MenuItem("සිංහල");


            mnuCopy.Click += new EventHandler(eng_Click);
            mnuCut.Click += new EventHandler(sinhala_Click);

            mnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] { mnuCopy, mnuCut });
            mnu.Show(this, new System.Drawing.Point(label2.Location.X, label2.Location.Y));
            label2.ContextMenu = mnu;
        }
        private void eng_Click(object sender, EventArgs e)
        {
            label2.Text = "Eng";
            label1.Text = "සිංහල";
            lblid.Text = "ID";
            lblShortCode.Text = "Short Code";
            lblName.Text = "Name";
            lblBagsCost.Text = "Bags Cost";
            lblLaborCost.Text = "Labor Cost";
            btn_del.Text = "Delete";
            btn_new.Text = "New";
            btn_save.Text = "Save";
            btn_update.Text = "Update";
            this.TitleText = "Add Products";
        }
        private void sinhala_Click(object sender, EventArgs e)
        {
            label2.Text = "සිංහල";
            label1.Text = "Language";
            lblid.Text = Properties.Resources.ID;
            lblShortCode.Text = Properties.Resources.ShortCode;
            lblName.Text = Properties.Resources.name;
            lblBagsCost.Text = Properties.Resources.bagscost;
            lblLaborCost.Text = Properties.Resources.laborCost;
            btn_del.Text = Properties.Resources.btndelete;
            btn_new.Text = Properties.Resources.btnnew;
            btn_save.Text = Properties.Resources.btnsave;
            btn_update.Text = Properties.Resources.btnupdate;
            this.TitleText = "නිෂ්පාදන එකතු කරන්න";
        }
    }
}