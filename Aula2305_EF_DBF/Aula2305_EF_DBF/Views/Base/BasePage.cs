using Aula2305_EF_DBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula2305_EF_DBF.Views.Base
{
    public class BasePage :System.Web.UI.Page
    {
        protected LojaDBEntities contexto = new LojaDBEntities();
    }
}