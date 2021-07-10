# mouse-hover-menu-strip-C#-windows-form
1- using System.Windows.Forms;
2- Write Code onClick Event of controle
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
        
3- now create click event against menu strip items click

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
