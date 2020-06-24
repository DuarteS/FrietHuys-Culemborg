using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Friethuys_Culemborg
{
    public partial class MainPage : Form
    {
        public MainPage()
        {        
            InitializeComponent();
        }

        public void ShowAlertExample()
        {
            MetroMessageBox.Show(this, "Hello World!", "Title here", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
