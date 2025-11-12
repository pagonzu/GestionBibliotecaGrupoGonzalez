using ModeloDominio.EditorDeTexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Class1
    {
        public void hola()
        {
            Prestamo prestamo = new Prestamo(1, new DateTime(), true, new PersonalSala("nombre","pwd"), new Usuario("nombre"));
            Devolucion devolucion = new Devolucion(prestamo, new Ejemplar(), new DateTime());
            devolucion.getPrestamo().getTrabajador();
        }
    }           
}
