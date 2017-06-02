using AdotaPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdotaPet.Controllers
{
    public class CategoriasControllers
    {
        private BaseDadosContainer contexto = new BaseDadosContainer();
        public void Adicionar(Categoria categoria)
        {
            contexto.CategoriaSet.Add(categoria);
            contexto.SaveChanges();
        }
        public List<Categoria> Listar()
        {
            return contexto.CategoriaSet.ToList();
        }
        public Categoria LocalizarPorID(int id)
        {
            return contexto.CategoriaSet.Find(id);
        }
        public Categoria LocalizarPorNome(string nome)
        {
            return contexto.CategoriaSet.Find(nome);
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