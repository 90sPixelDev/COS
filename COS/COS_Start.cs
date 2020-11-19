using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COS
{

    public partial class COS_Start : Form
    {
        public COS_Start()
        {
            InitializeComponent();
        }

        private void new_charasheet_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Chara_Sheet new_Chara_Sheet = new Edit_Chara_Sheet();
            new_Chara_Sheet.ShowDialog();
        }

        private void COS_Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void load_chara_btn_Click(object sender, EventArgs e)
        {
            Edit_Chara_Sheet new_Chara_Sheet = new Edit_Chara_Sheet();
            this.Hide();
            new_Chara_Sheet.ShowDialog();
            new_Chara_Sheet.LoadCharacterSheet();
        }
    }
}
