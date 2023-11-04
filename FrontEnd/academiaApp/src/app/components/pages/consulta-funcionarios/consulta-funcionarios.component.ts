import { Component, OnInit } from '@angular/core';
import { Funcionario } from 'src/app/shared/model/funcionario-model';

@Component({
  selector: 'app-consulta-Funcionarios',
  templateUrl: './consulta-funcionarios.component.html',
  styleUrls: ['./consulta-funcionarios.component.css'],
})
export class ConsultaFuncionariosComponent implements OnInit {
  funcionarios: Funcionario[] = [];
  quantidadeDeFuncionario: number = 0;

  ngOnInit(): void {
    this.funcionarios = [
      {
        nome: 'Rodrigo Fortes',
        idade: 27,
        cpf:15046253747,
        email: 'teste@Test.com',
        cargo: ' Gerente'


      },
      {
        nome: 'Julia Teixeira',
        idade: 18,
        cpf:15046253747,
        email: 'teste@Test.com',
        cargo: ' Gerente'

      },
      {
        nome: 'José da Silva',
        idade: 45,
        cpf:15046253747,
        email: 'teste@Test.com',
        cargo: ' Gerente'

      },
      {
        nome: 'João Abreu',
        idade: 32,
        cpf:15046253747,
        email: 'teste@Test.com',
        cargo: ' Gerente'

      },
    ];

    this.quantidadeDeFuncionario = this.funcionarios.length;
  }
}
