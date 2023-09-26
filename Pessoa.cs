using System;

class Pessoa
{
  //atributos
  public double peso, altura;

  //metodos
  public double calculoImc() {
    return  peso / (altura * altura);
  }
  public string situacao(double imc)
  {
    string tipoObesidade;

    if(imc < 18.5) {
      tipoObesidade = "Abaixo do peso";
    }else if(imc < 25){
     tipoObesidade = "Peso normal.";
    }else if(imc < 30) {
      tipoObesidade = "Acima do Peso.";
    }else if(imc < 35) {
      tipoObesidade = "Obesidade I.";
    }else if(imc < 40) {
      tipoObesidade = "Obesidade II.";
    }else{
     tipoObesidade = "Obesidade III.";
    }
    return tipoObesidade;
  }
  public void mensagem(){

    double obterCalculo = calculoImc();
    string obterSituacao = situacao(obterCalculo);

    Console.WriteLine("Seu IMC é de: "+obterCalculo);
    Console.WriteLine("Sua situação atual é: "+obterSituacao);
    
  }
}
