using Gonzalez_F_Liga_Pro.Models;

namespace Gonzalez_F_Liga_Pro.Repository
{
    public class EquipoRepository
    {
        public static List<Equipo> Equipos = new List<Equipo>
        {
            new Equipo
            {
                Id = 1,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 6,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
                Puntos = 23
            },
            new Equipo
            {

                Id = 3,
                Nombre = "Liga",
                PartidosJugados = 10,
                PartidosGanados = 4,
                PartidosEmpatados = 5,
                PartidosPerdidos = 1,
                Puntos = 16
                
            },
            new Equipo
            {
               Id = 2,
                Nombre = "Emelec",
                PartidosJugados = 10,
                PartidosGanados = 6,
                PartidosEmpatados = 2,
                PartidosPerdidos = 2,
                Puntos = 18
            },
            new Equipo
            {
                Id = 4,
                Nombre = "Macara",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 2,
                PartidosPerdidos = 3,
                Puntos = 14
            },
            new Equipo
            {
                Id = 5,
                Nombre = "Aucas",
                PartidosJugados = 10,
                PartidosGanados = 2,
                PartidosEmpatados = 4,
                PartidosPerdidos = 4,
                Puntos = 12
            }
        };

        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            return Equipos;
        }

        public Equipo DevuelveEquipoPorID(int Id)
        {
            return Equipos.FirstOrDefault(e => e.Id == Id);
        }

        public bool ActualizaEquipo(int Id, Equipo equipoActualizado)
        {
            var index = Equipos.FindIndex(e => e.Id == Id);
            if (index >= 0)
            {
                equipoActualizado.Puntos = (equipoActualizado.PartidosGanados * 3) + equipoActualizado.PartidosEmpatados;
                Equipos[index] = equipoActualizado;
                return true;
            }
            return false;
        }
    }
}

