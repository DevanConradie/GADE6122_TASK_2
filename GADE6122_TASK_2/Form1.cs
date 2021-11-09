using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6122_TASK_1
{
    public partial class frmGame : Form
    {
        GameEngine newInstance;
        public frmGame()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }

        private void btnAttackUp_Click(object sender, EventArgs e)
        {

        }

        private void btnAttackRight_Click(object sender, EventArgs e)
        {

        }

        private void btnAttackDown_Click(object sender, EventArgs e)
        {

        }

        private void btnAttackLeft_Click(object sender, EventArgs e)
        {

        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            newInstance = new GameEngine();
            rtxBoxMap.Text = newInstance.BuildMap();
            
        }
    }
}
