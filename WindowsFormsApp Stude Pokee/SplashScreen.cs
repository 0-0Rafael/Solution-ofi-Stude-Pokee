using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Stude_Pokee
{
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// Metodo del contador del Splash
        /// </summary>
        int i = 1;
        public SplashScreen()
        {
            
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled= true;
        }
        /// <summary>
        /// Metodo para cerrar el Splash cuando la condicion se cumpla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            i += 1;
            if (i == 12)
            {
                SplashTimer.Enabled = false;
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
}
