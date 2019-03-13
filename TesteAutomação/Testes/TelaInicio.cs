using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uteis; 

namespace TestesTelaInicio
{
    
    [TestClass]
    public class TelaInicial
    {

        [TestMethod]
        public void VerificarTituloDoSite()
        {
            FuncUteis.IniciaNavegador("chrome", false);
            FuncUteis.AdicionarURL("https://automacaocombatista.herokuapp.com/treinamento/home");
            string Titulo = FuncUteis.PegaTituloDaPagina();
            Assert.AreEqual("Automação com Batistu", Titulo, "Não conseguiu identificar o titulo do site, verificar o titulo usado na comparação");
            FuncUteis.EncerrarExecucaoSelenium();
        }

    }
}
