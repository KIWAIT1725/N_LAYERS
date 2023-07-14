using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public static class DAL_RolFormularios
    {
        public static RolFormularios Insert(RolFormularios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                data.RolFormularios.Add(Entidad);
                data.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(RolFormularios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                var Registro = data.RolFormularios.Find(Entidad.IdRolFormulario);
                Registro.IdRol = Entidad.IdRol;
                Registro.IdFormulario = Entidad.IdFormulario;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Anular(RolFormularios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                var Registro = data.RolFormularios.Find(Entidad.IdRolFormulario);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Existe(RolFormularios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.RolFormularios.Where(a => a.IdRolFormulario == Entidad.IdRolFormulario).Count() > 0;
            }
        }
        public static RolFormularios Registro(RolFormularios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.RolFormularios.Where(c => c.IdRolFormulario == Entidad.IdRolFormulario).SingleOrDefault();
            }
        }
        public static List<RolFormularios> Lista(bool Activo = true)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.RolFormularios.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}
