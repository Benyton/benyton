using AdotaPet.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdotaPet.Views.Categorias
{
    public partial class ListaCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriasControllers ctrl = new CategoriasControllers();

            gvCategorias.DataSource = ctrl.Listar();

            gvCategorias.DataBind();

        }
        protected void gvCategorias_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Detectando a linha que foi clicada
            int linha = Convert.ToInt32(e.CommandArgument);

            // Recuperando o id do Objeto (lembrando que 2, do Cells[2], é a coluna onde esta o id)
            int idObjeto = Convert.ToInt32(gvCategorias.Rows[linha].Cells[2].Text);

            // Nome do comando para saber a acao
            string command = e.CommandName;

            // Proximos passos

            // adicionar id na Session

            if (command.Equals("Excluir"))
            {
                // Redirecionando para tela de exclusao
                Response.Redirect("Excluir.aspx");
            }
            else
            {
                if (command.Equals("Editar"))
                {
                    // Redirecionando para tela de edicao
                    Response.Redirect("Editar.aspx");
                }
            }
        }
    }
}
        
    
