using System;
using System.Collections.Generic;
using System.Text;

namespace ProvCli.Domain.Entities
{
    public class Fornecedor
    {
        public int Id { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Email { get; private set; }
        public string Cnpj { get; set; }
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
