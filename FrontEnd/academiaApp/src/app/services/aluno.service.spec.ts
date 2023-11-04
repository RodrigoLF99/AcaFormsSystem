import { TestBed } from '@angular/core/testing';

import { AlunoServicesService } from './aluno.service';

describe('AlunoServicesService', () => {
  let service: AlunoServicesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AlunoServicesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
