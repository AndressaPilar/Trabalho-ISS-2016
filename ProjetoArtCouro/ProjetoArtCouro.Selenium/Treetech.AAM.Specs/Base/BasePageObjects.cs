using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Treetech.AAM.Specs.Base
{
    public abstract class BasePageObjects
    {
        protected readonly IWebDriver Driver;
        protected readonly WebDriverWait Wait;
        protected readonly string UrlSistema;

        protected readonly By SelectorBlockUi = By.CssSelector(".block-ui-message");
        protected readonly By BotaoPesquisar = By.Id("btn-pesquisar");
        protected readonly By BotaoLimparFiltro = By.Id("btn-limpar");
        protected readonly By BotaoAlterar = By.Id("btn-alterar");
        protected readonly By BotaoGerarDocumentoAjuste = By.Id("btn-gerar-documento-ajuste");
        protected readonly By BotaoCancelaExclusao = By.Id("btn-cancelar");
        protected readonly By BotaoFecharCadastro = By.Id("btn-fechar");
        protected readonly By NotifyMensagemErroSucesso = By.XPath("//span[@data-notify='message']");
        //teste mensagem modal
        protected readonly By MensagemErroModal = By.CssSelector(".validation-summary-errors.alert.alert-block.alert-error.ng-scope");
        protected readonly By CheckBoxExcluirAlterar = By.CssSelector(".text-center.sorting_1>input");

        protected readonly By ModalConfirmarExclusao = By.CssSelector(".modal.hide.fade.in");
        protected readonly By ModalConfirmarFecharCadastro = By.CssSelector(".modal-body");
        protected readonly By BotaoSimFechaCadastro = By.CssSelector(".btn.btn-success.confirmar-sim");
        protected readonly By BotaoNaoFechaCadastro = By.CssSelector(".btn.confirmar-nao");

        protected readonly By BotaoInserir = By.Id("btn-inserir");
        protected readonly By BotaoExcluir = By.Id("btn-excluir");
        protected readonly By BotaoSalvar = By.Id("btn-salvar");
        protected readonly By BotaoConfirmaExclusao = By.CssSelector(".btn.btn-danger.btn-confirmar-excluir.ng-binding");
        //protected readonly By BotaoConfirmaExclusao = By.Id("btn-confirmar"); 
        //protected readonly By AbaAssociarConjuntos = By.Id("associarConjuntos");
        protected readonly By AbaAssociarConjuntos = By.XPath(".//*[@id='aam-main']/div[2]/div/div/form/div/div[4]/ul/li/a");
        protected readonly By AbaAssociarFamilias = By.XPath(".//*[@id='aam-main']/div[2]/div/div/form/div/div[4]/ul/li[1]/a");
        protected readonly By AbaOcorrencias = By.XPath(".//*[@id='aam-main']/div[2]/div/div/form/div/div[4]/ul/li[2]/a");
        protected readonly By AbaCausas = By.XPath(".//*[@id='aam-main']/div[2]/div/div/form/div/div[4]/ul/li[3]/a");

        //Não conformidade
        protected readonly By BotaoInserirNaoConformidade = By.Id("btn-inserir-nao-conformidade");
        protected readonly By ModalNaoConformidades = By.CssSelector(".modal.hide.fade.in"); 
        protected readonly By BotaoSalvarNaoConformidade = By.Id("btn-salvar-nao-conformidade");
        protected readonly By BotaoFecharNaoConformidade = By.Id("btn-fechar-nao-conformidade");
        protected readonly By CampoDescricaoConjunto = By.Id("DescricaoConjunto");
        protected readonly By CampoDescricaoOcorrencia = By.Id("DescricaoOcorrencia");
        protected readonly By CampoDescricaoCausa = By.Id("DescricaoCausa");

        //Arquivo
        protected readonly By BotaoInserirArquivo = By.Id("btn-inserir-arquivo");
        //Não funcionou por css selector
        protected readonly By BotaoInserirArquivoCssSelector = By.XPath(".//*[@id='tab2']/div/p/button[1]");
        protected readonly By ModalImportacaoArquivo = By.CssSelector(".modal.hide.fade.in");
        protected readonly By BotaoImportaArquivo = By.XPath(".//*[@id='file-input']/span");
        protected readonly By BotaoInserirArquivoNoGrid = By.CssSelector(".btn.btn-primary.btn-salvar");

        //um desses dois campos deve ser mudado
        protected readonly By CampoDescricaoArquivo = By.Id("descricao-arquivo");
        protected readonly By CampoTagArquivo = By.Id("tags-arquivo");

        //Botões gerais para telas que não tem ID, são pegos por cssSelector.
        protected readonly By BotaoInserirCssSelector = By.CssSelector(".btn.btn-small.btn-primary");
        protected readonly By BotaoSalvarCssSelector = By.CssSelector(".btn.btn-small.btn-primary");
        protected readonly By BotaoAlterarCssSelector = By.CssSelector(".btn.btn-small.btn-alterar.btn-info");
        protected readonly By BotaoExcluirCssSelector = By.CssSelector(".btn.btn-small.btn-excluir.btn-danger");
        protected readonly By BotaoFecharCssSelector = By.CssSelector(".btn.btn-small.confirm-close.cadastro");
        protected readonly By BotaoPesquisarCssSelector = By.CssSelector(".btn.pesquisar");


        protected BasePageObjects(FeatureContext featureContext)
        {
            Driver = featureContext.WebDriver();
            Wait = featureContext.Wait();
            UrlSistema = featureContext.ApplicationUrl();
        }

        protected void PreencherAutoComplete(string nome, int posicaoValor = 1)
        {
            var elemento = Driver.FindElement(By.XPath($"//div[(@name= \'{nome}\')]"));
            var campoTexto = elemento.FindElement(By.TagName("input"));

            campoTexto.SendKeys(Keys.Down);

            // Aguardar o carregamento do autocomplete
            Wait.Until(d => !campoTexto.GetAttribute("class").Contains("ui-autocomplete-loading"));

            for (var i = 1; i <= posicaoValor; i++)
            {
                campoTexto.SendKeys(Keys.Down);
            }

            campoTexto.SendKeys(Keys.Enter);
            //Aguardar();
        }
        //====================================================//
        //Preencher o autocomplete, pássando texto no parametro
        protected void PreencherAutoCompletePesquisando(string nomeCampo, string textoPesquisa)
        {
            var elemento = Driver.FindElement(By.XPath($"//div[(@name= \'{nomeCampo}\')]"));
            var campoTexto = elemento.FindElement(By.TagName("input"));
            var opcaoAutocomplete = Driver.FindElement(By.CssSelector(".ui-autocomplete"));

            campoTexto.SendKeys(textoPesquisa);
            Thread.Sleep(3000);

            //Simula o movimento do mouse
            Actions builder = new Actions(Driver);
            builder.MoveToElement(opcaoAutocomplete).Build().Perform();
            Thread.Sleep(5000);

            campoTexto.SendKeys(Keys.Down);
            campoTexto.SendKeys(Keys.Enter);
        }

    }
}