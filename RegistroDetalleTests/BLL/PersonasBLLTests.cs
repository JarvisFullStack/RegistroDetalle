using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroDetalle.BLL;
using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarDetalleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            Personas persona = new Personas()
            {
                PersonaId = 0,
                Cedula = "adfd",
                Direccion = "adf",
                Nombre = "asdf",
                FechaNacimiento = DateTime.Now,
                Telefonos = new List<TelefonosDetalle>()
                {
                    new TelefonosDetalle()
                    {
                        Id = 0,
                        PersonaId = 0,
                        Telefono = "adsfdf",
                        TipoTelefono = "celular"
                    },
                    new TelefonosDetalle()
                    {
                        Id = 0,
                        PersonaId = 0,
                        Telefono = "qqqqqq",
                        TipoTelefono = "Casa"
                    }
                }
            };

            Assert.AreEqual(true, PersonasBLL.Guardar(persona));
        }

        [TestMethod()]
        public void EliminarDetalleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}