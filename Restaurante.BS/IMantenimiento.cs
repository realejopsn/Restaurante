using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BS
{
    public interface IMantenimiento<T>
    {
        void Insert(T t);
        List<T> Get();

        void Delete(T t);

        void Update(T t);
    }
}
