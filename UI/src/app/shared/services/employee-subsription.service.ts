import { EmployeeSubsriptionParam } from './../models/param';
import { Injectable } from '@angular/core';
import { HttpCustomClientService } from './http-custom-client.service';
import { HttpParams } from '@angular/common/http';
import { AddEmployeeSubscription, EmployeeSubscription } from '../models/employee/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeSubsriptionService extends HttpCustomClientService{


  constructor() { super('employeeSubscriptions')}

  getEmployeeSubscription(param : EmployeeSubsriptionParam){
    let params = new HttpParams();
    //SubsriptionId
    if( param.subsriptionId !==null)
        params = params.append('subsriptionId',param.subsriptionId);

    if( param.employeeName !==null)
        params = params.append('employeeName',param.employeeName);

    if( param.employeeNationalId !==null)
        params = params.append('employeeNationalId',param.employeeNationalId);

    if( param.employeeTabCode !==null)
        params = params.append('employeeTabCode',param.employeeTabCode);

    if( param.employeeTegaraCode !==null)
        params = params.append('employeeTegaraCode',param.employeeTegaraCode);

    if( param.employeeSection !==null)
      params = params.append('employeeSection',param.employeeSection);


      if( param.amount !==null)
      params = params.append('amount',param.amount);

    return this.getAll(params,param);
  }

  getEmployeeSubscriptionByEmployeeId(employeeId:number){
    return this.getById(employeeId,"GetEmployeeSubscriptionBalanceByEmployeeId")

  }

  getEmployeeSubscriptionById(id:number){
    return this.getById(id,"getEmployeeSubscriptionById")

  }
  addEmployeeToSubscription(model:AddEmployeeSubscription) {
        return this.post(model,'AssignEmployeeToSubscription');
  }
  updateEmployeeSubscriptionActiveToggle(employeeSubsriptionId:number){


    return this.http.put( this.baseApiUrl+'/updateEmployeeSubscriptionActiveToggle/'+employeeSubsriptionId ,{})
  }

  updateEmployeeSubscrtiption(model){

    return this.http.put( this.baseApiUrl+'/updateEmployeeSubscrtiption/' ,model)
  }
  deleteEmployeeFromSubscription(id){
      return this.delete(id,'deleteEmployeeFromSubscription')
  }
}
