﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Api.Controllers
{
    [RoutePrefix("api/ContaReceber")]
    public class ContaReceberController : BaseApiController
    {
        private readonly IContaReceberService _contaReceberService;

        public ContaReceberController(IContaReceberService contaReceberService)
        {
            _contaReceberService = contaReceberService;
        }

        [Route("PesquisaContaReceber")]
        [Authorize(Roles = "PesquisaContaReceber")]
        [HttpPost]
        public Task<HttpResponseMessage> PesquisaContaReceber(PesquisaContaReceberModel model)
        {
            HttpResponseMessage response;
            try
            {
                var usuarioCodigo = ObterCodigoUsuarioLogado();
                var contasReceber = _contaReceberService.PesquisarContaReceber(model.CodigoVenda ?? 0, model.CodigoCliente ?? 0,
                    model.DataEmissao.ToDateTimeWithoutHour(), model.DataVencimento.ToDateTimeWithoutHour(),
                    model.StatusId ?? 0, model.NomeCliente, model.CPFCNPJ, usuarioCodigo);
                response = ReturnSuccess(Mapper.Map<List<ContaReceberModel>>(contasReceber));
            }
            catch (Exception ex)
            {
                response = ReturnError(ex);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [Route("ReceberConta")]
        [Authorize(Roles = "PesquisaContaReceber")]
        [HttpPut]
        public Task<HttpResponseMessage> ReceberConta(List<ContaReceberModel> listaContaReceberModel)
        {
            HttpResponseMessage response;
            try
            {
                var listaContaReceber = Mapper.Map<List<ContaReceber>>(listaContaReceberModel);
                _contaReceberService.ReceberContas(listaContaReceber);
                response = ReturnSuccess();
            }
            catch (Exception ex)
            {
                response = ReturnError(ex);
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        private static int ObterCodigoUsuarioLogado()
        {
            var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
            var usuarioCodigo = identity.Claims.Where(c => c.Type == ClaimTypes.Sid)
                .Select(c => c.Value).SingleOrDefault();
            return usuarioCodigo.ToInt();
        }

        protected override void Dispose(bool disposing)
        {
            _contaReceberService.Dispose();
        }
    }
}
