using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modal
{
    public class PreferenciasVO
    {
        private int id;
        private string descricao;

        public PreferenciasVO()
        {

        }

        public PreferenciasVO(int intId, string strDescricao)
        {
            setId(intId);
            setDescricao(strDescricao);
        }

        public void setId(int intId)
        {
            this.id = intId;
        }

        public void setDescricao(string strDescricao)
        {
            this.descricao = strDescricao;
        }

        public int getId() 
        {
            return this.id;
        }

        public string getDescricao()
        {
            return this.descricao;
        }

        public int ID 
        {
            get { return this.id;}
            set { this.id = value; }
        }

        public string DESCRICAO 
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        public List<PreferenciasVO> PreferenciasVOCollection = new List<PreferenciasVO>();
    }
}
