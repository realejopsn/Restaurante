using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.BS
{
    public class clMenu : IMantenimiento<Menu>
    {
        private static clMenu Instancia;

        public static clMenu _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clMenu();
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
        public void Delete(Menu t)
        {
            throw new NotImplementedException();
        }

        public List<Menu> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(Menu t)
        {
            throw new NotImplementedException();
        }

        public void Update(Menu t)
        {
            throw new NotImplementedException();
        }
    }
}
