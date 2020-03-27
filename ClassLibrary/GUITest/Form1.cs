using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WishlistLib.User;
using WishlistInterfaces;

namespace GUITest
{
    public partial class Form1 : Form
    {       
	//TEST MASTER BRANCHE
        public Form1()
        {
            InitializeComponent();
        }
	//EXTRA BERICHT VOOR MERGE TEST
        private void btnTest_Click(object sender, EventArgs e)
        {
            User u = new User();

            bool result = u.Login("Test", "Test");
        }
    }
}
