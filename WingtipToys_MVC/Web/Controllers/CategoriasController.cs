using BaseModels;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class CategoriasController : Controller
    {
        //Contexto do banco de dados
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Categorias
        public ActionResult Index()
        {
            var categorias = db.Categorias.ToList();
            return View(categorias);
        }

        //cadastrar nova categoria
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                db.Categorias.Add(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
                return View(categoria);
        }

        //------------- Detalhes -------------
        //GET
        public ActionResult Details(int? id)
        {
            //Não passou id?
            if(id == null/*idHasValue*/)
            {
                //erro http 400
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = db.Categorias.Find(id);

            //Não encontrou o objeto com este ID
            if(categoria == null)
            {
                //erro http 404
                return HttpNotFound();
            }
            //Caso a categoria sena encontrada
            return View(categoria);
        }

        // ---------------- Editar -----------
        //GET
        public ActionResult Edit(int? id)
        {
            //Não passou id?
            if (id == null/*idHasValue*/)
            {
                //erro http 400
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = db.Categorias.Find(id);

            //Não encontrou o objeto com este ID
            if (categoria == null)
            {
                //erro http 404
                return HttpNotFound();
            }
            //Caso a categoria sena encontrada
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            if(ModelState.IsValid)
            {
                db.Entry(categoria).State =
                    System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        //-----------Excluir -----------
        public ActionResult Delete (int? id)
        {
            //Não passou id?
            if (id == null/*idHasValue*/)
            {
                //erro http 400
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = db.Categorias.Find(id);

            //Não encontrou o objeto com este ID
            if (categoria == null)
            {
                //erro http 404
                return HttpNotFound();
            }
            //Caso a categoria sena encontrada
            return View(categoria);
        }
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Categoria categoria = db.Categorias.Find(id);

            db.Categorias.Remove(categoria);

            db.Entry(categoria).State =
                System.Data.Entity.EntityState.Deleted;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}