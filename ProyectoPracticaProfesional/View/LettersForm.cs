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
    public partial class LettersForm : Form
    {
        UserController userController;
        DifficultyController difficultyController;
        public LettersForm(UserController userController, DifficultyController difficultyController)
        {
            this.userController = userController;
            this.difficultyController = difficultyController;
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            difficultyController.Get().Letter = "A";
            GameForm gameForm = new GameForm(userController, difficultyController);
            gameForm.ShowDialog();
            this.Close();
        }
    }
}
