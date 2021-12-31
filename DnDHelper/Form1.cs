namespace DnDHelper
{
    /// <summary>
    /// The primary WinForm
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void worldBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dmg = new DMG();
            dmg.Show();
        }
    }
}