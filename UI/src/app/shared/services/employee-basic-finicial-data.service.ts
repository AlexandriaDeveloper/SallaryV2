import { HttpParams } from '@angular/common/http';
import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';
import { GetEmployeeElementDetailsParam } from '../models/param';

@Injectable({
  providedIn: 'root'
})
export class EmployeeBasicFinicialDataService extends HttpCustomClientService {

  constructor() {super('EmployeeBasicFinincialData') }

  GetEmployeeElementDetailsQuery( param :GetEmployeeElementDetailsParam){
    let params = new HttpParams();


    params = params.append('employeeId',param.employeeId);
    params = params.append('finicialTypeId',param.finicialDataTypeId);
    params = params.append('date',param.reservationDate);
    return this.getAll (params, param, 'GetEmployeeElementDetails')
  }

  postEmployeeElement(model){

    return this.post(model,'AddEmployeeElement')
  }
  updateEmployeeFincialElementById(model){
    return this.put(model);

  }
  deleteEmployeeFincialElementById(id){

    return this.delete(id,)
  }

}
