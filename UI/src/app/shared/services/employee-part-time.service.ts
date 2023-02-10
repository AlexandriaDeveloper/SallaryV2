import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EmployeePartTimeService extends HttpCustomClientService {

  constructor() {super('employeePartTime') }


  getEmployeePartTimeByEmployeeId(employeeId){
    return this.getById(employeeId,'GetEmployeeParttimeByEmployeeId');
  }
  getEmployeePartTimeHistoryByEmployeeId(employeeId){
    return this.getById(employeeId,'getEmployeeParttimeHistoryByEmployeeId');
  }

  employeeStartPartTime(model){

  return  this.post(model,'EmployeeStartPartTime')
  }

  updateStartPartTime(model){
    return this.put(model,'employeeEndPartTime')
  }
}
