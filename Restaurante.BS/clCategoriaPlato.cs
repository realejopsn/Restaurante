using Restaurante.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BS
{
    public class clCategoriaPlato : IMantenimiento<CategoriaPlato>
    {
        private static clCategoriaPlato Instancia;

        public static clCategoriaPlato _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clCategoriaPlato();
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
        public void Delete(CategoriaPlato t)
        {
            throw new NotImplementedException();
        }

        public List<CategoriaPlato> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(CategoriaPlato t)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoriaPlato t)
        {
            throw new NotImplementedException();
        }
    }
}
