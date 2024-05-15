using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Facade;
using Modal;

namespace Business_BLL
{
    public class Preferencias
    {
        PreferenciasFD objPreferenciasFD;
        StreamReader objLeitorTxt;
        string strLinhaLida;

        public List<String> ImpTxtWhile()
        {
            try
            {
                List<String> resultado = new List<String>();

                objLeitorTxt = new StreamReader(@"C:\CURSO PROGRAMAR\1. C#.NET\preferencias.txt");
                strLinhaLida = objLeitorTxt.ReadLine();

                while (strLinhaLida != null)
	            {
                    resultado.Add(strLinhaLida);
                    strLinhaLida = objLeitorTxt.ReadLine();
	            }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
            finally
            {
                objLeitorTxt.Close();
            }
        }

        public List<String> BancoConectado()
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.BancoConectado();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public List<String> BancoDesconectado()
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.BancoDesconectado();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public DataTable ConsultarBD(PreferenciasVO objParPreferenciasVO)
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.ConsultarBD(objParPreferenciasVO);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public void ConsultarBD(ref PreferenciasVO objParPreferenciasVO)
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                objPreferenciasFD.ConsultarBD(objParPreferenciasVO);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public bool InserirBD(PreferenciasVO objParPreferenciasVO)
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.InserirBD(objParPreferenciasVO);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public bool ExcluirBD(PreferenciasVO objParPreferenciasVO)
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.ExcluirBD(objParPreferenciasVO);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public bool AlterarBD(PreferenciasVO objParPreferenciasVO)
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.AlterarBD(objParPreferenciasVO);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }
    }
}
