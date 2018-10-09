using RegistroDetalle.DAL;
using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.BLL
{
    public class PersonasBLL
    {

        public static bool GuardarDetalle(TelefonosDetalle tel)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.TelefonosDetalle.Add(tel) != null)
                {
                   paso =  contexto.SaveChanges() > 0;
                   
                }

               
               
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Guardar(Personas persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
               
                if(contexto.Personas.Add(persona) != null)
                {
                    
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool EliminarDetalle(int id)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                var eliminar = db.TelefonosDetalle.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Personas persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var Anterior = contexto.Personas.Find(persona.PersonaId);
                foreach (var item in Anterior.Telefonos)
                {
                    if(!persona.Telefonos.Exists(d => d.Id == item.Id))
                    {
                        contexto.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    }
                }
                contexto.Entry(persona).State = System.Data.Entity.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Personas persona = contexto.Personas.Find(id);
                contexto.Entry(persona).State = System.Data.Entity.EntityState.Deleted;

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Personas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Personas persona = new Personas();
            try
            {
                persona = contexto.Personas.Find(id);

                persona.Telefonos.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return persona;
        }

        public static List<Personas> GetList(Expression<Func<Personas, bool>> expression)
        {
            List<Personas> lista = new List<Personas>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Personas.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }


    }
}
