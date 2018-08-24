using Restaurante.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BS
{
    public class clDetalleFacturaPlato : IMantenimiento<DetalleFacturaPlato>
    {
        private static clDetalleFacturaPlato Instancia;

        public static clDetalleFacturaPlato _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clDetalleFacturaPlato();
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
        public void Delete(DetalleFacturaPlato t)
        {
            throw new NotImplementedException();
        }

        public List<DetalleFacturaPlato> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(DetalleFacturaPlato t)
        {
            throw new NotImplementedException();
        }

        public void Update(DetalleFacturaPlato t)
        {
            throw new NotImplementedException();
        }
    }
}
