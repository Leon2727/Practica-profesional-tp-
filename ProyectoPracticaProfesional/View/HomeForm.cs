using ProyectoPracticaProfesional.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPracticaProfesional
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
            this.Close();
        }
    }
}
