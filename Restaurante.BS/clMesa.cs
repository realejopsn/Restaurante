using Restaurante.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BS
{
    public class clMesa : IMantenimiento<Mesa>
    {
        private static clMesa Instancia;

        public static clMesa _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clMesa();
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
        public void Delete(Mesa t)
        {
            throw new NotImplementedException();
        }

        public List<Mesa> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(Mesa t)
        {
            throw new NotImplementedException();
        }

        public void Update(Mesa t)
        {
            throw new NotImplementedException();
        }
    }
}
