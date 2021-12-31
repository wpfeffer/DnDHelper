using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DungeonMastersGuide;

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
            lblFormOfGovernment.Text = GetFormOfGovernment();
        }

        private string GetFormOfGovernment()
        {
            return FormsOfGovernment.Governments[Dice.Roll((byte)FormsOfGovernment.Governments.Count)].Government;
        }

        private void btnBuildAWorld_Click(object sender, EventArgs e)
        {
            DeactivateButtons();
            BuildWorld();
        }

        private void DeactivateButtons()
        {
            btnFormOfGovernment.Enabled = false;
        }

        private void BuildWorld()
        {
            lblFormOfGovernment.Text = GetFormOfGovernment();
        }
    }
}
