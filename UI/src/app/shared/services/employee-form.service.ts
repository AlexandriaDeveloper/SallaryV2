import { Observable } from 'rxjs';
import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';
import { EmployeeFormParam } from '../models/param';
import { HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeFormService extends HttpCustomClientService {
  updateEmployeeOrder(ids: any) {
    throw new Error('Method not implemented.');
  }

  constructor() {
    super ('formEmployee')
   }

   GetEmployeesByFormId(param : EmployeeFormParam){
    let params = new HttpParams();
    if( param.formId !==null)
        params = params.append('formId',param.formId);

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

    if( param.employeeCollageName !==null)
    params = params.append('employeeCollageName',param.employeeCollageName);

    return this.getAll(params,param);
   }
   getFormEmployeesByEmployeeIdAndFormId(employeeId : number,formId:number):Observable<any>{

    return this.http.get<any>(this.baseApiUrl+'/getEmployeesByEmployeeIdAndFormId',{params:{ employeeId:employeeId, formId:formId}})
   }
checkEmployeeExistInForm(employeeId : number,formId:number){
  let params = new HttpParams();
  params = params.append('employeeId',employeeId);
  params = params.append('formId',formId);
  return this.http.get(this.baseApiUrl+'/CheckEmployeeInFormByFormId/',{params})

}
   getCheckedSubscription(formId){
    return this.http.get(this.baseApiUrl+'/GetCheckedSubscriptionByFormId/'+formId)
   }
   PostEmployeeCollection(model){
    return this.post(model);
   }

   postEmployeeToForm(model){
    return this.post(model,'AddEmployeeToForm');

   }

   postEmployeeSubscription(formId,model){
    return this.http.post(this.baseApiUrl+'/AddEmployeeSubscriptionToForm/'+formId,model)

   }

   updateEmployeeFormRow(ids:number[]){
    return this.http.put(this.baseApiUrl+'/reorderRows',ids);
  }

  uploadSubscriptionElement(model){
      const formData = new FormData();
      formData.append('subscriptionId',model.subscriptionId);
      formData.append('formId', model.formId);
      formData.append('file', model.file ,model.file.name)

    return this.http.post(this.baseApiUrl+'/uploadEmployeeSubscriptionElement',formData, { reportProgress: true, observe: "events" });
  }
  deleteEmployeeFromForm(id:number){

    return this.delete(id);
  }

  deleteFormSubscriptionElement(formId,subscriptionId){

    return this.http.delete(this.baseApiUrl+'/deleteSubscriptionElement/'+formId,{params:{subscriptionId : subscriptionId}})
  }
}
