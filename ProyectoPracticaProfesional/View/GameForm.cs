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
    public partial class GameForm : Form
    {
        public GameForm(UserController userControler,DifficultyController difficultyController)
        {
            InitializeComponent();
        }
    }
}
