using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodexGigas.Services
{
    public interface IDataServices
    {
        public Task<string> EnviarDatosAsync(int metodo, string x, string y, string fx, float h, float n, float vali);
    }
}
