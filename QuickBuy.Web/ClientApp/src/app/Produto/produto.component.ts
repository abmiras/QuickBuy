import { Component } from "@angular/core"

@Component({
  selector: "app-produto",
  template: "<html><body>{{ obterNome() }}</body></html>"
})
export class ProdutoComponent { //nome das classes com maisuclo por conta da convenscao PascalCase

  // camelCase para variaveis, atributos e nome das funcoes

  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string
  {
    return "Samsung";


    //return this.nome;
  }
  
}
