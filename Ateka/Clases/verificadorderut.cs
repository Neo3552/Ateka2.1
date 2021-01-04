using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ateka.Clases
{
    class verificadorderut
    {
        public Boolean Verificar(int rut ,string dv)
        {
            string Run = rut + dv;
            int multiplo = 3, suma = 0, aux;
            if (Run.Length == 8)
            {
                Run = "0" + Run;
            }
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    suma = suma + Convert.ToInt32(Convert.ToString(Run[i])) * multiplo;
                    multiplo--;
                    if (multiplo == 1)
                    {
                        multiplo = 7;
                    }
                }
                aux = suma % 11;
                aux = 11 - aux;
                if (aux == 10 && (Convert.ToString(Run[8]).Equals("k") || (Convert.ToString(Run[9]).Equals("K"))))
                {
                    return true;
                }
                else
                {
                    if (aux == 11 && (Convert.ToString(Run[8]).Equals("0")))
                    {
                        return true;
                    }
                    else
                    {
                        if (aux == Convert.ToInt32(Convert.ToString(Run[8])))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
