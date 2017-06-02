using AdotaPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdotaPet.Controllers
{
    public class PetControllers
    {
        private BaseDadosContainer contexto = new BaseDadosContainer();
        public void Adicionar(Pet pet)
        {
            contexto.PetSet.Add(pet);
            contexto.SaveChanges();
        }
        public List<Pet> Listar()
        {
            return contexto.PetSet.ToList();
        }
        public Pet LocalizarPorID(int id)
        {
            return contexto.PetSet.Find(id);
        }
        public void Editar(Pet pet)
        {
            contexto.Entry(pet).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public void Excluir(Pet pet)
        {
            contexto.Entry(pet).State =
                System.Data.Entity.EntityState.Deleted;

            contexto.SaveChanges();
        }
    }
}