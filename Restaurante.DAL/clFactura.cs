using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    public class clFactura : IMantenimiento<Factura>
    {
        private static clFactura Instancia;

        public static clFactura _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clFactura();
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
        public void Delete(Factura t)
        {
            throw new NotImplementedException();
        }

        public List<Factura> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(Factura t)
        {
            throw new NotImplementedException();
        }

        public void Update(Factura t)
        {
            throw new NotImplementedException();
        }
    }
}
