using Restaurante.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Restaurante.BS 
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
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    Restaurante.DAL.clUsuario._Instancia.Delete(t);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Usuario> Get()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = Restaurante.DAL.clUsuario._Instancia.Get();
                    scope.Complete();
                }
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
