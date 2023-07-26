using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCtrlExercise
{
    public partial class Frm_Aparelho : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();  //foi instanciado
        public Aparelho obj_Aparelho_Atual = new Aparelho();
        public Frm_Aparelho()
        {
            InitializeComponent();  //inicia formulário
            //ToDo: Mirella - 17/05/2023
            obj_FuncGeral.HabilitaForm(this, false);  //habilita tela com falso
            obj_FuncGeral.StatusBtn(this, 1); //permite clicar no novo
            PopulaLista();
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaForm(this, true);
            obj_FuncGeral.LimpaForm(this);  //sempre que clicar na novo ele limpa a tela
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Aparelho.Focus();
        }
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaForm(this, false);
            tbox_Nm_Aparelho.Focus();
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            BDAparelho obj_BDAparelho = new BDAparelho();  //todo objeto é uma instância

            DialogResult dlg_Resp = MessageBox.Show("Confirma a exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);   //excluir é o título
            
            if (dlg_Resp == DialogResult.Yes)
            {
                if (obj_BDAparelho.Excluir(obj_Aparelho_Atual)) //vai excluir o aparelho atual que está na tela
                {
                    MessageBox.Show("O Aparelho" + obj_Aparelho_Atual.Nm_Aparelho +" foi excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (obj_Aparelho_Atual.Cod_Aparelho != -1) 
            {
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaForm(obj_Aparelho_Atual);
            }
            else
            {
                obj_FuncGeral.StatusBtn(this, 1);  //quando não tem nada na tela o status de botão é 1!!!
                obj_FuncGeral.LimpaForm(this);  
            }
        }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //ToDo Mirella (23/05/2023): Validar os campos antes de gravar.
            BDAparelho obj_BDAparelho= new BDAparelho();

            if (obj_Aparelho_Atual.Cod_Aparelho != -1) //se o que está diferente de -1 no código é pq tem nada no banco, então será alterado
            {
                if (obj_BDAparelho.Alterar(obj_Aparelho_Atual))   //retorna se alterou ou não
                {
                    MessageBox.Show("O Aparelho" + obj_Aparelho_Atual.Nm_Aparelho + " foi alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                obj_Aparelho_Atual.Cod_Aparelho = obj_BDAparelho.Incluir(obj_Aparelho_Atual);   
                PopulaForm(obj_Aparelho_Atual);
                MessageBox.Show("O Aparelho" + obj_Aparelho_Atual.Nm_Aparelho + " foi incluído com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            obj_FuncGeral.HabilitaForm(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
            PopulaLista();    //mexeu no banco --> tem que popular a lista
        }
        private void lbox_Aparelhos_Click(object sender, EventArgs e)  //evento é um click na listbox, representada por object sender
        {
            if (((ListBox)sender).SelectedIndex != -1)  //força o sender ser um listbox, pois é um objeto. Sendo listbox ele tem propriedades diferentes do objeto
            {
                BDAparelho obj_BDAparelho = new BDAparelho();  //instânciando um novo objeto
                string s_Lin = ((ListBox)sender).Items[((ListBox)sender).SelectedIndex].ToString();
                int i_Pos = 0;

                for (int i = 0; i < s_Lin.Length; i++)  //o i tem que ser menor que a linha. s_Lin.Length conta os caracteres de acordo com a posição
                {
                    if (s_Lin.Substring(i,1) == "-")
                    {
                        i_Pos = i;  //é a quantidade de posição do caractere "-"
                        break;
                    }
                }
                obj_Aparelho_Atual.Cod_Aparelho = Convert.ToInt16(s_Lin.Substring(0,i_Pos));
                obj_Aparelho_Atual = obj_BDAparelho.FindByCod(obj_Aparelho_Atual);
                PopulaForm(obj_Aparelho_Atual);   //para adicionar ao formulário
                obj_FuncGeral.HabilitaForm(this, false);   //para travar a tela (?)
                obj_FuncGeral.StatusBtn(this, 2);
            }
        }
        /***************************************************************************
        *       Nome da classe: PopulaLista
        *            Descrição: Responsável por popular o ListBox com os registros
        *                       (Tupla) do aparelho cadastrados no BD.
        *          Dt. Criação: 17/05/2023
        *        Dt. Alteração: --/--/---- (--)
        *           Criada por: Mirella
        *****************************************************************************/

        private void PopulaLista()
        {
            //Instância da classe BDAparelho
            BDAparelho obj_BDAparelho = new BDAparelho();

            //Instância da classe list
            List<Aparelho> obj_Lista = new List<Aparelho>();

            //Limpar o ListBox do formulário
            lbox_Aparelhos.Items.Clear();

            //Receber a Lista de dados do BD
            obj_Lista = obj_BDAparelho.FindAll();

            if (obj_Lista != null)
            {
                for (int i = 0; i < obj_Lista.Count; i++)
                {
                    lbox_Aparelhos.Items.Add(obj_Lista[i].Cod_Aparelho.ToString() + "-" + obj_Lista[i].Nm_Aparelho);
                }
            }
        }
        /********************************************************************
        *       Nome da Classe: PopulaObjeto
        *            Descrição: Responsavel por popular o objeto Atual
        *                       cadastrados no Banco de Dados do BD
        *          Dt. Criação: 22/05/2023
        *        Dt. Alteração: --/--/---- ( -- )
        *           Criada por: Mirella
        ********************************************************************/
        private Aparelho PopulaObjeto()
        {
            //Instancia do objeto
            Aparelho obj_Aparelho = new Aparelho();


            if (tbox_Cod_Aparelho.Text != "")
            {
                obj_Aparelho.Cod_Aparelho = Convert.ToInt16(tbox_Cod_Aparelho.Text);
            }

            obj_Aparelho.Nm_Aparelho = tbox_Nm_Aparelho.Text;

            if (chbox_Superior.Checked)
            {
                obj_Aparelho.Grup_Aparelho += 1;
            }
            else
            {
                obj_Aparelho.Grup_Aparelho += 0;
            }

            if (chbox_Inferior.Checked)
            {
                obj_Aparelho.Grup_Aparelho += 1;
            }
            else
            {
                obj_Aparelho.Grup_Aparelho += 0;
            }

            if (chbox_Tronco.Checked)
            {
                obj_Aparelho.Grup_Aparelho += 1;
            }
            else
            {
                obj_Aparelho.Grup_Aparelho += 0;
            }

            return obj_Aparelho;
        }
        /********************************************************************
        *       Nome da Classe: PopulaForm
        *            Descrição: Responsavel por popular o Formulario
        *                       cadastrados no Banco de Dados do BD
        *          Dt. Criação: 22/05/2023
        *        Dt. Alteração: --/--/---- ( -- )
        *           Criada por: Mirella
        ********************************************************************/
        private void PopulaForm(Aparelho pobj_Aparelho)
        {
            tbox_Cod_Aparelho.Text = pobj_Aparelho.Cod_Aparelho.ToString();
            tbox_Nm_Aparelho.Text = pobj_Aparelho.Nm_Aparelho;
            chbox_Superior.Checked = pobj_Aparelho.Grup_Aparelho.Substring(0, 1) == "1";
            chbox_Inferior.Checked = pobj_Aparelho.Grup_Aparelho.Substring(1, 1) == "1";
            chbox_Tronco.Checked = pobj_Aparelho.Grup_Aparelho.Substring(2, 1) == "1";
        }
    }
}
