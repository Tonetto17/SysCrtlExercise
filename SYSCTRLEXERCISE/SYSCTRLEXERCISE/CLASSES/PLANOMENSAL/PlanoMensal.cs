using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Nome da Classe: Plano Mensal
*          Descrição: Esta classe de objeto representa o Objeto Pessoa
*        Dt. Criação: 02/05/2023
*     Dt. Alteração: __/__/____
*         Criada por: Mirella
***********************************************************************/

namespace SYSCTRLEXERCISE
{
    public class PlanoMensal
    {
        //Método Destruct 
        ~PlanoMensal()
        {

        }
        #region Atributos Privados
        private int v_Cod_PlanoMensal = -1;
        private string v_Nm_PlanoMensal = "";
        private string v_Desc_PlanoMensal = "";
        private double v_Vlr_PlanoMensal = 0;
        #endregion

        #region Métodos Públicos
        public int Cod_PlanoMensal
        {
            get => v_Cod_PlanoMensal;
            set => v_Cod_PlanoMensal = value;
        }

        public string Nm_PlanoMensal
        {
            get => v_Nm_PlanoMensal;
            set => v_Nm_PlanoMensal = value;
        }

        public string Desc_PlanoMensal
        {
            get => v_Desc_PlanoMensal;
            set => v_Desc_PlanoMensal = value;
        }

        public double Vlr_PlanoMensal
        {
            get => v_Vlr_PlanoMensal;
            set => v_Vlr_PlanoMensal = value;
        }
        #endregion
    }
}
