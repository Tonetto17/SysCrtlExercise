/**************************************************************************
* Nome da Classe: BDConvenio
*      Descrição: Esta classe de Controle de Objeto negocia com o Banco de 
*                 Dados os métodos públicos: Incluir, Excluir, Alterar, 
*                 FindByCodConvenio e FindAllConvenio
*    Dt. Criação: 10/05/2023
*  Dt. Alteração: __/__/____
*     Criada por: Mirella
***************************************************************************/

using SYSCTRLEXERCISE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSCTRLEXERCISE
{
    class BDConvenio
    {
        //Método Destruct para instanciados 
        ~BDConvenio()
        {

        }
        /**************************************************************************
        * Nome da Classe: Incluir
        *      Descrição: Responsável por incluir o Registro (Tupla) do Convenio na
        *      TB_CONVENIO
        *      Parâmetro: Objeto Convenio
        *        Retorno: Código do Convenio (PK - Primary Key)
        *    Dt. Criação: 10/05/2023
        *  Dt. Alteração: __/__/____
        *     Criada por: Mirella
        ***************************************************************************/
        public int Incluir(Convenio pobj_Convenio)  //p0bj é o parâmetro do objeto
        {
            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());  //instanciando conexão; conecta c/ BD

            string s_Sql = " INSERT INTO TB_CONVENIO " +
                           " ( " +
                           " S_NM_CONVENIO, " +
                           " S_NRO_CONVENIO, " +
                           " I_TP_CONVENIO, " +
                           " S_CAT_CONVENIO " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @S_NM_CONVENIO, " +
                           " @S_NRO_CONVENIO, " +
                           " @I_TP_CONVENIO, " +
                           " @S_CAT_CONVENIO " +
                           " ); " +
                           " SELECT IDENT_CURRENT('TB_CONVENIO') AS COD";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@S_NM_CONVENIO", pobj_Convenio.Nm_Convenio);
            obj_Com.Parameters.AddWithValue("@S_NRO_CONVENIO", pobj_Convenio.Nro_Convenio);
            obj_Com.Parameters.AddWithValue("@I_TP_CONVENIO", pobj_Convenio.Tp_Convenio);
            obj_Com.Parameters.AddWithValue("@S_CAT_CONVENIO", pobj_Convenio.Cat_Convenio);

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
                return pobj_Convenio.Cod_Convenio;
            }
        }
        /**************************************************************************
        * Nome da Classe: Alterar
        *      Descrição: Responsável por alterar o Registro (Tupla) do Convenio na
        *      TB_CONVENIO
        *      Parâmetro: Objeto Convenio
        *        Retorno: bool
        *    Dt. Criação: 10/05/2023
        *  Dt. Alteração: __/__/____
        *     Criada por: Mirella
        ***************************************************************************/
        public bool Alterar(Convenio pobj_Convenio)
        {
            if (pobj_Convenio.Cod_Convenio != -1)
            {
                //Conexão com o BD
                SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());



                string s_Sql = " UPDATE TB_CONVENIO SET " +
                               " S_NM_CONVENIO = @S_NM_CONVENIO " +
                               " S_NRO_CONVENIO = @S_NRO_CONVENIO " +
                               " I_TP_CONVENIO = @I_TP_CONVENIO " +
                               " S_CAT_CONVENIO = @S_CAT_CONVENIO " +
                               " WHERE I_COD_CONVENIO = @I_COD_CONVENIO";
                SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
                obj_Com.Parameters.AddWithValue("@I_COD_CONVENIO", pobj_Convenio.Cod_Convenio);
                obj_Com.Parameters.AddWithValue("@S_NM_CONVENIO", pobj_Convenio.Nm_Convenio);
                obj_Com.Parameters.AddWithValue("@S_NRO_CONVENIO", pobj_Convenio.Nro_Convenio);
                obj_Com.Parameters.AddWithValue("@I_TP_CONVENIO", pobj_Convenio.Tp_Convenio);
                obj_Com.Parameters.AddWithValue("@S_CAT_CONVENIO", pobj_Convenio.Cat_Convenio);

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
        *      Descrição: Responsável por excluir o Registro (Tupla) do Convenio na
        *      TB_CONVENIO
        *      Parâmetro: Objeto Convenio
        *        Retorno: bool
        *    Dt. Criação: 10/05/2023
        *  Dt. Alteração: __/__/____
        *     Criada por: Mirella
        ***************************************************************************/
        public bool Excluir(Convenio pobj_Convenio)
        {
            if (pobj_Convenio.Cod_Convenio != -1)
            {
                //Conexão com o BD
                SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

                string s_Sql = " DELETE FROM TB_CONVENIO " +
                               " WHERE I_COD_CONVENIO = @I_COD_CONVENIO";

                SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
                obj_Com.Parameters.AddWithValue("@I_COD_CONVENIO", pobj_Convenio.Cod_Convenio);

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
        *      Descrição: Responsável por encontrar o Registro (Tupla) do Convenio na
        *      TB_CONVENIO
        *      Parâmetro: Objeto Convenio
        *        Retorno: Convenio
        *    Dt. Criação: 10/05/2023
        *  Dt. Alteração: __/__/____
        *     Criada por: Mirella
        ******************************************************************************/
        public Convenio FindByCod(Convenio pobj_Convenio)
        {
            {
                //Conexão com o BD
                SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

                string s_Sql = " SELECT * FROM TB_CONVENIO " +
                               " WHERE I_COD_CONVENIO = @I_COD_CONVENIO";

                SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
                obj_Com.Parameters.AddWithValue("@I_COD_CONVENIO", pobj_Convenio.Cod_Convenio);

                try
                {
                    obj_Conn.Open();
                    SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                    if (obj_Dtr.HasRows)
                    {
                        obj_Dtr.Read();
                        pobj_Convenio.Nm_Convenio = obj_Dtr["S_NM_CONVENIO"].ToString();
                        pobj_Convenio.Nro_Convenio = obj_Dtr["S_NRO_CONVENIO"].ToString();
                        pobj_Convenio.Tp_Convenio = Convert.ToInt16(obj_Dtr["I_TP_CONVENIO"].ToString());
                        pobj_Convenio.Cat_Convenio = obj_Dtr["S_CAT_CONVENIO"].ToString();
                        obj_Conn.Close();
                        obj_Dtr.Close();
                        return pobj_Convenio;
                    }
                    else
                    {
                        obj_Conn.Close();
                        obj_Dtr.Close();
                        return new Convenio(); //nova instância da classe
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, " ERRO AO ENCONTRAR POR CÓDIGO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new Convenio();
                }
            }
            /*****************************************************************************
            * Nome da Classe: FindALL
            *      Descrição: Responsável por encontrar o Registro (Tupla) do Convenio na
            *      TB_CONVENIO
            *      Parâmetro: -
            *        Retorno: Lista<Convenio>
            *    Dt. Criação: 10/05/2023
            *  Dt. Alteração: __/__/____
            *     Criada por: Mirella
            ******************************************************************************/
        }
        public List<Convenio> FindAll()
        {
            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_CONVENIO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                List<Convenio> Lst_Convenio = new List<Convenio>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        Convenio obj_Convenio = new Convenio();
                        obj_Convenio.Cod_Convenio = Convert.ToInt16(obj_Dtr["I_COD_CONVENIO"].ToString());
                        obj_Convenio.Nm_Convenio = obj_Dtr["S_NM_CONVENIO"].ToString();
                        obj_Convenio.Nro_Convenio = obj_Dtr["S_NRO_CONVENIO"].ToString();
                        obj_Convenio.Tp_Convenio = Convert.ToInt16(obj_Dtr["I_TP_CONVENIO"].ToString());
                        obj_Convenio.Cat_Convenio = obj_Dtr["S_CAT_CONVENIO"].ToString();

                        Lst_Convenio.Add(obj_Convenio);
                    }
                }
                obj_Dtr.Read();
                obj_Dtr.Close();
                return Lst_Convenio;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, " ERRO AO ENCONTRAR POR CÓDIGO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Convenio>();
            }
        }
    }
}
