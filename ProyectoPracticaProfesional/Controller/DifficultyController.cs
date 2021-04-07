using ProyectoPracticaProfesional.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPracticaProfesional.Controller
{
    public class DifficultyController
    {
       private Difficulty difficulty = new Difficulty();

        public void Set(string name)
        {
            difficulty.Name = name;
        }

        public Difficulty Get()
        {
            return this.difficulty;
        }
    }
}
