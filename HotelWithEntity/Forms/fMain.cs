using HotelWithEntity.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelWithEntity.UserControls;
using Unity;
using Service;
using HotelWithEntity.Unities;
using Models;

namespace HotelWithEntity.Forms
{
    public partial class fMain : Form
    {
        public fMain()
        {

            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void picbExit_Click(object sender, EventArgs e)
        {

            var container = UnitiesRegister.BuildUnityContainer();

            fLogin login = container.Resolve<fLogin>(); ;
            this.Close();

            login.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            int i = 0;
            //Kiểm tra các controls trong pnlMain có tồn tại UC_Employee chưa
            foreach (Control control in pnlContent.Controls)
            {
                if (control is UserControl)
                {
                    if (control.Name == "uHome")
                    {
                        if (pnlContent.Controls[i].Name == "uHome")
                        {
                            pnlContent.Controls[i].BringToFront();
                            return;
                        }
                    }
                }
                i++;
            }
            //Nếu chưa tồn tại UC_Employee thì Add vào pnlMain
            uHome uHome = new uHome();
            uHome.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uHome);
            pnlContent.Controls[pnlContent.Controls.Count - 1].BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            int i = 0;
            //Kiểm tra các controls trong pnlMain có tồn tại UC_Employee chưa
            foreach (Control control in pnlContent.Controls)
            {
                if (control is UserControl)
                {
                    if (control.Name == "uEmployee")
                    {
                        if (pnlContent.Controls[i].Name == "uEmployee")
                        {
                            pnlContent.Controls[i].BringToFront();
                            return;
                        }
                    }
                }
                i++;
            }
            //Nếu chưa tồn tại UC_Employee thì Add vào pnlMain

            var container = UnitiesRegister.BuildUnityContainer();

            uEmployee uEmployee = container.Resolve<uEmployee>();
            uEmployee.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uEmployee);
            pnlContent.Controls[pnlContent.Controls.Count - 1].BringToFront();

        }

        private void picbMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }
        bool leftMenu = false;
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (leftMenu)
            {
                if (pnlLeftMenu.Width <= 250)
                {
                    pnlLeftMenu.Width += 5;
                    picbMenu.Left += 5;
                    //lblAdmin.Left += 5;
                }
                else
                {
                    leftMenu = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                if (pnlLeftMenu.Width > 50)
                {
                    pnlLeftMenu.Width -= 5;
                    picbMenu.Left -= 5;
                    //lblAdmin.Left -= 5;
                }
                else
                {
                    leftMenu = true;
                    timerMenu.Stop();
                }
            }
        }
    }
}
