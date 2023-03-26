using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "IMCINE",
                    Descripcion = "ERP Interno en ASP.NET",
                    Link = "https://convocatorias.imcine.gob.mx/focine/ficcion/",
                    ImagenURL = "/imagenes/CDI.png"
                },

                new Proyecto
                {
                    Titulo = "IMCINE",
                    Descripcion = "Sistemas de convocatorias FOCINE",
                    Link = "https://convocatorias.imcine.gob.mx/focine/ficcion/",
                    ImagenURL = "/imagenes/FOCINE.png"
                },

                new Proyecto
                {
                    Titulo = "GRUPO PISA",
                    Descripcion = "Sistema baso en Core Banking con VisualBasic .NET",
                    Link = "https://www.grupopisa.com.mx/",
                    ImagenURL = "/imagenes/GrupoPISA.png"
                },

                new Proyecto
                {
                    Titulo = "Grupo Cynthus",
                    Descripcion = "Sistema de hojas de calculo Woking Papers",
                    Link = "https://www.cynthus.com.mx/",
                    ImagenURL = "/imagenes/GrupoCynthus.png"
                }
            };
        }
    }
}
