import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Aluno } from '../shared/model/aluno-model';

@Injectable({
  providedIn: 'root'
})
export class AlunoServicesService {

  constructor(private httpClient: HttpClient) { }

  getAllAluno(){
    return this.httpClient.get<Aluno[]>('http://localhost:13185/Aluno/CreateAluno')
  }

  createAluno(aluno: Aluno){
 return this.httpClient.post<any[]>('http://localhost:13185/Aluno/CreateAluno', aluno)
  }

  }


