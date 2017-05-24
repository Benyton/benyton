using Aula2305_EF_DBF.Models;
using Aula2305_EF_DBF.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2305_EF_DBF.Views.Produto
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //contexto (referencia paa o banco de dados)

            var produtosCadastrados = contexto.Produto;

            gvProdutos.DataSource = contexto.Categoria.ToList();

            gvProdutos.DataBind();


        }
    }
}