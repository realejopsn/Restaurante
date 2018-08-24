using Restaurante.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BS
{
    public class clDetalleMenu : IMantenimiento<DetalleMenu>
    {
        private static clDetalleMenu Instancia;

        public static clDetalleMenu _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clDetalleMenu();
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
        public void Delete(DetalleMenu t)
        {
            throw new NotImplementedException();
        }

        public List<DetalleMenu> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(DetalleMenu t)
        {
            throw new NotImplementedException();
        }

        public void Update(DetalleMenu t)
        {
            throw new NotImplementedException();
        }
    }
}
