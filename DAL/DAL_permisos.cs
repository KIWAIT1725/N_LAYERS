using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public static class DAL_Permisos
    {
        public static Permisos Insert(Permisos Entidad)
        {
            using (metodo data = new metodo())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                data.Permisos.Add(Entidad);
                data.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Permisos Entidad)
        {
            using (metodo data = new metodo())
            {
                var Registro = data.Permisos.Find(Entidad.IdPermiso);
                Registro.Permiso = Entidad.Permiso;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Anular(Permisos Entidad)
        {
            using (metodo data = new metodo())
            {
                var Registro = data.Permisos.Find(Entidad.IdPermiso);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Existe(Permisos Entidad)
        {
            using (metodo data = new metodo())
            {
                return data.Permisos.Where(a => a.IdPermiso == Entidad.IdPermiso).Count() > 0;
            }
        }
        public static Permisos Registro(Permisos Entidad)
        {
            using (metodo data = new metodo())
            {
                return data.Permisos.Where(c => c.IdPermiso == Entidad.IdPermiso).SingleOrDefault();
            }
        }
        public static List<Permisos> Lista(bool Activo = true)
        {
            using (metodo data = new metodo())
            {
                return data.Permisos.Where(c => c.Activo == Activo).ToList();
            }
        }
    }
}

