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
                Entidad.activo = true;
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
                var Registro = data.Clientes.Find(Entidad.IDclientes);
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
                var Registro = data.Clientes.Find(Entidad.IDclientes);
                Registro.activo = Entidad.activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Existe(Clientes Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Clientes.Where(c => c.IDclientes == Entidad.IDclientes).Count() > 0;
            }
        }
        public static Clientes Registro(Clientes Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Clientes.Where(c => c.IDclientes == Entidad.IDclientes).SingleOrDefault();
            }
        }
        public static List<Clientes> Lista(bool Activo = true)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Clientes.Where(c => c.activo == Activo).ToList();
            }
        }
    }
}
