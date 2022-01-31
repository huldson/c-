using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace OBJMERCADO
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quant;

        public string ValorTotal()
        {
            double valor = quant * preco;
            return valor.ToString("f2", CultureInfo.InvariantCulture); 
        }
        public void AdicionarProduto(int quanty)
        {

            quant = quant + quanty;
        }
        public void RemoverProduto(int quanty)
        {

            quant = quant - quanty;
        }
        public override string ToString()// essa função permite escolher como o dado vai sair quando colocar só nome do objeto
        {// se não colocar essa função, ele vai retorna o namespace e nome da classe só sem dados. 
            return "produto:"+nome+", $ "+preco+"quantidade:"+quant+", total no estoque: $ "+ValorTotal() ;
        }

    }
    
}
