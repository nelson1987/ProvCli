using System;
using System.Collections.Generic;
using System.Text;

namespace ProvCli.Domain.Entities
{
    public class Fornecedor
    {
        public Fornecedor(string razaoSocial, string email, string cnpj)
        {
            RazaoSocial = razaoSocial;
            Email = email;
            Cnpj = cnpj;
        }

        public int Id { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Email { get; private set; }
        public string Cnpj { get; private set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(RazaoSocial))
                throw new Exception();
            if (string.IsNullOrEmpty(Email))
                throw new Exception();
            if (string.IsNullOrEmpty(Cnpj))
                throw new Exception();

            throw new NotImplementedException();
        }
        /*
* CADASTRO DE FORNECEDORES Nº: __________

DADOS DOS FORNECEDOR

Denominação social: __________________________________________

Endereço: ___________________________________________________

Bairro: _____________________   Cidade: ________________________

UF: ____   Telefones: _________________   CEP: __________________

Endereço eletrônico/e-mail: _____________________________________

CNPJ: _______________________   Inscrição: _____________________
*/
    }
}
