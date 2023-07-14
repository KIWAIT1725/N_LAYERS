using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public static class DAL_Formularios
    {
        public static Formularios Insert(Formularios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                data.Formularios.Add(Entidad);
                data.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Formularios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                var Registro = data.Formularios.Find(Entidad.IdFormulario);
                Registro.Formulario = Entidad.Formulario;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Anular(Formularios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                var Registro = data.Formularios.Find(Entidad.IdFormulario);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Existe(Formularios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Formularios.Where(c => c.IdFormulario == Entidad.IdFormulario).Count() > 0;
            }
        }
        public static Formularios Registro(Formularios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Formularios.Where(c => c.IdFormulario == Entidad.IdFormulario).SingleOrDefault();
            }
        }
        public static List<Formularios> Lista(bool Activo = true)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Formularios.Where(c => c.Activo == Activo).ToList();
            }
        }
    }
}

