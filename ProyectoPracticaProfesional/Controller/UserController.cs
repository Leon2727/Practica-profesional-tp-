using ProyectoPracticaProfesional.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPracticaProfesional.Controller
{
    public class UserController
    {
        private User user = new User();

        public void CreateUser (string userName, int age)
        {
            this.user.Name = userName;
            this.user.Age = age;
        }

        public User GetUser()
        {
            return this.user;
        }
    }
}
