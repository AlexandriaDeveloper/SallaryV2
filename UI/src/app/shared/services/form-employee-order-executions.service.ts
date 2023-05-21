import { HttpParams } from '@angular/common/http';
import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';
import { FormEmployeeOrderExecutionsParam } from '../models/param';

@Injectable({
  providedIn: 'root'
})
export class FormEmployeeOrderExecutionsService extends HttpCustomClientService {

  constructor() {super('formEmployeeOrderExecution') }



  getBy(param: FormEmployeeOrderExecutionsParam){
   let params :HttpParams = new HttpParams();
    if(param.id !== null){
      params =params.append('id',param.id)
    }
    if(param.employeeId !== null){
      params =params.append('employeeId',param.employeeId)
    }
    if(param.creditOrDebit !== null){
      params =params.append('creditOrDebit',param.creditOrDebit)
    }
    if(param.orderId !== null){
      params =params.append('orderId',param.orderId)
    }
    return this.http.get(this.baseApiUrl+'/getByFormEmployeeId',{params})
  }
}
