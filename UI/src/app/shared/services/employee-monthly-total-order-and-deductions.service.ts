import { environment } from './../../../environments/environment';
import { HttpClient, HttpParams } from '@angular/common/http';
import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';
import { EmployeeOrder } from '../models/employee/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeMonthlyTotalOrderAndDeductionsService extends HttpCustomClientService {

  constructor(private httpCall :HttpClient) {
    super('employeeMonthlyCalculatSallary')

  }
  getEmployeeMonthlyTotalOrderAndDeductionsService(id : number){
    return this.getById(id,'GetEmployeeOrderBalance');
  }

  getEmployeeMonthlyTotalOrderAndDeductionsHistoryDetailsService(employeeId : number,orderId:number){
    debugger
     let params  = new HttpParams();
    params= params.append('employeeId',employeeId);
     params=params.append('orderId',orderId)
    return this.httpCall.get(environment.apiUrl+'employeeMonthlyCalculatSallary/GetEmployeeOrders',{params});
  }

  postNewOrder(model : EmployeeOrder){

    return this.post(model,'newEmployeeOrder');
  }
}
