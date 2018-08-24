using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    public class clUsuario : IMantenimiento<Usuario>
    {
        private static clUsuario Instancia;

        public static clUsuario _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clUsuario();
                }
                return Instancia;
            }
            set
            {
                if (Instancia == null)
                {
                    Instancia = value;
                }
            }
        }

        public void Delete(Usuario t)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Get()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                RestauranteEntities entities = new RestauranteEntities();
                lista = entities.Usuario.ToList();
                entities.SaveChanges();
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insert(Usuario t)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario t)
        {
            throw new NotImplementedException();
        }
    }
}
