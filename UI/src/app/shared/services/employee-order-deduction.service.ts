import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EmployeeOrderDeductionService extends HttpCustomClientService {

  constructor() {super('employeeOrderDeduction') }

  GetEmployeeOrderBalance(orderId : number){
    return this.getById(orderId,'GetEmployeeOrderBalance');
  }

  postEmployeeDeduction(model){
    debugger
    return this.post(model,'payDeductionEmployee');

  }
}
