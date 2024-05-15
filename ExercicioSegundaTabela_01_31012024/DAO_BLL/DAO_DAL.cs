using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO_BLL
{
    public abstract class DAO_DAL : BD_DAO
    {
        public abstract DataTable ConsultarBD(Object Object_VO);

        public abstract void ConsultarBD(ref Object Object_VO);

        public abstract bool InserirBD(Object Object_VO);

        public abstract bool ExcluirBD(Object Object_VO);

        public abstract bool AlterarBD(Object Object_VO);
    }
}
