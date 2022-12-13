
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCheque
{
    public static class ValidarUsuario
    {
        public static bool isString(string usuario)
        {
            foreach (char c in usuario)
            {
                if (!(char.IsLetter(c)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}