using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Api.Helpers
{
    [DeflateCompression]
    public class BaseApiController : ApiController
    {
        public HttpResponseMessage ReturnError(Exception ex)
        {
            var retornoBase = new RetornoBase<Exception>
            {
                ObjetoRetorno = ex,
                Mensagem = ex.Message,
                TemErros = true
            };
            return Request.CreateResponse(HttpStatusCode.BadRequest, retornoBase);
        }

        public HttpResponseMessage ReturnSuccess()
        {
            var retornoBase = new RetornoBase<object>();
            return Request.CreateResponse(HttpStatusCode.OK, retornoBase);
        }

        public HttpResponseMessage ReturnSuccess<T>(T objetReturn)
        {
            var retornoBase = new RetornoBase<T>
            {
                ObjetoRetorno = objetReturn
            };
            return Request.CreateResponse(HttpStatusCode.OK, retornoBase);
        }
    }
}
