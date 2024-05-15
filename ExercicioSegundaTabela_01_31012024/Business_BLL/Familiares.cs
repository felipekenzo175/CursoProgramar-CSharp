using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Facade;
using Modal;

namespace Business_BLL
{
    public class Familiares
    {
        FamiliaresFD objFamiliaresFD;

        public DataTable ConsultarBD(FamiliaresVO objParFamiliaresVO)
        {
            try
            {
                objFamiliaresFD = new FamiliaresFD();
                return objFamiliaresFD.ConsultarBD(objParFamiliaresVO);
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
                objFamiliaresFD = new FamiliaresFD();
                return objFamiliaresFD.InserirBD(objParFamiliaresVO);
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
                objFamiliaresFD = new FamiliaresFD();
                return objFamiliaresFD.ExcluirBD(objParFamiliaresVO);
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
                objFamiliaresFD = new FamiliaresFD();
                return objFamiliaresFD.AlterarBD(objParFamiliaresVO);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }
    }
}
