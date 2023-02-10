import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { HttpCustomClientService } from './http-custom-client.service';

@Injectable({
  providedIn: 'root'
})
export class PeriodicSubscriptionService extends HttpCustomClientService {

  constructor() {super ('periodicSubscription') }

  addPeriodicSubscriptionDto(model ){
    return this.post(model);
  }

addEmployeeToPeriodicSubscription(model ){
  return this.post(model,'addEmployeeToPeriodicSubscription');
}
  getHistoryPeriodicSubscription (employeeId, subscriptionId){

    let params = new HttpParams();
    params= params.append('employeeId',employeeId);
    params=  params.append('subscriptionId',subscriptionId)

    return this.http.get(this.baseApiUrl+'/periodicSubscriptionHistoryByEmployee',{params})
  }

  getPeriodicSubscriptionByFormId (formId, subscriptionId){

    let params = new HttpParams();
    params= params.append('formId',formId);
    params=  params.append('subscriptionId',subscriptionId)

    return this.http.get(this.baseApiUrl+'/GetEmployeesSubscriptionByFormIdQuery',{params})
  }
  getPeriodicSubscriptionById(id){

    return this.http.get(this.baseApiUrl+'/getPeriodicSubscriptionById/'+id)
  }

  updatePeriodicSubscriptionById(model){

    return this.http.put(this.baseApiUrl,model);
  }
  deletePeriodicSubscriptionById(id){

    return this.delete(id);
  }
}
