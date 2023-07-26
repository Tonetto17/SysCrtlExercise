/********************************************************************
 *  Nome da Classe: BDConnection
 *       Descrição: Esta classe faz o Controle de acesso ao Banco de dados
 *     Dt. Criação: 08/05/2023
 *   Dt. Alteração: --/--/---- ( -- )
 *      Criada por: Tonetto
 ********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCtrlExercise
{
    //Static
    class BDConnection
    {
        //Metodo Destruct
        ~BDConnection()
        {

        }


        //Método da classe que retorna o caminho de onde está o BD.
        public static string ConnectionPath()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName=
            C:\Users\giovanna.ctonetto\source\repos\SysCtrlExercise\BDSysCtrlExercise.mdf;
            Integrated Security=True;Connect Timeout=15";
        }


    }
}
