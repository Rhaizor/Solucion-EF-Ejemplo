using Bliblioteca.Dalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Cliente
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNaci { get; set; }
        public int IdSexo { get; set; }
        public int IdEstadoCivil { get; set; }

        private Bliblioteca.Dalc.BeLifeEntities contexto = new BeLifeEntities();
        public Cliente()
        {

        }



        //metodos C.R.U.D
        public bool Crear()
        {
            try
            {
                Bliblioteca.Dalc.Cliente cli;
                cli = new Bliblioteca.Dalc.Cliente();
                cli.RutCliente = Rut;
                cli.Nombres = Nombre;
                cli.Apellidos = Apellido;
                cli.FechaNacimiento = FechaNaci;
                cli.IdSexo = IdSexo;
                cli.IdEstadoCivil = IdEstadoCivil;
                contexto.Cliente.Add(cli);
                contexto.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Eliminar()
        {
            try
            {
                Bliblioteca.Dalc.Cliente cli;
                cli = contexto.Cliente.
                    First(clie => clie.RutCliente.Equals(Rut));
                contexto.Cliente.Remove(cli);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Actualizar()
        {
            try
            {
                Bliblioteca.Dalc.Cliente cli;
                cli = contexto.Cliente.First(clie => clie.RutCliente.Equals(Rut));
                cli.RutCliente = Rut;
                cli.Nombres = Nombre;
                cli.Apellidos = Apellido;
                cli.FechaNacimiento = FechaNaci;
                cli.IdSexo = IdSexo;
                cli.IdEstadoCivil = IdEstadoCivil;
                contexto.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Buscar()
        {
            try
            {
                Bliblioteca.Dalc.Cliente cli;
                cli = contexto.Cliente.First(clie => clie.RutCliente.Equals(Rut));
                Rut = cli.RutCliente;
                Nombre = cli.Nombres;
                Apellido = cli.Apellidos;
                FechaNaci = cli.FechaNacimiento;
                IdSexo = cli.IdSexo;
                IdEstadoCivil = cli.IdEstadoCivil;
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Entidades.Cliente> ListarTodo()
        {
            try
            {
                //crear un arreglo del tipo clase cliente
                List<Entidades.Cliente> Listado = new List<Cliente>();
                //recuperar todos los registros de la tabla cliente (en el modelo)
                var ListadoClientes = contexto.Cliente.ToList();
                foreach (Bliblioteca.Dalc.Cliente item in ListadoClientes)
                {
                    Entidades.Cliente cli = new Cliente();
                    cli.Rut = item.RutCliente;
                    cli.Nombre = item.Nombres;
                    cli.Apellido = item.Apellidos;
                    cli.FechaNaci = item.FechaNacimiento;
                    cli.IdSexo = item.IdSexo;
                    cli.IdEstadoCivil = item.IdEstadoCivil;
                    Listado.Add(cli);
                }
                return Listado;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<Entidades.Cliente> ListarPorSexoTodo(int IdSexo)
        {
            try
            {
                //crear un arreglo del tipo clase cliente
                List<Entidades.Cliente> Listado = new List<Cliente>();
                //recuperar todos los registros de la tabla cliente (en el modelo)
                var ListadoClientes = from simio in contexto.Cliente
                                      where IdSexo == simio.IdSexo
                                      select simio;
                foreach (Bliblioteca.Dalc.Cliente item in ListadoClientes)
                {
                    Entidades.Cliente cli = new Cliente();
                    cli.Rut = item.RutCliente;
                    cli.Nombre = item.Nombres;
                    cli.Apellido = item.Apellidos;
                    cli.FechaNaci = item.FechaNacimiento;
                    cli.IdSexo = item.IdSexo;
                    cli.IdEstadoCivil = item.IdEstadoCivil;
                    Listado.Add(cli);
                }
                return Listado;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<Entidades.Cliente> ListarPorEstadoCivilTodo(int IdSexo)
        {
            try
            {
                //crear un arreglo del tipo clase cliente
                List<Entidades.Cliente> Listado = new List<Cliente>();
                //recuperar todos los registros de la tabla cliente (en el modelo)
                var ListadoClientes = from simio in contexto.Cliente
                                      where IdEstadoCivil == simio.IdEstadoCivil
                                      select simio;
                foreach (Bliblioteca.Dalc.Cliente item in ListadoClientes)
                {
                    Entidades.Cliente cli = new Cliente();
                    cli.Rut = item.RutCliente;
                    cli.Nombre = item.Nombres;
                    cli.Apellido = item.Apellidos;
                    cli.FechaNaci = item.FechaNacimiento;
                    cli.IdSexo = item.IdSexo;
                    cli.IdEstadoCivil = item.IdEstadoCivil;
                    Listado.Add(cli);
                }
                return Listado;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
