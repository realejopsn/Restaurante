using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    public class clTipoDeUsuario : IMantenimiento<TipoDeUsuario>
    {
        private static clTipoDeUsuario Instancia;

        public static clTipoDeUsuario _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clTipoDeUsuario();
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
        public void Delete(TipoDeUsuario t)
        {
            throw new NotImplementedException();
        }

        public List<TipoDeUsuario> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(TipoDeUsuario t)
        {
            throw new NotImplementedException();
        }

        public void Update(TipoDeUsuario t)
        {
            throw new NotImplementedException();
        }
    }
}
