using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class PersonalSalaDatos : Entity<int>
    {
        private String _nombre;
        private String _password;
        private String _tipoTrabajador;
        private int _idSala;

        public PersonalSalaDatos(int idTrabajador, String nombre, String password, String tipoTrabajador, int idSala)
            : base(idTrabajador)
        {
            this._nombre = nombre;
            this._password = password;
            this._tipoTrabajador = tipoTrabajador;
            this._idSala = idSala;
        }

        

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public String TipoTrabajador
        {
            get { return _tipoTrabajador; }
            set { _tipoTrabajador = value; }
        }

        public int IdSala
        {
            get { return _idSala; }
            set { _idSala = value; }
        }
    }
}