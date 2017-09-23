using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WinForms6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Family_Click(object sender, EventArgs e)
        {
            this.family_TextBox.Clear();
        }
        private void clear_Name_Click(object sender, EventArgs e)
        {
            this.name_TextBox.Clear();
        }
        private void clear_patronymic_Click(object sender, EventArgs e)
        {
            this.patronymic_TextBox.Clear();
        }
        private void clear_Floor_Click(object sender, EventArgs e)
        {
            this.floor_TextBox.Clear();
        }
        private void clear_Year_Click(object sender, EventArgs e)
        {
            this.year_TextBox.Clear();
        }
        private void clear_status_Click(object sender, EventArgs e)
        {
            this.status_TextBox.Clear();
        }
        private void save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
        }
    }
}
