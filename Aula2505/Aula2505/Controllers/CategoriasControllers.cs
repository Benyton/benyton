using Aula2505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula2505.Controllers
{
    public class CategoriasControllers
    {
        private BaseDadosContainer contexto = new BaseDadosContainer();
        public void Adicionar(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public List<Categoria> Listar()
        {
            return contexto.Categorias.ToList();
        } 
        public Categoria LocalizarPorID(int id)
        {
            return contexto.Categorias.Find(id);
        }
        public Categoria LocalizarPorNome(string nome)
        {
            return contexto.Categorias.Find(nome);
        }
        public void Editar(Categoria categoria)
        {
            contexto.Entry(categoria).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public void Excluir(Categoria categoria)
        {
            contexto.Entry(categoria).State =
                System.Data.Entity.EntityState.Deleted;

            contexto.SaveChanges();
        }
    }
}