using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PreferenciasBLL
{
    public class Preferencias
    {
        StreamReader objLeitorTxt;
        string strLinhaLida;

        public List<String> impTxtWhile()
        {
            List<String> lista = new List<String>();

            objLeitorTxt = new StreamReader(@"C:\CURSO PROGRAMAR\C#.NET\preferencias.txt");
            strLinhaLida = objLeitorTxt.ReadLine();

            while (strLinhaLida != null)
            {
                lista.Add(strLinhaLida);
                strLinhaLida = objLeitorTxt.ReadLine();
            }

            objLeitorTxt.Close();

            return lista;
        }
    }
}
