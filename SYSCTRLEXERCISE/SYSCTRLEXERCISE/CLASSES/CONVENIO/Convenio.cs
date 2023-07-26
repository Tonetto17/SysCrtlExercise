using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Nome da Classe: Convenio
*          Descrição: Esta classe de objeto representa o Objeto Pessoa
*        Dt. Criação: 02/05/2023
*     Dt. Alteração: __/__/____
*         Criada por: Mirella
***********************************************************************/

namespace SYSCTRLEXERCISE
{
    class Convenio
    {
        //Método Destruct 
        ~Convenio()
        {

        }

        #region Atributos Privados
        private int v_Cod_Convenio = -1;
        private string v_Nm_Convenio = "";
        private string v_Nro_Convenio = "";
        private int v_Tp_Convenio = 0;
        private string v_Cat_Convenio = "";
        #endregion

        #region Métodos Públicos
        public int Cod_Convenio
        {
            get => v_Cod_Convenio;
            set => v_Cod_Convenio = value;
        }

        public string Nm_Convenio
        {
            get => v_Nm_Convenio;
            set => v_Nm_Convenio = value;
        }

        public string Nro_Convenio
        {
            get => v_Nro_Convenio;
            set => v_Nro_Convenio = value;
        }

        public int Tp_Convenio
        {
            get => v_Tp_Convenio;
            set => v_Tp_Convenio = value;
        }

        public string Cat_Convenio
        {
            get => v_Cat_Convenio;
            set => v_Cat_Convenio = value;
        }
        #endregion
    }
}
