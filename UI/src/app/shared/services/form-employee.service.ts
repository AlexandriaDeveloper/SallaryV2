import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FormEmployeeService extends HttpCustomClientService {

  constructor() {super('formEmployee') }

  getFormEmployeeByFormIdAndEmployeeId(formId,employeeId){
    return this.http.get(this.baseApiUrl+'/GetFormEmployeeByFormId',{params:{formId,employeeId}});
  }
}
