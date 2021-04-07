using ProyectoPracticaProfesional.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPracticaProfesional.View
{
    public partial class UserForm : Form
    {
        private UserController userController = new UserController();
        
        public UserForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {  
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxAge.Text))
            {
                var name = textBoxName.Text;
                var age = Convert.ToInt32(textBoxAge.Text);
                userController.CreateUser(name, age);
                DifficultyForm difficultyForm = new DifficultyForm(userController);
                difficultyForm.ShowDialog();
                this.Close();
            }
            else if (string.IsNullOrEmpty(textBoxName.Text))
            {
                textBoxName.Focus();
            }
            else
            {
                textBoxAge.Focus();
            }
        }
    }
}
