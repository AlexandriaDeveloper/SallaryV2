import { Injectable } from '@angular/core';
import { HttpCustomClientService } from './http-custom-client.service';

@Injectable({
  providedIn: 'root'
})
export class EmployeeBankAccountService extends HttpCustomClientService{

  constructor() {super ('employeeBankAccount') }

  getEmployeeBankAccount (id:number){

    return this.getById(id)
  }

  postEmployeeBankAccount ( model ){

    return this.post(model);
  }

  deleteEmployeeBankAccount(employeeId){
    return this.delete(employeeId,'employeeRemoveBankAccount')
  }
}
