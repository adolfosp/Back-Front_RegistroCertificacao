using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Services.Exception
{
    public class DbConcurrencyException: ApplicationException
    {

        public DbConcurrencyException(string mensagem) : base(mensagem) { }
    }
}
