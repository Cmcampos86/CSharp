using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Exception
{
    public class ExceptionIdadeInvalida : ApplicationException
    {
        //Criando as próprias exceptions
        //Deve herdar da ApplicationException e no método construtor herdar o da base de acordo com a assinatura (base)
        public ExceptionIdadeInvalida(string message) : base(message)
        {

        }
    }
}
