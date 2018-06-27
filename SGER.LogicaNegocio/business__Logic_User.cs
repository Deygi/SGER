using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGER.Entidades;
using SGER.Repositorio;
namespace SGER.LogicaNegocio
{
    public class business__Logic_User : iOperaciones<Usuario>
    {
        public bool delete(int cod)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListAll()
        {
            throw new NotImplementedException();
        }

        public Usuario query(int cod)
        {
            return new Access_Data_User().query(cod);
        }

        public bool register(Usuario entidad)
        {
            throw new NotImplementedException();
        }

        public bool update(Usuario entidad)
        {
            throw new NotImplementedException();
        }
    }
}
