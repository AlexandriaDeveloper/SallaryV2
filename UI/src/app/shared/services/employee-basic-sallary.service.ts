import { HttpParams } from '@angular/common/http';
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

  getLastBasicSallary(id:number,seletedDate : Date):Observable<IEmployeeBasicSallary>{
console.log(seletedDate)
     let params :HttpParams = new HttpParams();
     if(seletedDate != null){
      params = params.append('selectedDate',seletedDate.toLocaleDateString())
     }else{
      params = params.append('selectedDate',new Date().toLocaleDateString())
     }

    return this.http.get<IEmployeeBasicSallary>(this.baseApiUrl+'/'+id.toString(),{params});
  }
}
