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
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Session["Codigo"] = txtCodigo.Text;
            Session["Nome"] = txtNome.Text;
            Session["Raca"] = txtRaca.Text;
            Session["Sexo"] = rdbSexo.SelectedValue;

            PetControllers ctrl = new PetControllers();
            Pet pet = new Pet();

            pet.Id = Convert.ToInt32(Session["ID"].ToString());

            pet.CategoriaId = Convert.ToInt32(Session["Codigo"].ToString());
            pet.Nome = Session["Nome"].ToString();
            pet.Raca = Session["Raca"].ToString();
            pet.Sexo = Session["Sexo"].ToString();

            ctrl.Editar(pet);
        }
    }
}