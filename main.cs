using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    string Nome, Endereco, Telefone, Cep, continuar="S", finalCompra, op;
    int idade, PosProd, qtd;
    double CarrinhoValorTotal, valorRecebido;
    Loja estoque = new Loja();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine (" ============ Bem vindo  ============ ");
    Console.WriteLine("Faça um cadastro na nossa Loja!\n");
    Console.ResetColor();
    //Cadastro   
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Cliente cliente = new Cliente();
    Console.Write("Digite seu nome>> ");
    Nome = Console.ReadLine();
    cliente.MudaNome(Nome);    
    Console.Write("Digite seu Endereço >>> ");
    Endereco = Console.ReadLine();  
    cliente.MudaEndereco(Endereco);  
    Console.Write("Digite sua idade >>>> ");
    idade = int.Parse(Console.ReadLine());   
    cliente.MudaIdade(idade);   
    Console.Write("Digite seu Telefone >>>> ");
    Telefone = Console.ReadLine();   
    cliente.MudaTelefone(Telefone); 
    Console.Write("Digite seu CEP >>> ");
    Cep = Console.ReadLine(); 
    cliente.MudaCep(Cep);  
    Console.WriteLine("Cadastro realizado com sucesso!\n");
    Console.Clear();
    
    //
    Console.WriteLine("\n======== Produtos disponíveis ========\n");

  //
  for(int i=0; i<estoque.Produtos.Count;i++){
    Console.WriteLine("ID {0} ================ {1} \nQuantidade {2} \nValor >>>>> R${3}\n\n", i, estoque.Produtos[i], estoque.Quantidade[i],estoque.Preco[i]);
    }
  //
  Carrinho ClienteA = new Carrinho();
  while (continuar == "S" ^ continuar == "s"){
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("Digite o ID do produto na tabela de produtos >> ");
    PosProd = int.Parse(Console.ReadLine());
    while(PosProd >= estoque.Produtos.Count){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("ID invalido.\nDigite o ID do produto na tabela de produtos >> ");
      PosProd = int.Parse(Console.ReadLine());
      if(PosProd <= estoque.Produtos.Count){
        break;
      }
    }
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("Digite a quantidade >> ");
    qtd = int.Parse(Console.ReadLine());
      while (qtd > estoque.Quantidade[PosProd]){
        if(qtd > estoque.Quantidade[PosProd] || qtd == 0){
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Quantidade invalida.\nQuantidade disponivel em estoque {0}",estoque.Quantidade[PosProd]);
          Console.Write("Digite a quantidade >> ");
          qtd = int.Parse(Console.ReadLine());
          if (estoque.Quantidade[PosProd]==0){
            Console.WriteLine("Produto Indisponivel");
          }
        }else{
          break;
        }
      }
    Console.ForegroundColor = ConsoleColor.Black;
    estoque.Quantidade[PosProd]=estoque.Quantidade[PosProd]-qtd;
    ClienteA.Comprador(estoque.Produtos[PosProd], estoque.Preco[PosProd], qtd);
    Console.WriteLine("\n-----------------------------------------------------------");
    Console.Write("\nPara continuar fazendo compras digite S, para sair digite N >> ");
    continuar = Console.ReadLine();
    
  }
  //
  CarrinhoValorTotal = ClienteA.CarrinhoProdutos();
  Console.Write(CarrinhoValorTotal);
  //
  Console.Write("\nIrá finalizar a compra? (s ou n) >> \n");  
  finalCompra= Console.ReadLine();
  //
  Console.ForegroundColor = ConsoleColor.DarkBlue;
  if (finalCompra == "S" ^ finalCompra == "s"){
    Console.WriteLine("\nSenhor só estamos trabalhando com dinheiro no momento!\nDeseja continuar? S - N\n");
    op= Console.ReadLine();
    //Pagamento  
    if (op == "S" ^ op == "s"){
      Console.WriteLine ("OK!");  
      Console.Write("Valor recebido >>>> ");
      valorRecebido = double.Parse(Console.ReadLine());
      if(valorRecebido < CarrinhoValorTotal){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Lamento senhor, o valor é insuficiente, o total do seu carrinho é {0}", CarrinhoValorTotal, "\nNÃO ACEITAMOS FIADO!");
      }else{
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("O seu troco é de R$ {0} ",valorRecebido - CarrinhoValorTotal);
        Console.WriteLine("Tenha um ótimo dia!!");
        }
    }
  }
    

  
  }

}

