using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  //using é uma biblioteca, SqlClient é um objeto

/**************************************************************************
        * Nome da Classe: BDConnection
        *      Descrição: Esta classe faz o Controle de acesso 
        *    Dt. Criação: 08/05/2023
        *  Dt. Alteração: __/__/____
        *     Criada por: Mirella
        ***************************************************************************/

namespace SYSCTRLEXERCISE
{
    //Static para teste
    class BDConnection
    {
        //Método Destruc 
        ~BDConnection()
        {

        }
        //Método da classe que retorna o caminho de onde está o BD
        public static string ConnectionPath()  //caminho (path) de conexão
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName=C:\Users\mirella.msouza\source\repos\SYSCTRLEXERCISE\SYSCTRLEXERCISE\BDSysCtrlExercise.mdf;Integrated Security=True;Connect Timeout=15";  //attach é anexar; connect timeout é o tempo em segundos para a conexão cair
        }
    }
}
