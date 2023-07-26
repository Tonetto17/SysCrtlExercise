/********************************************************************
 *  Nome da Classe: FuncGeral
 *       Descrição: Esta classe é responsável por todas as funções e 
 *                  procedimentos coletivos.
 *     Dt. Criação: 17/05/2023
 *   Dt. Alteração: --/--/---- ( -- )
 *      Criada por: Mirella
 ********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  //para aceitar o form

namespace SysCtrlExercise
{
    class FuncGeral  //precisa instanciar para o HabilitaForm aparecer
    {
        //Primeira função: HabilitaForm - é um método
        /***********************************************************************
        *  Nome do Método: Habilita
        *       Parâmetro: Booleano
        *       Descrição: Este método é reponsável por Habilitar os componentes 
        *                  no formulário.
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: Mirella
        ************************************************************************/

        public void HabilitaForm(Form pobj_Form, bool b_habilita)  //passa o formulário por parâmetro, nesse caso pode ser qualquer um. Booleana por ser sim/não
        {
            foreach (Control pnl in pobj_Form.Controls)  //quer que encontre os painéis dentro do pobj_Form dentro dos Controls
            {
                if (pnl is Panel && pnl.Name == "pnl_Detalhes")
                {
                    foreach(Control obj in pnl.Controls)  //obj é o nome dado para cotrole
                    {
                        if (obj is TextBox && Convert.ToInt16(((TextBox)obj).Tag) != 1)  //se for diferente de 1 é falso
                        {
                            ((TextBox)obj).Enabled = b_habilita;    //forçando para ser um textbox enable, sempre habilitado. Vem por parâmetro
                        }
                        if (obj is CheckBox)
                        {
                            ((CheckBox)obj).Enabled = b_habilita;    
                        }
                    }
                }
            }
        }
        //Segunda função: LimpaForm
        /***********************************************************************
        *  Nome do Método: Limpa
        *       Parâmetro: Formulário
        *       Descrição: Este método é reponsável por limpar o formulário.
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: Mirella
        ************************************************************************/
        public void LimpaForm(Form pobj_Form)  
        {
            foreach (Control pnl in pobj_Form.Controls)  
            {
                if (pnl is Panel && pnl.Name == "pnl_Detalhes") 
                {
                    foreach (Control obj in pnl.Controls)  
                    {
                        if (obj is TextBox)
                        {
                            ((TextBox)obj).Clear();    
                        }
                        if (obj is CheckBox)
                        {
                            ((CheckBox)obj).Checked = false;
                        }
                    }
                }
            }
        }
        //Terceira função: StatusBtn
        /***********************************************************************
        *  Nome do Método: StatusBtn
        *       Parâmetro: Formulário, Int (1, 2 ou 3)
        *       Descrição: Reponsável por organizar os componentes editáveis; 
        *                  1 - (btn_novo) <- habilitado
        *                      (btn_alterar,  btn_excluir, btn_confirmar e 
        *                      btn_cancelar) <- Desabilitados
        *                  2 - (btn_novo, btn_alterar e btn_excluir) <- Habilitados
        *                      (btn_confirmar e btn_cancelar) <- Desabilitados
        *                  3 - (btn_confirmar e btn_cancelar) <- Habilitados
        *                      (btn_novo, btn_alterar e btn_excluir) <- Desabilitados
        *     Dt. Criação: 17/05/2023
        *                  
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: Mirella
        ************************************************************************/
        public void StatusBtn(Form pobj_Form, int pi_status)  
        {
            foreach (Control pnl in pobj_Form.Controls)  
            {
                if (pnl is Panel && pnl.Name == "pnl_Botoes") 
                {
                    foreach (Control obj in pnl.Controls)  
                    {
                        switch (pi_status)
                        {
                            case 1:
                                {
                                    //Botão Novo
                                    if (((Button)obj).Name == "btn_novo")
                                    {
                                        ((Button)obj).Enabled = true;
                                    }
                                    //Botão Alterar
                                    if (((Button)obj).Name == "btn_alterar")
                                    {
                                        ((Button)obj).Enabled = false;
                                    }
                                    //Botão Excluir
                                    if (((Button)obj).Name == "btn_excluir")
                                    {
                                        ((Button)obj).Enabled = false;
                                    }
                                    //Botão Confirmar
                                    if (((Button)obj).Name == "btn_confirmar")
                                    {
                                        ((Button)obj).Enabled = false;
                                    }                                 
                                    //Botão Cancelar
                                    if (((Button)obj).Name == "btn_cancelar")
                                    {
                                        ((Button)obj).Enabled = false;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    //Botão Novo
                                    if (((Button)obj).Name == "btn_novo")
                                    {
                                        ((Button)obj).Enabled = true;
                                    }
                                    //Botão Alterar
                                    if (((Button)obj).Name == "btn_alterar")
                                    {
                                        ((Button)obj).Enabled = true;
                                    }
                                    //Botão Excluir
                                    if (((Button)obj).Name == "btn_excluir")
                                    {
                                        ((Button)obj).Enabled = true;
                                    }
                                    //Botão Confirmar
                                    if (((Button)obj).Name == "btn_confirmar")
                                    {
                                        ((Button)obj).Enabled = false;
                                    }
                                    //Botão Cancelar
                                    if (((Button)obj).Name == "btn_cancelar")
                                    {
                                        ((Button)obj).Enabled = false;
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    //Botão Novo
                                    if (((Button)obj).Name == "btn_novo")
                                    {
                                        ((Button)obj).Enabled = false;
                                    }
                                    //Botão Alterar
                                    if (((Button)obj).Name == "btn_alterar")
                                    {
                                        ((Button)obj).Enabled = false;
                                    }
                                    //Botão Excluir
                                    if (((Button)obj).Name == "btn_excluir")
                                    {
                                        ((Button)obj).Enabled = false;
                                    }
                                    //Botão Confirmar
                                    if (((Button)obj).Name == "btn_confirmar")
                                    {
                                        ((Button)obj).Enabled = true;
                                    }
                                    //Botão Cancelar
                                    if (((Button)obj).Name == "btn_cancelar")
                                    {
                                        ((Button)obj).Enabled = true;
                                    }
                                    break;
                                }
                        }
                        if (obj is TextBox)
                        {
                            ((TextBox)obj).Clear();    
                        }
                        if (obj is CheckBox)
                        {
                            ((CheckBox)obj).Checked = false;
                        }
                    }
                }
            }
        }
    }
}
