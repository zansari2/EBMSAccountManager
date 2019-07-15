using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBMSAccountManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            roleComboBox.DisplayMember = "Name";
            roleComboBox.DataSource = EBMSAccountManager.BusinessLogic.Role.roles;

            facilityComboBox.DisplayMember = "Code";
            facilityComboBox.DataSource = EBMSAccountManager.BusinessLogic.Facility.facilities;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
