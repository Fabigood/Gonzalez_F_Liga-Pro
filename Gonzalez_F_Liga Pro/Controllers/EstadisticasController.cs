using System.Diagnostics;
using Gonzalez_F_Liga_Pro.Data;
using Gonzalez_F_Liga_Pro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gonzalez_F_Liga_Pro.Controllers
{
    public class EstadisticasController : Controller
    {
        private readonly ILogger<EstadisticasController> _logger;
        private readonly Gonzalez_F_Liga_ProContext _context; // Contexto de la base de datos

        // Constructor
        public EstadisticasController(ILogger<EstadisticasController> logger, Gonzalez_F_Liga_ProContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Acción Index que pasa los datos de equipos y jugadores goleadores
        public async Task<IActionResult> Index()
        {
            var equipos = await _context.Equipo.ToListAsync();
            var jugadoresGoleadores = await _context.Jugador
                .OrderByDescending(j => j.Goles)
                .Take(10) // Cambia el número según lo que necesites
                .ToListAsync();

            var modelo = new
            {
                Equipos = equipos,
                JugadoresGoleadores = jugadoresGoleadores
            };

            return View(modelo); // Pasamos los datos a la vista
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
