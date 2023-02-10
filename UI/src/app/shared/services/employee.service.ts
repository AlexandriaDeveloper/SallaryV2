import { environment } from './../../../environments/environment';
import { HttpCustomClientService } from './http-custom-client.service';
import { EmployeeParam } from './../models/param';
import { Injectable } from '@angular/core';

import { IEmployee } from '../models/employee/employee';
import{Observable}from'rxjs'
import { HttpParams, HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class EmployeeService extends HttpCustomClientService {
/**
 *
 */
url =environment.apiUrl;
constructor(private httpCall : HttpClient) {
  super('employee')

}
  getEmployees(employeeParam :EmployeeParam):Observable<IEmployee[]>{

    var param = new HttpParams();
    if(employeeParam.name)
    param =param.append('name',employeeParam.name)
    if(employeeParam.nationalId)
    param =param.append('nationalId',employeeParam.nationalId)
    if(employeeParam.tabCode)
    param =param.append('tabCode',employeeParam.tabCode)
    if(employeeParam.tegaraCode)
    param =param.append('tegaraCode',employeeParam.tegaraCode)
    if(employeeParam.section)
    param =param.append('section',employeeParam.section)
    if(employeeParam.employeeHasBank !==null)
    param=param.append("employeeHasBank",employeeParam.employeeHasBank.toString())
    return this.getAll<IEmployee[]>(param,employeeParam);

  }

  getEmployee(id:number):Observable< IEmployee>{
    return this.getById<IEmployee>(id);
  }


  getEmployeeInForm(id:number, formId:number ):Observable<IEmployee>{
if(formId)
    return this.http.get<IEmployee>(this.baseApiUrl+'/'+id+'?formId='+formId)
    else{

      return this.http.get<IEmployee>(this.baseApiUrl+'/'+id)
    }
  }
  findEmployeeByTabCodeOrTegaraCode (tabCode : string,tegaraCode:string) :Observable< IEmployee>{
    let params = new HttpParams();
    if(tabCode!=='')
      params= params.append('tabCode',tabCode);
    if(tegaraCode!=='')
      params= params.append('tegaraCode',tegaraCode);

      return this.httpCall.get<IEmployee>(this.baseApiUrl+'/GetEmployeeByTabCodeOrTegaraCode',{params});
  }





}
