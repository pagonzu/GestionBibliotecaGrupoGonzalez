using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public static class DatosPrueba
    {
        public static void Cargar()
        {
            PersonalSala ps1 = new PersonalSala("PS-01", "Pepe", "7777");
            PersonalSala ps2 = new PersonalSala("PS-02", "Laura", "1234");
            PersonalSala ps3 = new PersonalSala("PS-03", "Pedro", "0000");

            Persistencia.Persistencia.CREATE(ps1);
            Persistencia.Persistencia.CREATE(ps2);
            Persistencia.Persistencia.CREATE(ps3);

            PersonalAdquisiciones pa1 = new PersonalAdquisiciones("PA-01", "Marta", "1111");
            PersonalAdquisiciones pa2 = new PersonalAdquisiciones("PA-02", "Luis", "2222");
            PersonalAdquisiciones pa3 = new PersonalAdquisiciones("PA-03", "Ana", "3333");

            Persistencia.Persistencia.CREATE(pa1);
            Persistencia.Persistencia.CREATE(pa2);
            Persistencia.Persistencia.CREATE(pa3);

            Usuario u1 = new Usuario("11111111A", "Juan Perez");
            Usuario u2 = new Usuario("22222222B", "Maria Lopez");
            Usuario u3 = new Usuario("33333333C", "Carlos Ruiz");

            Persistencia.Persistencia.CREATE(u1);
            Persistencia.Persistencia.CREATE(u2);
            Persistencia.Persistencia.CREATE(u3);

            Libro l1 = new Libro("L-100", 2020, "Cien años de soledad", "Gabriel Garcia Marquez", "Planeta");
            Libro l2 = new Libro("L-200", 1605, "Don Quijote", "Cervantes", "Alfaguara");
            Libro l3 = new Libro("L-300", 1949, "1984", "George Orwell", "Debolsillo");

            Persistencia.Persistencia.CREATE(l1);
            Persistencia.Persistencia.CREATE(l2);
            Persistencia.Persistencia.CREATE(l3);

            AudioLibro a1 = new AudioLibro("A-500", 2000, "Harry Potter y la piedra filosofal", "J.K. Rowling", "Salamandra", "MP3", 30000);
            AudioLibro a2 = new AudioLibro("A-600", 1954, "El Señor de los Anillos", "Tolkien", "Minotauro", "WAV", 45000);
            AudioLibro a3 = new AudioLibro("A-700", 1965, "Dune", "Frank Herbert", "Nova", "MP3", 32000);

            Persistencia.Persistencia.CREATE(a1);
            Persistencia.Persistencia.CREATE(a2);
            Persistencia.Persistencia.CREATE(a3);

            Ejemplar ej1 = new Ejemplar("EJ-01", false, pa1, l1);
            Ejemplar ej2 = new Ejemplar("EJ-02", false, pa1, l1);
            Ejemplar ej3 = new Ejemplar("EJ-03", true, pa1, l2);
            Ejemplar ej4 = new Ejemplar("EJ-04", false, pa2, a1);

            Persistencia.Persistencia.CREATE(ej1);
            Persistencia.Persistencia.CREATE(ej2);
            Persistencia.Persistencia.CREATE(ej3);
            Persistencia.Persistencia.CREATE(ej4);
        }
    }
}
