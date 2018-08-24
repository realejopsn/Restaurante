using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    public class clCliente : IMantenimiento<Cliente>
    {
        private static clCliente Instancia;

        public static clCliente _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clCliente();
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
        public void Delete(Cliente t)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(Cliente t)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente t)
        {
            throw new NotImplementedException();
        }
    }
}
