import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-cadastro-funcionario',
  templateUrl: './cadastro-funcionario.component.html',
  styleUrls: ['./cadastro-funcionario.component.css']
})
export class CadastroFuncionarioComponent implements OnInit {
  funcionarioForm: FormGroup = new FormGroup({}); // Inicialize o FormGroup vazio
  dadosDoFuncionario: any; // Propriedade para armazenar os dados dos alunos
  constructor(private fb: FormBuilder) {
    }


ngOnInit(){
this.funcionarioForm = this.fb.group({
  nome: [''],
  idade: [''],
  cpf:[''],
  email: [''],
  observacoes: ['']
})
}

onSubmit(){
  this.dadosDoFuncionario = this.funcionarioForm.value;
}
}
