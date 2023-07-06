using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos
    {
        public List<Proyecto> obtenerProyectos()
        {
            return new List<Proyecto>
            {
                new Proyecto
                {
                    Titulo = "Amazon1",
                    Descripcion = "E-commerce realizado con ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenUrl = "/images/img-min.jpg"
                },
                new Proyecto
                {
                    Titulo = "Amazon2",
                    Descripcion = "E-commerce realizado con ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenUrl = "/images/img-min.jpg"
                },
                new Proyecto
                {
                    Titulo = "Amazon3",
                    Descripcion = "E-commerce realizado con ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenUrl = "/images/img-min.jpg"
                },
                new Proyecto
                {
                    Titulo = "Amazon4",
                    Descripcion = "E-commerce realizado con ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenUrl = "/images/img-min.jpg"
                },
            };
        }
    }
}
