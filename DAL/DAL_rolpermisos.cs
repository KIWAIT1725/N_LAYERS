using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public static class DAL_RolPermisos
    {
        public static RoldePermisos Insert(RoldePermisos Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                data.RolPermisos.Add(Entidad);
                data.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(RoldePermisos Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                var Registro = data.RolPermisos.Find(Entidad.IdRolPermiso);
                Registro.IdRol = Entidad.IdRol;
                Registro.IdPermiso = Entidad.IdPermiso;
                Registro.IdRolForumulario = Entidad.IdRolForumulario;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Anular(RoldePermisos Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                var Registro = data.RolPermisos.Find(Entidad.IdRolPermiso);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Existe(RoldePermisos Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.RolPermisos.Where(c => c.IdRolPermiso == Entidad.IdRolPermiso).Count() > 0;
            }
        }
        public static RoldePermisos Registro(RoldePermisos Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.RolPermisos.Where(c => c.IdRolPermiso == Entidad.IdRolPermiso).SingleOrDefault();
            }
        }
        public static List<RoldePermisos> Lista(bool Activo = true)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.RolPermisos.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}

