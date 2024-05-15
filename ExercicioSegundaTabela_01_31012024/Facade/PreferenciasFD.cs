using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO_BLL;
using Modal;

namespace Facade
{
    public class PreferenciasFD
    {
        PreferenciasDAO objPreferenciasDAO;

        public List<String> BancoConectado()
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.BancoConectado();
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
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.BancoDesconectado();
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
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.ConsultarBD(objParPreferenciasVO);
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
                objPreferenciasDAO = new PreferenciasDAO();
                objPreferenciasDAO.ConsultarBD(objParPreferenciasVO);
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
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.InserirBD(objParPreferenciasVO);
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
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.ExcluirBD(objParPreferenciasVO);
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
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.AlterarBD(objParPreferenciasVO);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }
    }
}
