using Restaurante.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BS
{
    public class clPlato : IMantenimiento<Plato>
    {
        private static clPlato Instancia;

        public static clPlato _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clPlato();
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
        public void Delete(Plato t)
        {
            throw new NotImplementedException();
        }

        public List<Plato> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(Plato t)
        {
            throw new NotImplementedException();
        }

        public void Update(Plato t)
        {
            throw new NotImplementedException();
        }
    }
}
