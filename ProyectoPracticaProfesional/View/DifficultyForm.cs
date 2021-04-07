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
    public partial class DifficultyForm : Form
    {
        private UserController userController;
        private DifficultyController difficultyController = new DifficultyController();
        public DifficultyForm(UserController userController)
        {
            this.userController = userController;
            InitializeComponent();
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            difficultyController.Set("Easy");
            LettersForm lettersForm = new LettersForm(userController, difficultyController);
            lettersForm.ShowDialog();
            this.Close();
        }

        private void buttonMedium_Click(object sender, EventArgs e)
        {
            difficultyController.Set("Medium");
            LettersForm lettersForm = new LettersForm(userController, difficultyController);
            lettersForm.ShowDialog();
            this.Close();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            difficultyController.Set("Hard");
            LettersForm lettersForm = new LettersForm(userController, difficultyController);
            lettersForm.ShowDialog();
            this.Close();
        }
    }
}
