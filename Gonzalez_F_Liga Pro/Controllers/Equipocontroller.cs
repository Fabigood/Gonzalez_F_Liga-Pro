using Gonzalez_F_Liga_Pro.Models;
using Gonzalez_F_Liga_Pro.Repository;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace Gonzalez_F_Liga_Pro.Controllers
{
    public class EquipoController : Controller
    {
        EquipoRepository _repository;
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }
        public ActionResult List()
        {

           
            var equipos = _repository.DevuelveListadoEquipos();

            equipos = equipos
                .OrderByDescending(item => item.PartidosGanados);
                

            return View(equipos);

        }
        public ActionResult Create()

        {
            return View();
        }

        public ActionResult Edit(int Id)

        {

            var equipo = _repository.DevuelveEquipoPorID(Id);
            return View(equipo);
        }



        [HttpPost]
        public ActionResult Edit(int Id, Equipo equipo)
        {
            try
            {

                _repository.ActualizaEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
       
    }
}
