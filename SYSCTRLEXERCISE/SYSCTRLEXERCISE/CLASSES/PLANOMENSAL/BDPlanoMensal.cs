/**************************************************************************
* Nome da Classe: BDPlanoMensal
*      Descrição: Esta classe de Controle de Objeto negocia com o Banco de 
*                 Dados os métodos públicos: Incluir, Excluir, Alterar, 
*                 FindByCodPlanoMensal e FindAllPlanoMensal
*    Dt. Criação: 09/05/2023
*  Dt. Alteração: __/__/____
*     Criada por: Mirella
***************************************************************************/

using SYSCTRLEXERCISE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;  //using criada em BDConnection
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSCTRLEXERCISE
{
    class BDPlanoMensal
    {
        //Método Destruct para instanciados 
        ~BDPlanoMensal()
        {

        }
        /**************************************************************************
        * Nome da Classe: Incluir
        *      Descrição: Responsável por incluir o Registro (Tupla) do PlanoMensal na
        *      TB_PLANOMENSAL
        *      Parâmetro: Objeto PlanoMensal
        *        Retorno: Código do PlanoMensal (PK - Primary Key)
        *    Dt. Criação: 09/05/2023
        *  Dt. Alteração: __/__/____
        *     Criada por: Mirella
        ***************************************************************************/
        public int Incluir(PlanoMensal pobj_PlanoMensal)  //p0bj é o parâmetro do objeto
        {
            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());  //instanciando conexão; conecta c/ BD

            string s_Sql = " INSERT INTO TB_PLANOMENSAL " +
                           " ( " +
                           " S_NM_PLANOMENSAL, " +
                           " S_DESC_PLANOMENSAL, " +
                           " D_VLR_PLANOMESAL " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @S_NM_PLANOMENSAL, " +
                           " @S_DESC_PLANOMENSAL, " +
                           " @D_VLR_PLANOMESAL " +
                           " ); " +
                           " SELECT IDENT_CURRENT('TB_PLANOMENSAL') AS COD";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@S_NM_PLANOMENSAL", pobj_PlanoMensal.Nm_PlanoMensal);
            obj_Com.Parameters.AddWithValue("@S_DESC_PLANOMENSAL", pobj_PlanoMensal.Desc_PlanoMensal);
            obj_Com.Parameters.AddWithValue("@D_VLR_PLANOMESAL", pobj_PlanoMensal.Vlr_PlanoMensal);

            try
            {
                obj_Conn.Open();
                int i_Cod = Convert.ToInt16(obj_Com.ExecuteScalar());
                obj_Conn.Close();
                return i_Cod;
            }
            catch (Exception erro)  //se der erro
            {
                MessageBox.Show(erro.Message, "ERRO AO INCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return pobj_PlanoMensal.Cod_PlanoMensal;
            }
        }
        /**************************************************************************
        * Nome da Classe: Alterar
        *      Descrição: Responsável por alterar o Registro (Tupla) do PlanoMensal na
        *      TB_PLANOMENSAL
        *      Parâmetro: Objeto PlanoMensal
        *        Retorno: bool
        *    Dt. Criação: 09/05/2023
        *  Dt. Alteração: __/__/____
        *     Criada por: Mirella
        ***************************************************************************/
        public bool Alterar(PlanoMensal pobj_PlanoMensal)
        {
            if (pobj_PlanoMensal.Cod_PlanoMensal != -1)
            {
                //Conexão com o BD
                SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());



                string s_Sql = " UPDATE TB_PLANOMENSAL SET " +
                               " S_NM_PLANOMENSAL = @S_NM_PLANOMENSAL " +
                               " S_DESC_PLANOMENSAL = @S_DESC_PLANOMENSAL " +
                               " D_VLR_PLANOMESAL = @D_VLR_PLANOMESAL " +
                               " WHERE I_COD_PLANOMENSAL = @I_COD_PLANOMENSAL";

                SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
                obj_Com.Parameters.AddWithValue("@I_COD_PLANOMENSAL", pobj_PlanoMensal.Cod_PlanoMensal);
                obj_Com.Parameters.AddWithValue("@S_NM_PLANOMENSAL", pobj_PlanoMensal.Nm_PlanoMensal);
                obj_Com.Parameters.AddWithValue("@S_DESC_PLANOMENSAL", pobj_PlanoMensal.Desc_PlanoMensal);
                obj_Com.Parameters.AddWithValue("@D_VLR_PLANOMESAL", pobj_PlanoMensal.Vlr_PlanoMensal);

                try
                {
                    obj_Conn.Open(); //abre a conexão
                    obj_Com.ExecuteNonQuery();
                    obj_Conn.Close();
                    return true;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, " ERRO AO ALTERAR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /**************************************************************************
        * Nome da Classe: Excluir
        *      Descrição: Responsável por excluir o Registro (Tupla) do PlanoMensal na
        *      TB_PLANOMENSAL
        *      Parâmetro: Objeto PlanoMensal
        *        Retorno: bool
        *    Dt. Criação: 09/05/2023
        *  Dt. Alteração: __/__/____
        *     Criada por: Mirella
        ***************************************************************************/
        public bool Excluir(PlanoMensal pobj_PlanoMensal)
        {
            if (pobj_PlanoMensal.Cod_PlanoMensal != -1)
            {
                //Conexão com o BD
                SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

                string s_Sql = " DELETE FROM TB_PLANOMENSAL " +
                               " WHERE I_COD_PLANOMENSAL = @I_COD_PLANOMENSAL";

                SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
                obj_Com.Parameters.AddWithValue("@I_COD_PLANOMENSAL", pobj_PlanoMensal.Cod_PlanoMensal);

                try
                {
                    obj_Conn.Open();
                    obj_Com.ExecuteNonQuery();
                    obj_Conn.Close();
                    return true;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, " ERRO AO EXCLUIR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /*****************************************************************************
        * Nome da Classe: FindByCod
        *      Descrição: Responsável por encontrar o Registro (Tupla) do PlanoMensal na
        *      TB_PLANOMENSAL
        *      Parâmetro: Objeto PlanoMensal
        *        Retorno: PlanoMensal
        *    Dt. Criação: 09/05/2023
        *  Dt. Alteração: __/__/____
        *     Criada por: Mirella
        ******************************************************************************/
        public PlanoMensal FindByCod(PlanoMensal pobj_PlanoMensal)
        {
            {
                //Conexão com o BD
                SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

                string s_Sql = " SELECT * FROM TB_PLANOMENSAL " +
                               " WHERE I_COD_PLANOMENSAL = @I_COD_PLANOMENSAL";

                SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
                obj_Com.Parameters.AddWithValue("@I_COD_PLANOMENSAL", pobj_PlanoMensal.Cod_PlanoMensal);

                try
                {
                    obj_Conn.Open();
                    SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                    if (obj_Dtr.HasRows)
                    {
                        obj_Dtr.Read();
                        pobj_PlanoMensal.Nm_PlanoMensal = obj_Dtr["S_NM_PLANOMENSAL"].ToString();
                        pobj_PlanoMensal.Desc_PlanoMensal = obj_Dtr["S_DESC_PLANOMENSAL"].ToString();
                        pobj_PlanoMensal.Vlr_PlanoMensal = Convert.ToDouble(obj_Dtr["D_VLR_PLANOMENSAL"].ToString());
                        obj_Conn.Close();
                        obj_Dtr.Close();
                        return pobj_PlanoMensal;
                    }
                    else
                    {
                        obj_Conn.Close();
                        obj_Dtr.Close();
                        return new PlanoMensal(); //nova instância da classe
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, " ERRO AO ENCONTRAR POR CÓDIGO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new PlanoMensal();
                }
            }
            /*****************************************************************************
            * Nome da Classe: FindALL
            *      Descrição: Responsável por encontrar o Registro (Tupla) do PlanoMensal na
            *      TB_PLANOMENSAL
            *      Parâmetro: -
            *        Retorno: Lista<PlanoMensal>
            *    Dt. Criação: 09/05/2023
            *  Dt. Alteração: __/__/____
            *     Criada por: Mirella
            ******************************************************************************/
        }
        public List<PlanoMensal> FindAll()
        {
            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_PLANOMENSAL ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                List<PlanoMensal> Lst_PlanoMensal = new List<PlanoMensal>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        PlanoMensal obj_PlanoMensal = new PlanoMensal();
                        obj_PlanoMensal.Cod_PlanoMensal = Convert.ToInt16(obj_Dtr["I_COD_PLANOMENSAL"].ToString());
                        obj_PlanoMensal.Nm_PlanoMensal = obj_Dtr["S_NM_PLANOMENSAL"].ToString();
                        obj_PlanoMensal.Desc_PlanoMensal = obj_Dtr["S_DESC_PLANOMENSAL"].ToString();
                        obj_PlanoMensal.Vlr_PlanoMensal = Convert.ToDouble(obj_Dtr["D_VLR_PLANOMENSAL"].ToString());

                        Lst_PlanoMensal.Add(obj_PlanoMensal);
                    }
                }
                obj_Dtr.Read();
                obj_Dtr.Close();
                return Lst_PlanoMensal;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, " ERRO AO ENCONTRAR POR CÓDIGO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<PlanoMensal>();
            }
        }
    }
}
