import { Component, OnInit } from '@angular/core';
import { AlunoServicesService } from 'src/app/services/aluno.service';
import { Aluno } from 'src/app/shared/model/aluno-model';

@Component({
  selector: 'app-consulta-alunos',
  templateUrl: './consulta-alunos.component.html',
  styleUrls: ['./consulta-alunos.component.css'],
})
export class ConsultaAlunosComponent implements OnInit {
  alunos: Aluno[] = [];
  quantidadeDeAlunos: number = 0;

  constructor(private alunoService: AlunoServicesService) {}
  ngOnInit(): void {
    this.alunoService.getAllAluno().subscribe(data =>(this.alunos = data
      ))




    this.quantidadeDeAlunos = this.alunos.length;
  }
}
