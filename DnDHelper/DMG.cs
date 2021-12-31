using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDHelper
{
    public partial class DMG : Form
    {
        public DMG()
        {
            InitializeComponent();
        }

        private void btnFormOfGovernment_Click(object sender, EventArgs e)
        {
            //lblFormOfGovernment.Text = DungeonMastersGuide.FormsOfGovernment[Dice.Roll(DungeonMastersGuide.FormsOfGovernment.Length)];
        }
    }
}
