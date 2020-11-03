using System;
using System.Collections.Generic;

class Carrinho{
  private string Produto;
  private double Preco, total;
  public string ProdutosCarrinho;
  private double ValorProd=0.0;
  //Criando listas
  public List<string> CarrinhoCliente = new List<string>();
  public List<double> PrecoCarrinho = new List<double>();
  public List<int> QuantidadeProdutos = new List<int>();
  //
  public void Comprador (string p, double v, int qtd){
    Console.Write("Produtos -> {0} {1}", qtd, p);
    CarrinhoCliente.Add(p);
    PrecoCarrinho.Add(v);
    QuantidadeProdutos.Add(qtd);
    total = (v*qtd)+total;
    }

//Calcula o valor total
  public static void Valores (double v, int qtd){
    double PrecoTotal;
    PrecoTotal = v*qtd;
    Console.WriteLine(PrecoTotal);
    }
//Calcula o valor do carrinho
  
  public double CarrinhoProdutos (){
    
    Console.WriteLine("O seu carrinho contém esses itens\n ");
    for(int i=0; i<CarrinhoCliente.Count;i++){
      ValorProd = QuantidadeProdutos[i]*PrecoCarrinho[i];
      Console.WriteLine("{0} - {1} - R$ {2} - Total p/ produto R$ {3}", QuantidadeProdutos[i],CarrinhoCliente[i],PrecoCarrinho[i], ValorProd);
      
    }
    
    Console.Write("\nValor total do carrinho -> " );
    return total;
  }

}
