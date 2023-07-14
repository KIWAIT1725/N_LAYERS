using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Roles
    {
        public static Roles Insert(Roles Entidad)
        {
            using DataBasic data = new();
            Entidad.Activo = true;
            Entidad.FechaRegistro = DateTime.Now;
            data.Roles.Add(Entidad);
            data.SaveChanges();
            return Entidad;
        }
        public static bool Update(Roles Entidad)
        {
            using DataBasic data = new();
            var Registro = data.Roles.Find(Entidad.IdRol);
            if (Registro == null)
            {
                return false;
            }
            Registro.Rol = Entidad.Rol;
            Registro.FechaActualizacion = DateTime.Now;
            return data.SaveChanges() > 0;
        }
        public static bool Delete(Roles Entidad)
        {
            using DataBasic data = new();
            var Registro = data.Roles.Find(Entidad.IdRol);
            if (Registro == null)
            {
                return false;
            }
            Registro.Activo = false;
            Registro.FechaActualizacion = DateTime.Now;
            return data.SaveChanges() > 0;
        }
        public static Roles Registro(short IdRegistro)
        {
            using DataBasic data = new();
            return data.Roles.Find(IdRegistro);
        }
        public static List<Roles> Listar(bool Activo = true)
        {
            using DataBasic data = new();
            return data.Roles.Where(a => a.Activo == Activo).ToList();
        }
    }
}

