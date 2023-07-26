using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCtrlExercise
{
    public partial class Frm_Cliente : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();  //foi instanciado
        public Cliente obj_Cliente_Atual = new Cliente();

        public Frm_Cliente()
        {
            InitializeComponent();
            obj_FuncGeral.HabilitaForm(this, true);
            obj_FuncGeral.StatusBtn(this, 1);
            PopulaLista();
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaForm(this, true);
            obj_FuncGeral.LimpaForm(this);  //sempre que clicar na novo ele limpa a tela
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Pessoa.Focus();
        }
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.StatusBtn(this, 3);
            obj_FuncGeral.HabilitaForm(this, false);
            tbox_Nm_Pessoa.Focus();
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            BDCliente obj_BDCliente = new BDCliente();  //todo objeto é uma instância
            BDPessoa obj_BDPessoa = new BDPessoa();
            DialogResult dlg_Resp = MessageBox.Show("Confirma a exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);   //excluir é o título

            if (dlg_Resp == DialogResult.Yes)
            {
                obj_Cliente_Atual.Cod_Pessoa = obj_Cliente_Atual.Cod_Pessoa;

                if (obj_BDCliente.Excluir(obj_Cliente_Atual)) 
                {
                    MessageBox.Show("O Cliente" + obj_Cliente_Atual.Nm_Pessoa + " foi excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                obj_FuncGeral.LimpaForm(this);
                obj_FuncGeral.HabilitaForm(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaForm(this, false);

            if (obj_Cliente_Atual.Cod_Cliente != -1)
            {
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaForm(obj_Cliente_Atual);
            }
            else
            {
                obj_FuncGeral.StatusBtn(this, 1);  //quando não tem nada na tela o status de botão é 1!!!
                obj_FuncGeral.LimpaForm(this);
            }
        }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //ToDo Mirella (29/05/2023): Validar os campos antes de gravar.
            BDCliente obj_BDCliente = new BDCliente();

            obj_Cliente_Atual = new Cliente();

            if (obj_Cliente_Atual.Cod_Cliente != -1) //se o que está diferente de -1 no código é pq tem nada no banco, então será alterado
            {
                if (obj_BDCliente.Alterar(obj_Cliente_Atual))   //retorna se alterou ou não
                {
                    MessageBox.Show("O Cliente" + obj_Cliente_Atual.Nm_Pessoa + " foi alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                obj_Cliente_Atual.Cod_Cliente = obj_BDCliente.Incluir(obj_Cliente_Atual);
                PopulaForm(obj_Cliente_Atual);
                MessageBox.Show("O Cliente" + obj_Cliente_Atual.Nm_Pessoa + " foi incluído com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            obj_FuncGeral.HabilitaForm(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
            PopulaLista();    //mexeu no banco --> tem que popular a lista
        }
        private void lbox_Clientes_Click(object sender, EventArgs e)  //evento é um click na listbox, representada por object sender
        {
            if (((ListBox)sender).SelectedIndex != -1)  //força o sender ser um listbox, pois é um objeto. Sendo listbox ele tem propriedades diferentes do objeto
            {
                BDCliente obj_BDCliente = new BDCliente();  //instânciando um novo objeto
                string s_Lin = ((ListBox)sender).Items[((ListBox)sender).SelectedIndex].ToString();
                int i_Pos = 0;

                for (int i = 0; i < s_Lin.Length; i++)  //o i tem que ser menor que a linha. s_Lin.Length conta os caracteres de acordo com a posição
                {
                    if (s_Lin.Substring(i, 1) == "-")
                    {
                        i_Pos = i;  //é a quantidade de posição do caractere "-"
                        break;
                    }
                }
                obj_Cliente_Atual.Cod_Cliente = Convert.ToInt16(s_Lin.Substring(0, i_Pos));
                obj_Cliente_Atual = obj_BDCliente.FindByCod(obj_Cliente_Atual);
                PopulaForm(obj_Cliente_Atual);   //para adicionar ao formulário
                obj_FuncGeral.HabilitaForm(this, false);   //para travar a tela (?)
                obj_FuncGeral.StatusBtn(this, 2);
            }
        }
        /***************************************************************************
        *       Nome da classe: PopulaLista
        *            Descrição: Responsável por popular o ListBox com os registros
        *                       (Tupla) do aparelho cadastrados no BD.
        *          Dt. Criação: 24/05/2023
        *        Dt. Alteração: --/--/---- (--)
        *           Criada por: Mirella
        *****************************************************************************/

        private void PopulaLista()
        {
            //Instância da classe BDCliente
            BDCliente obj_BDCliente = new BDCliente();

            //Instância da classe list
            List<Cliente> obj_Lista = new List<Cliente>();

            //Limpar o ListBox do formulário
            lbox_Clientes.Items.Clear();

            //Receber a Lista de dados do BD
            obj_Lista = obj_BDCliente.FindAll();

            if (obj_Lista != null)
            {
                for (int i = 0; i < obj_Lista.Count; i++)
                {
                    lbox_Clientes.Items.Add(obj_Lista[i].Cod_Cliente.ToString() + "-" + obj_Lista[i].Nm_Pessoa);
                }
            }
        }
        /********************************************************************
        *       Nome da Classe: PopulaObjeto
        *            Descrição: Responsavel por popular o objeto Atual
        *                       cadastrados no Banco de Dados do BD
        *          Dt. Criação: 29/05/2023
        *        Dt. Alteração: --/--/---- ( -- )
        *           Criada por: Mirella
        ********************************************************************/
        private Cliente PopulaObjeto()
        {
            //Instancia do objeto
            Cliente obj_Cliente = new Cliente();


            if (tbox_Cod_Cliente.Text != "")
            {
                obj_Cliente.Cod_Cliente = Convert.ToInt16(tbox_Cod_Cliente.Text);
            }

            obj_Cliente.Nm_Pessoa = tbox_Nm_Pessoa.Text;

            if (rdbtn_Masculino.Checked)
            {
                obj_Cliente.Gen_Pessoa = 0;
            }
            else
            {
                obj_Cliente.Gen_Pessoa = 1;
            }

            return obj_Cliente;
        }
        /********************************************************************
        *       Nome da Classe: PopulaForm
        *            Descrição: Responsavel por popular o Formulario
        *                       cadastrados no Banco de Dados do BD
        *          Dt. Criação: 29/05/2023
        *        Dt. Alteração: --/--/---- ( -- )
        *           Criada por: Mirella
        ********************************************************************/
        private void PopulaForm(Cliente pobj_Cliente)
        {
            tbox_Cod_Cliente.Text = pobj_Cliente.Cod_Cliente.ToString();
            tbox_Nm_Pessoa.Text = pobj_Cliente.Nm_Pessoa;

            tbox_CPF_Pessoa.Text = pobj_Cliente.CPF_Pessoa.ToString();
            tbox_Cel_Pessoa.Text = pobj_Cliente.Cel_Pessoa.ToString();
            tbox_Mail_Pessoa.Text = pobj_Cliente.Mail_Pessoa.ToString();
            tbox_End_Pessoa.Text = pobj_Cliente.End_Pessoa.ToString();
            tbox_Bai_Pessoa.Text = pobj_Cliente.Bai_Pessoa.ToString();
            tbox_Cid_Pessoa.Text = pobj_Cliente.Cid_Pessoa.ToString();
            tbox_UF_Pessoa.Text = pobj_Cliente.UF_Pessoa.ToString();
            tbox_CEP_Pessoa.Text = pobj_Cliente.CEP_Pessoa.ToString();

            rdbtn_Masculino.Checked = pobj_Cliente.Gen_Pessoa == 0;
            rdbtn_Feminino.Checked = pobj_Cliente.Gen_Pessoa == 1;
        }
    }
}
