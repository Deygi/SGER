using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGER.Entidades
{
    public interface iOperaciones<T>
    {
        List<T> ListAll();
        bool register(T entidad);
        T query(int cod);
        bool update(T entidad);
        bool delete(int cod);
    }
}
