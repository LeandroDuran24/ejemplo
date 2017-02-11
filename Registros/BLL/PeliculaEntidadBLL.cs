using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Registros.DAL;
using Registros.Entidades;

namespace Registros.BLL
{
    public class PeliculaEntidadBLL
    {

        public static bool Guardar(PeliculaEntidad nuevo)
        {
            bool retorno = false;
           using (var conn = new RegistroDb())
           {
                try
                {
                    if (Buscar(nuevo.PeliculaId) == null)
                    {
                        conn.peli.Add(nuevo);
                        retorno = true;
                    }
                    else
                    {
                        conn.Entry(nuevo).State = System.Data.Entity.EntityState.Modified;

                    }
                    conn.SaveChanges();


                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }
            
        }

        public static PeliculaEntidad Buscar(int id)
        {
            var conn = new PeliculaEntidad();
            using (var busca = new RegistroDb())
            {
                try
                {
                    conn = busca.peli.Find(id);

                }
                catch (Exception)
                {

                    throw;
                }
                return conn;
            }
        }

        public static bool Eliminar(PeliculaEntidad id)
        {
            bool retorno = false;
            using (var conn = new RegistroDb())
            {
                try
                {
                    conn.Entry(id).State =EntityState.Deleted;
                    conn.SaveChanges();
                    retorno =true;
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
                
            }

                
        }

        public static List<PeliculaEntidad>GetList(DateTime desde,DateTime hasta)
        {
            var lista = new List<PeliculaEntidad>();
            using(var conn = new RegistroDb())
            {
                try
                {
                    lista = conn.peli.Where(p => p.Fecha >= desde.Date && p.Fecha <= hasta.Date).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }
    }
}
