using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ProjetoArtCouro.Selenium.Base;
using Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ProjetoArtCouro.Selenium.Operacoes
{
    public class ContaPagarPageObjects : BasePageObjects
    {
        private readonly By _campoStatusContaPagar = By.Id("StatusId");
        private readonly By _botaoPesquisarContaPagar = By.Id("PesquisarContaPagar");
        private readonly By _botaoPagarContaPagar = By.Id("SalvarContaPagar");
        private readonly By _checkBoxContaPagarListagem = By.XPath(".//input[@name='checkbox']");

        private readonly string _urlListagemContaPagar;
        private readonly string _urlManutencaoContaPagar;

        public ContaPagarPageObjects(FeatureContext featureContext) : base(featureContext)
        {
            _urlListagemContaPagar = $"{UrlHelpers.Main}/ContaPagar/PesquisaContaPagar";
            _urlManutencaoContaPagar = $"{UrlHelpers.Main}/ContaPagar/NovaContaPagar";
        }

        public void AcessaFuncionalidadeContaPagar()
        {
            Driver.Navigate().GoToUrl(_urlListagemContaPagar);
        }

        public void SelecionarStatusContaPagar()
        {
            new SelectElement(Driver.FindElement(_campoStatusContaPagar)).SelectByIndex(1);
        }

        public void ClicarBotaoPesquisarContaPagar()
        {
            Driver.FindElement(_botaoPesquisarContaPagar).Click();
        }

        public bool VerificarContaPagarFiltradaEstaListagem()
        {
            try
            {
                new SelectElement(Driver.FindElement(_campoStatusContaPagar)).SelectByIndex(2);
                ClicarBotaoPesquisarContaPagar();
                Wait.Until(ExpectedConditions.ElementIsVisible(_checkBoxContaPagarListagem));

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
