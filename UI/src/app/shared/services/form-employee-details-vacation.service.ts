import { HttpParams } from '@angular/common/http';
import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FormEmployeeDetailsVacationService extends HttpCustomClientService{

  constructor() { super('formEmployeeVacation')}

  getVacationsByFormId (formId :number){
    let params = new HttpParams();
    params = params.append('formId',formId);
    return this.http.get(this.baseApiUrl,{params})
  }
}
