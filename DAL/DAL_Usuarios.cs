using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public static class DAL_Usuarios
    {
        public static Usuarios Insert(Usuarios Entidad)
        {
            using (DataBasic data= new DataBasic())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                data.Usuarios.Add(Entidad);
                data.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Usuarios Entidad)
        {
            using (DataBasic bd = new DataBasic())
            {
                var Registro = bd.Usuarios.Find(Entidad.IdUsuarios);
                Registro.Nombredelusuario = Entidad.Nombredelusuario;
                Registro.Correodelusuario = Entidad.Correodelusuario;
                Registro.Usuario = Entidad.Usuario;
                Registro.contraseña = Entidad.contraseña;
                Registro.Bloqueado = Entidad.Bloqueado;
                Registro.IntentosFallidos = Entidad.IntentosFallidos;
                Registro.IdRol = Entidad.IdRol;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Anular(Usuarios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                var Registro = data.Usuarios.Find(Entidad.IdUsuarios);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return data.SaveChanges() > 0;
            }
        }
        public static bool Existe(Usuarios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Usuarios.Where(c => c.IdUsuarios == Entidad.IdUsuarios).Count() > 0;
            }
        }
        public static Usuarios Registro(Usuarios Entidad)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Usuarios.Where(c => c.IdUsuarios == Entidad.IdUsuarios).SingleOrDefault();
            }
        }
        public static List<Usuarios> Lista(bool Activo = true)
        {
            using (DataBasic data = new DataBasic())
            {
                return data.Usuarios.Where(c => c.Activo == Activo).ToList();
            }
        }
    }
}

