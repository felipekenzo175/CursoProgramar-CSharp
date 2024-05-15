using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_BLL;
using System.Data;
using Modal;

namespace Facade
{
    public class FamiliaresFD
    {
        FamiliaresDAO objFamiliaresDAO;

        public DataTable ConsultarBD(FamiliaresVO objParFamiliaresVO)
        {
            try
            {
                objFamiliaresDAO = new FamiliaresDAO();
                return objFamiliaresDAO.ConsultarBD(objParFamiliaresVO);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public bool InserirBD(FamiliaresVO objParFamiliaresVO)
        {
            try
            {
                objFamiliaresDAO = new FamiliaresDAO();
                return objFamiliaresDAO.InserirBD(objParFamiliaresVO);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public bool ExcluirBD(FamiliaresVO objParFamiliaresVO)
        {
            try
            {
                objFamiliaresDAO = new FamiliaresDAO();
                return objFamiliaresDAO.ExcluirBD(objParFamiliaresVO);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public bool AlterarBD(FamiliaresVO objParFamiliaresVO)
        {
            try
            {
                objFamiliaresDAO = new FamiliaresDAO();
                return objFamiliaresDAO.AlterarBD(objParFamiliaresVO);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }
    }
}
