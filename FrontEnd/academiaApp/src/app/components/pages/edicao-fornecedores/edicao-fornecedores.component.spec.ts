import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EdicaoFornecedoresComponent } from './edicao-fornecedores.component';

describe('EdicaoFornecedoresComponent', () => {
  let component: EdicaoFornecedoresComponent;
  let fixture: ComponentFixture<EdicaoFornecedoresComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EdicaoFornecedoresComponent]
    });
    fixture = TestBed.createComponent(EdicaoFornecedoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
