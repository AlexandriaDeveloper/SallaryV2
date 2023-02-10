import { HttpParams } from '@angular/common/http';
import { FormListParam } from './../models/param';
import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';
import { Form } from '../models/employee/employee';

@Injectable({
  providedIn: 'root'
})
export class FormService extends HttpCustomClientService {

  constructor() {super('form') }

  getAllPagedForm (param : FormListParam ){
  var params = new HttpParams();

    return this.getAll(params,param)
  }

  postForm(model : Form){
    return this.post(model);
  }

  deleteForm(id){
    return this.delete(id);
  }
}
