using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Models;


namespace HotelWithEntity.UserControls
{
    public partial class uEmployee : UserControl
    {

        private IEmployeeService _employeeService;
        public uEmployee(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            InitializeComponent();
        }

       
        private void uEmployee_Load(object sender, EventArgs e)
        {
            dtgvListEmployee.DataSource = _employeeService.GetEmployee();
        }
    }
}
