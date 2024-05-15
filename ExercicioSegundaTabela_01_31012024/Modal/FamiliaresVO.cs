using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modal
{
    public class FamiliaresVO
    {
        private int cod;
        private string nome;
        private string sexo;
        private int idade;
        private DateTime dataNascimento;
        private double ganhoMensalTotal;
        private double gastoMensalTotal;
        private string obs;

        public FamiliaresVO()
        {

        }

        public FamiliaresVO(int intCod, string strNome, string strSexo, int intIdade, DateTime dateNascimento, double doubleGanhoTotal, double doubleGastoTotal, string strObs)
        {
            setCod(intCod);
            setNome(strNome);
            setSexo(strSexo);
            setIdade(intIdade);
            setDataNascimento(dateNascimento);
            setGanhoTotal(doubleGanhoTotal);
            setGastoTotal(doubleGastoTotal);
            setObs(strObs);
        }

        public void setCod(int intCod)
        {
            this.cod = intCod;
        }

        public void setNome(string strNome)
        {
            this.nome = strNome;
        }
        
        public void setSexo(string strSexo)
        {
            if (strSexo == "MASCULINO" || strSexo == "FEMININO" || strSexo == "INDEFINIDO")
            {
                this.sexo = strSexo;
            }
            else
            {
                throw new Exception("Atributo Sexo Inexistente!");
            }
        }
         
        public void setIdade(int intIdade)
        {
            this.idade = intIdade;
        }
         
        public void setDataNascimento(DateTime dateNascimento)
        {
            this.dataNascimento = dateNascimento;
        }

        public void setGanhoTotal(double doubleGanhoTotal)
        {
            this.ganhoMensalTotal = doubleGanhoTotal;
        }
        
        public void setGastoTotal(double doubleGastoTotal)
        {
            this.gastoMensalTotal = doubleGastoTotal;
        }

        public void setObs(string strObs)
        {
            this.obs = strObs;
        }

        public int getCod()
        {
            return this.cod;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getSexo()
        {
            return this.sexo;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public DateTime getDataNascimento()
        {
            return this.dataNascimento;
        }

        public double getGanhoTotal()
        {
            return this.ganhoMensalTotal;
        }

        public double getGastoTotal()
        {
            return this.gastoMensalTotal;
        }

        public string getObs()
        {
            return this.obs;
        }

        public List<FamiliaresVO> FamiliaresVOCollection = new List<FamiliaresVO>();
    }
}
