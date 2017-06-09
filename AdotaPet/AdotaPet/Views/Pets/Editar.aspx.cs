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
            PetControllers ctrl = new PetControllers();
            Pet pet = new Pet();

            pet.Id = Convert.ToInt32(Session["ID"].ToString());

            pet = ctrl.LocalizarPorID(pet.Id);

            txtCodigo.Text = Convert.ToString(pet.CategoriaId);
            txtNome.Text = pet.Nome;
            txtRaca.Text = pet.Raca;
            rdbSexo.SelectedValue = pet.Sexo;

            Session["Codigo"] = txtCodigo.Text;
            Session["Nome"] = txtNome.Text;
            Session["Raca"] = txtRaca.Text;
            Session["Sexo"] = rdbSexo.SelectedValue;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            PetControllers ctrl = new PetControllers();
            Pet pet = new Pet();

            pet.Id = Convert.ToInt32(Session["ID"].ToString());

            //pet.CategoriaId = Convert.ToInt32(Session["Codigo"].ToString());
            //pet.Nome = Session["Nome"].ToString();
            //pet.Raca = Session["Raca"].ToString();
            //pet.Sexo = Session["Sexo"].ToString();

            pet.CategoriaId = Convert.ToInt32(txtCodigo.Text);
            pet.Nome = txtNome.Text;
            pet.Raca = txtRaca.Text;
            pet.Sexo = rdbSexo.SelectedValue;

            ctrl.Editar(pet);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}