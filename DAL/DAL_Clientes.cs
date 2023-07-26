using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public class DAL_Clientes
    {
        public static Clientes Insert(Clientes Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                data.Clientes.Add(Entidad);
                data.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Clientes Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                var Registro = data.Clientes.Find(Entidad.IdClientes);
                Registro.Correo = Entidad.Correo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Anular(Clientes Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                var Registro = data.Clientes.Find(Entidad.IdClientes);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Existe(Clientes Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Clientes.Where(c => c.IdClientes == Entidad.IdClientes).Count() > 0;
            }
        }
        public static Clientes Registro(Clientes Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Clientes.Where(c => c.IdClientes == Entidad.IdClientes).SingleOrDefault();
            }
        }
        public static List<Clientes> Lista(bool Activo = true)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Clientes.Where(c => c.Activo == Activo).ToList();
            }
        }
        public static bool ExisteNumero(string Numero,int IdRegistro)
        {
            using(DataBasic data = new DataBasic())
            {
                return data.Clientes.Where(c => c.Numero == Numero && c.IdClientes != IdRegistro && c.Activo == true).Count() > 0;
            }
        }
        public static bool ExisteCorreo(string Email, int IdRegistro)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Clientes.Where(c => c.Correo == Email && c.IdClientes != IdRegistro && c.Activo == true).Count() > 0;
            }
        }
    }
}
