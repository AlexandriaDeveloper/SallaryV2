import { IEmployee, IEmployeeBasicSallary, IEmployeeTotalOrdersAndDeductions } from './../models/employee/employee';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpCustomClientService } from './http-custom-client.service';

@Injectable({
  providedIn: 'root'
})
export class EmployeeBasicSallaryService  extends HttpCustomClientService{

  constructor() {
    super('employeeBasicSallary')
  }

  getLastBasicSallary(id:number):Observable<IEmployeeBasicSallary>{

    return this.getById<IEmployeeBasicSallary>(id);
  }
}
