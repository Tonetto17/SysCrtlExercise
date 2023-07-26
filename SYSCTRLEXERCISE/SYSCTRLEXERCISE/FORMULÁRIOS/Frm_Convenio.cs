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
    public partial class Frm_Convenio : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();  //foi instanciado
        public Convenio obj_Convenio_Atual = new Convenio();
        public Frm_Convenio()
        {
            InitializeComponent();
            //ToDo: Mirella - 24/05/2023
            obj_FuncGeral.HabilitaForm(this, false);  //habilita tela com falso
            obj_FuncGeral.StatusBtn(this, 1); //permite clicar no novo
            PopulaLista();
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaForm(this, true);
            obj_FuncGeral.LimpaForm(this);  //sempre que clicar na novo ele limpa a tela
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Convenio.Focus();
        }
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaForm(this, false);
            tbox_Nm_Convenio.Focus();
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            BDConvenio obj_BDConvenio = new BDConvenio();  //todo objeto é uma instância

            DialogResult dlg_Resp = MessageBox.Show("Confirma a exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);   //excluir é o título

            if (dlg_Resp == DialogResult.Yes)
            {
                if (obj_BDConvenio.Excluir(obj_Convenio_Atual)) //vai excluir o aparelho atual que está na tela
                {
                    MessageBox.Show("O Convenio" + obj_Convenio_Atual.Nm_Convenio + " foi excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (obj_Convenio_Atual.Cod_Convenio != -1)
            {
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaForm(obj_Convenio_Atual);
            }
            else
            {
                obj_FuncGeral.StatusBtn(this, 1);  //quando não tem nada na tela o status de botão é 1!!!
                obj_FuncGeral.LimpaForm(this);
            }
        }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //ToDo Mirella (24/05/2023): Validar os campos antes de gravar.
            BDConvenio obj_BDConvenio = new BDConvenio();

            if (obj_Convenio_Atual.Cod_Convenio != -1) //se o que está diferente de -1 no código é pq tem nada no banco, então será alterado
            {
                if (obj_BDConvenio.Alterar(obj_Convenio_Atual))   //retorna se alterou ou não
                {
                    MessageBox.Show("O Convenio" + obj_Convenio_Atual.Nm_Convenio + " foi alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                obj_Convenio_Atual.Cod_Convenio = obj_BDConvenio.Incluir(obj_Convenio_Atual);
                PopulaForm(obj_Convenio_Atual);
                MessageBox.Show("O Convenio" + obj_Convenio_Atual.Nm_Convenio + " foi incluído com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            obj_FuncGeral.HabilitaForm(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
            PopulaLista();    //mexeu no banco --> tem que popular a lista
        }
        private void lbox_Convenios_Click(object sender, EventArgs e)  //evento é um click na listbox, representada por object sender
        {
            if (((ListBox)sender).SelectedIndex != -1)  //força o sender ser um listbox, pois é um objeto. Sendo listbox ele tem propriedades diferentes do objeto
            {
                BDConvenio obj_BDConvenio = new BDConvenio();  //instânciando um novo objeto
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
                obj_Convenio_Atual.Cod_Convenio = Convert.ToInt16(s_Lin.Substring(0, i_Pos));
                obj_Convenio_Atual = obj_BDConvenio.FindByCod(obj_Convenio_Atual);
                PopulaForm(obj_Convenio_Atual);   //para adicionar ao formulário
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
            //Instância da classe BDConvenio
            BDConvenio obj_BDConvenio = new BDConvenio();

            //Instância da classe list
            List<Convenio> obj_Lista = new List<Convenio>();

            //Limpar o ListBox do formulário
            lbox_Convenios.Items.Clear();

            //Receber a Lista de dados do BD
            obj_Lista = obj_BDConvenio.FindAll();

            if (obj_Lista != null)
            {
                for (int i = 0; i < obj_Lista.Count; i++)
                {
                    lbox_Convenios.Items.Add(obj_Lista[i].Cod_Convenio.ToString() + "-" + obj_Lista[i].Nm_Convenio);
                }
            }
        }
        /********************************************************************
        *       Nome da Classe: PopulaObjeto
        *            Descrição: Responsavel por popular o objeto Atual
        *                       cadastrados no Banco de Dados do BD
        *          Dt. Criação: 24/05/2023
        *        Dt. Alteração: --/--/---- ( -- )
        *           Criada por: Mirella
        ********************************************************************/
        private Convenio PopulaObjeto()
        {
            //Instancia do objeto
            Convenio obj_Convenio = new Convenio();


            if (tbox_Cod_Convenio.Text != "")
            {
                obj_Convenio.Cod_Convenio = Convert.ToInt16(tbox_Cod_Convenio.Text);
            }

            obj_Convenio.Nm_Convenio = tbox_Nm_Convenio.Text;

            if (rdbtn_Particular.Checked)
            {
                obj_Convenio.Tp_Convenio = 0;
            }
            else
            {
                obj_Convenio.Tp_Convenio = 1;
            }

            return obj_Convenio;
        }
        /********************************************************************
        *       Nome da Classe: PopulaForm
        *            Descrição: Responsavel por popular o Formulario
        *                       cadastrados no Banco de Dados do BD
        *          Dt. Criação: 24/05/2023
        *        Dt. Alteração: --/--/---- ( -- )
        *           Criada por: Mirella
        ********************************************************************/
        private void PopulaForm(Convenio pobj_Convenio)
        {
            tbox_Cod_Convenio.Text = pobj_Convenio.Cod_Convenio.ToString();
            tbox_Nm_Convenio.Text = pobj_Convenio.Nm_Convenio;
            tbox_Nro_Convenio.Text = pobj_Convenio.Nro_Convenio.ToString();

            rdbtn_Particular.Checked = pobj_Convenio.Tp_Convenio == 0;
            rdbtn_Empresa.Checked = pobj_Convenio.Tp_Convenio == 1;

            cbbox_Cat_Convenio.Text = pobj_Convenio.Cat_Convenio;
        }
    }
}
