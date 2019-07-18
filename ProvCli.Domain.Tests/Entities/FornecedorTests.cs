using Bogus;
using Bogus.Extensions.Brazil;
using NUnit.Framework;
using ProvCli.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProvCli.Domain.Tests.Entities
{
    [TestFixture]
    public class FornecedorTests
    {
        [TestCase(12, 4, ExpectedResult = 3)]
        public int ValidarCriacaoFornecedor(int n, int d)
        {

            //Assert.AreEqual(q, n / d);

            return (n / d);
        }

        [Test]
        public void ValidarCriacaoFornecedorSemDadosObrigatorios()
        {
            var fornecedor = new Fornecedor("", "", "");

            Assert.That(() => fornecedor.Validar(), Throws.TypeOf<Exception>());

        }

        [Test]
        public void ValidarCriacaoFornecedorComDadosObrigatorios()
        {
            var fornecedor = new Fornecedor("Empresa Fantasia", "email@fornecedor.com", "12345678000120");
            Assert.AreEqual(fornecedor.Id, 0);
            Assert.AreEqual(fornecedor.RazaoSocial, "Empresa Fantasia");
            Assert.AreEqual(fornecedor.Email, "email@fornecedor.com");
            Assert.AreEqual(fornecedor.Cnpj, "12345678000120");
            //fornecedor.Validar();
            Assert.That(() => fornecedor.Validar(), Throws.TypeOf<NotImplementedException>());
        }

        [Test]
        public void ValidarEmails()
        {
            var fornecedorFake = new Faker<Fornecedor>()
                    .CustomInstantiator(f =>
                                new Fornecedor(f.Company.CompanyName(),
                                f.Internet.Email(),
                                f.Company.Cnpj()));

            List<Fornecedor> fornecedores = fornecedorFake.Generate(10).ToList();
            foreach (Fornecedor fornecedor in fornecedores)
            {
                Assert.That(() => fornecedor.Validar(), Throws.TypeOf<NotImplementedException>());
            }
        }

        [Test]
        public void ValidarCnpjs()
        {

            var fornecedor = new Fornecedor("Empresa Fantasia", "email@fornecedor.com", "12345678000120");
            Assert.AreEqual(fornecedor.Id, 0);
            Assert.AreEqual(fornecedor.RazaoSocial, "Empresa Fantasia");
            Assert.AreEqual(fornecedor.Email, "email@fornecedor.com");
            Assert.AreEqual(fornecedor.Cnpj, "12345678000120");
            //fornecedor.Validar();
            Assert.That(() => fornecedor.Validar(), Throws.TypeOf<NotImplementedException>());
        }

    }
}
