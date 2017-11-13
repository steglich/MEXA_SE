using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Specs;
using MEXA_SE.SharedKernel.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MEXA_SE.Test.Specs
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [TestClass]
    public class AtividadeDiaSpecsTest
    {
        private List<Usuario> _usuario;

        public AtividadeDiaSpecsTest()
        {
            this._usuario = new List<Usuario>();
            _usuario.Add(new Usuario("Marlon steglich", "marlon@marlon.com", "1234567h", true));
            _usuario.Add(new Usuario("Marlon steglich", "marlon1@marlon.com", "1234567h", true));
            _usuario.Add(new Usuario("Marlon steglich", "marlon2@marlon.com", "1234567h", true));
        }
        
        [TestMethod]
        [TestCategory("AtividadeDia Specs-GetAllDia")]
        public void Deve_Validar_AtividadeDia_Specs()
        {
            var exp = UsuarioSpecs.AuthenticateUsuario("marlon2@marlon.com", "1234567h");
            var usuario = _usuario.AsQueryable().Where(exp).FirstOrDefault();

            //Assert.AreEqual(null, usuario);
            Assert.AreNotEqual(null, usuario);
        }

    }
}
