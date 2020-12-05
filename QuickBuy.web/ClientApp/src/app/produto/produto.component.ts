import { Component } from "@angular/core"

@Component({
  selector: "produto",
  template: "<html><body>{{ obterNome() }}</body></html>"

})
export class ProdutoComponent {// Nome das classses começando em maíusculo por conta da convenção PascalCase

  /*camelCase para variáveis, atributos e nomes das funcções */
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return "Sansung";
  }

}
