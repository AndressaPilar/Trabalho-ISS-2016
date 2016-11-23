using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Models.Compras
{
    public class ContaPagar
    {
        public Guid ContaPagarId { get; set; }
        public int ContaPagarCodigo { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorDocumento { get; set; }
        public StatusContaPagarEnum StatusContaPagar { get; set; }
        public bool Pago { get; set; }
        public virtual Compra Compra { get; set; }

        public void Validar()
        {
            AssertionConcern.AssertArgumentNotEquals(new DateTime(), DataVencimento,
                string.Format(Erros.InvalidParameter, "DataVencimento"));
            AssertionConcern.AssertArgumentNotEquals(0.0M, ValorDocumento,
                string.Format(Erros.NotZeroParameter, "ValorDocumento"));
            AssertionConcern.AssertArgumentNotEquals(StatusContaPagar, StatusContaPagarEnum.None,
                string.Format(Erros.InvalidParameter, "StatusContaPagar"));
            AssertionConcern.AssertArgumentNotNull(Compra, Erros.PurchaseNotSet);
        }
    }
}
