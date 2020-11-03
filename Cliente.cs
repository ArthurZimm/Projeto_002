using System;

class Cliente{
  string nome;
  string endereco;
  int idade;
  string telefone;
  string cep;
  //SET
  public void MudaNome(string n){  
  nome = n;
  }  
  public void MudaEndereco(string n){ 
  endereco = n;   
  }  
  public void MudaIdade(int i){  
  idade = i;
  } 
  public void MudaTelefone(string t){
  telefone = t;
  }
  public void MudaCep(string c){
  cep = cep;
  }
  //GET
  public string RetornaNome(){
    return nome;
  }
  public string RetornaEndereco(){
    return endereco;
  }
  public int RetornaIdade(){
    return idade;
  }
  public string RetornaTelefone(){
    return telefone;
  }
  public string RetornaCep(){
    return cep;
  }
}