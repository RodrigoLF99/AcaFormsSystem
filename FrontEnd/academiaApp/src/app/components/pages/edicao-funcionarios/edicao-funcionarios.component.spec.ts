import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EdicaoFuncionariosComponent } from './edicao-funcionarios.component';

describe('EdicaoFuncionariosComponent', () => {
  let component: EdicaoFuncionariosComponent;
  let fixture: ComponentFixture<EdicaoFuncionariosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EdicaoFuncionariosComponent]
    });
    fixture = TestBed.createComponent(EdicaoFuncionariosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
