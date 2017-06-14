using AdotaPet.Controllers;
using AdotaPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdotaPet.Views.Pets
{
    public partial class ListaPets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PetControllers pet = new PetControllers();

            gvPets.DataSource = pet.Listar();

            gvPets.DataBind();
        }

        protected void gvCategorias_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Detectando a linha que foi clicada
            int linha = Convert.ToInt32(e.CommandArgument);

            // Recuperando o id do Objeto (lembrando que 2, do Cells[2], é a coluna onde esta o id)
            int idObjeto = Convert.ToInt32(gvPets.Rows[linha].Cells[2].Text);

            // Nome do comando para saber a acao
            string command = e.CommandName;

            // adicionar id na Session

            if (command.Equals("Excluir"))
            {
                // Redirecionando para tela de exclusao
                Session["ID"] = gvPets.Rows[linha].Cells[2].Text;
                Response.Redirect("Editar.aspx");
            }
            else
            {
                if (command.Equals("Editar"))
                {
                    Session["ID"] = gvPets.Rows[linha].Cells[2].Text;
                    Response.Redirect("Editar.aspx");
                }
            }
        }
        protected void gvPets_SelectedIndexChanged(object sender, EventArgs e)
        {
                    Response.Redirect("Editar.aspx");
        }
    }
}