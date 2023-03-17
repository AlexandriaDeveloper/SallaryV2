import { EmployeeVacation } from './../models/employee/employee';
import { Injectable } from '@angular/core';
import { HttpCustomClientService } from './http-custom-client.service';

@Injectable({
  providedIn: 'root'
})
export class EmployeeVacationTypeService extends HttpCustomClientService {

  constructor() { super('employeeVactionType')}


  addNewEmployeeVacationType(model : EmployeeVacation){
    return this.post<EmployeeVacation>(model);
  }
}
