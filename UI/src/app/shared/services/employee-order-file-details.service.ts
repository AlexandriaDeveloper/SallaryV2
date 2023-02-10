import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { OrderFileDetailsParam } from '../models/param';
import { HttpCustomClientService } from './http-custom-client.service';

@Injectable({
  providedIn: 'root'
})
export class EmployeeOrderFileDetailsService extends HttpCustomClientService {

  constructor() {
    super('employeeOrderDetails')
   }

   GetEmployeeOrderDetailsByOrderFileIdDto(param :OrderFileDetailsParam){
    let params = new HttpParams()
   if(param.formId)
     params= params.append('formId',param.formId)
   if(param.employeeName)
   params=   params.append('employeeName',param.employeeName)
   if(param.tabCode)
   params=   params.append('tabCode',param.tabCode)
   if(param.tegaraCode)
   params=   params.append('tegaraCode',param.tegaraCode)
   if(param.orderName)
   params=   params.append('orderName',param.orderName)
   if(param.details)
   params=   params.append('details',param.details)
   if(param.amount)
   params=   params.append('amount',param.amount)
    return this.getAll (params,param,'GetEmployeeOrderDetailsByOrderFileIdDto' )

   }


   deleteEmployeeOrderDetails(employeeOrderId){

    return this.delete(employeeOrderId);
   }
}
