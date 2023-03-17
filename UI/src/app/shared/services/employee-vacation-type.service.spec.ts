import { TestBed } from '@angular/core/testing';

import { EmployeeVacationTypeService } from './employee-vacation-type.service';

describe('EmployeeVacationTypeService', () => {
  let service: EmployeeVacationTypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EmployeeVacationTypeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
