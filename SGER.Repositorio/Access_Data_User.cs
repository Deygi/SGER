using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGER.Entidades;
namespace SGER.Repositorio
{
    public class Access_Data_User : iOperaciones<Usuario>
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
            try
            {
                using (SGEBDEntidades context=new SGEBDEntidades())
                {
                  return context.Usuario.SingleOrDefault(x => x.idUser == cod);
                }
            }
            catch (Exception)
            {

                throw;
            }
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
