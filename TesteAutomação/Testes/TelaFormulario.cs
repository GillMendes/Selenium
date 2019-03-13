using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uteis;
using System.Collections.ObjectModel;


namespace TestesTelaInicio
{
    [TestClass]
    public class TelaFormulario
    {
        public bool Result;
        [TestMethod]
        public void ClicarNosLinkDeFormulario()
        {
            FuncUteis.IniciaNavegador("chrome", false);
            FuncUteis.AdicionarURL("https://automacaocombatista.herokuapp.com/treinamento/home");
            Assert.IsTrue(FuncUteis.ClicarEmUmLink("Formulário"),"Não Conseguiu Clicar no <Formulário>");
            
        }

        [TestMethod]
        public void ClicarNoLinkCriarUsuários()
        {

            
            Assert.IsTrue(FuncUteis.ClicarUsandoXpath("//*/a[contains(@href, '/users/new')]"), "Não Conseguiu Clicar no <Criar Usuários>");
       
        }
    }
}
