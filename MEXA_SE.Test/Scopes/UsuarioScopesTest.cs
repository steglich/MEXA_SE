using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Scopes;
using MEXA_SE.SharedKernel.Helpers;

namespace MEXA_SE.Test.Scopes
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [TestClass]
    public class UsuarioScopesTest
    {

        //[TestMethod]
        //[TestCategory("Usuario")]
        //public void Deve_Registar_Usuario()
        //{
        //    var usuario = new Usuario("marlon steglich", "marlon@marlon.com", "1234567h", true);
        //    Assert.AreEqual(true, UsuarioScopes.CreateUsuarioScopIsValid(usuario));
        //}

        //[TestMethod]
        //[TestCategory("Usuario")]
        //public void Deve_Atualizar_Usuario()
        //{
        //    var usuario = new Usuario("marlon", "marlon@marlon.com", "1234567h", true);
        //    Assert.AreEqual(true, UsuarioScopes.UpdateUsuarioScopIsValid(usuario, "marlon steglich", "marlon@marlon.com", "1234567h"));
        //}

        //[TestMethod]
        //[TestCategory("Usuario")]
        //public void Deve_Validar_Usuario()
        //{
        //    var usuario = new Usuario("marlon", "marlon@marlon.com", "1234567h", true);
        //    Assert.AreEqual(true, UsuarioScopes.AuthenticateUsuarioScopIsValid(usuario, "marlon@marlon.com", StringHelper.Encrypt("1234567h")));
        //}

        //[TestMethod]
        //[TestCategory("Avaliação")]
        //public void Deve_Registar_Avaliacao()
        //{
        //    var avaliacao = new Avaliacao(new DateTime(2017, 11, 11), new DateTime(2017, 12, 12));
        //    Assert.AreEqual(true, AvaliacaoScopes.CreateAvaliacaoScopIsValid(avaliacao));
        //}

        //[TestMethod]
        //[TestCategory("EvolucaoTreino")]
        //public void Deve_Registar_Avaliacao()
        //{
        //    var evolucaoTreino = new EvolucaoTreino(1, 1, new DateTime(2017, 10, 12));
        //    Assert.AreEqual(true, EvolucaoTreinoScopes.CreateEvolucaoTreinoScopIsValid(evolucaoTreino));
        //}

    }
}
