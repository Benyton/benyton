using Aula2505.Controllers;
using Aula2505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2505.Views.Categorias
{
    public partial class CadastroCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Session["Nome"] = txtNome.Text;
            Session["Descricao"] = txtDescricao.Text;
            Session["Ativo"] = ckbAtivo.Checked;

            CategoriasControllers ctrl = new CategoriasControllers();

            Categoria cat = new Categoria();

            cat.Nome = Session["Nome"].ToString();
            cat.Descricao = Session["Descricao"].ToString();
            cat.Ativo = Convert.ToBoolean(Session["Ativo"].ToString());

            ctrl.Adicionar(cat);
            //ctrl.Categorias.Add(cat);
            //ctrl.SaveChanges();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            ckbAtivo.Checked = false;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CategoriasControllers ctrl = new CategoriasControllers();
            Categoria cat = new Categoria();

            Session["Nome"] = txtNome.Text;

            cat.Id = Convert.ToInt32(Session["Nome"].ToString());

            cat = ctrl.LocalizarPorID(cat.Id);

            txtNome.Text = cat.Nome;
            txtDescricao.Text = cat.Descricao;
            ckbAtivo.Checked = cat.Ativo;

            Session["Nome"] = txtNome.Text;
            Session["Descricao"] = txtDescricao.Text;
            Session["Ativo"] = ckbAtivo.Checked;
            Session["ID"] = cat.Id;

        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            CategoriasControllers ctrl = new CategoriasControllers();
            Categoria cat = new Categoria();

            cat.Id = Convert.ToInt32(Session["ID"].ToString());

            //cat.Id = Convert.ToInt32(Session["Nome"].ToString());
            //cat = ctrl.LocalizarPorID(cat.Id);

            cat.Nome = txtNome.Text;
            cat.Descricao = txtDescricao.Text;
            cat.Ativo = ckbAtivo.Checked;

            ctrl.Editar(cat);
        }
    }
}