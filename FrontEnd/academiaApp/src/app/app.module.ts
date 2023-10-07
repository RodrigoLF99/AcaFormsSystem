import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { AppComponent } from './app.component';
import { NavbarComponent } from './components/layout/navbar/navbar.component';
import { CadastroAlunosComponent } from './components/pages/cadastro-alunos/cadastro-alunos.component';
import { ConsultaAlunosComponent } from './components/pages/consulta-alunos/consulta-alunos.component';
import { EdicaoAlunosComponent } from './components/pages/edicao-alunos/edicao-alunos.component';
import { AppRoutingModule } from './app.routing';
import { CadastroFuncionarioComponent } from './components/pages/cadastro-funcionarios/cadastro-funcionario.component';
import { ConsultaFuncionariosComponent } from './components/pages/consulta-funcionarios/consulta-funcionarios.component';
import { EdicaoFuncionariosComponent } from './components/pages/edicao-funcionarios/edicao-funcionarios.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    CadastroAlunosComponent,
    ConsultaAlunosComponent,
    EdicaoAlunosComponent,
    CadastroFuncionarioComponent,
    ConsultaFuncionariosComponent,
    EdicaoFuncionariosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, //Adicionando as configuraçôes das rotas
    FormsModule, //Para ultilizar formularios
    ReactiveFormsModule //Para ultilizar formularios reativos
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
