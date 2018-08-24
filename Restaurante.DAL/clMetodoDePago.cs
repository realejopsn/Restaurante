using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    public class clMetodoDePago : IMantenimiento<MetodoDePago>
    {
        private static clMetodoDePago Instancia;

        public static clMetodoDePago _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clMetodoDePago();
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
        public void Delete(MetodoDePago t)
        {
            throw new NotImplementedException();
        }

        public List<MetodoDePago> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(MetodoDePago t)
        {
            throw new NotImplementedException();
        }

        public void Update(MetodoDePago t)
        {
            throw new NotImplementedException();
        }
    }
}
