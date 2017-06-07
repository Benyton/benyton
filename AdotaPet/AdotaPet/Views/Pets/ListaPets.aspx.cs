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
                    Session["ID"] = gvPets.Rows[linha].Cells[2].Text;
                    //PetControllers ctrl = new PetControllers();
                    //Pet pet = new Pet();

                    //pet.CategoriaId = Convert.ToInt32(Session["Codigo"].ToString());
                    //pet.Nome = Session["Nome"].ToString();
                    //pet.Raca = Session["Raca"].ToString();
                    //pet.Sexo = Session["Sexo"].ToString();

                    //pet.Id = Convert.ToInt32(Session["ID"].ToString());

                    //ctrl.Editar(pet);

                    PetControllers ctrl = new PetControllers();
                    Pet pet = new Pet();

                    pet.Id = Convert.ToInt32(Session["ID"].ToString());

                    pet = ctrl.LocalizarPorID(pet.Id);

                    txtCodigo.Text = Convert.ToString(pet.CategoriaId);
                    txtNome.Text = pet.Nome;
                    txtRaca.Text = pet.Raca;
                    rdbSexo.SelectedValue = pet.Raca;

                    Session["Codigo"] = txtCodigo.Text;
                    Session["Nome"] = txtNome.Text;
                    Session["Raca"] = txtRaca.Text;
                    Session["Sexo"] = rdbSexo.SelectedValue;

                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}