import { HttpParams } from '@angular/common/http';
import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';
import { GetVacationTypeParam } from '../models/param';

@Injectable({
  providedIn: 'root'
})
export class VacationTypeService extends HttpCustomClientService {

  constructor() {super('vacationType') }
  getAllVacationType(param : GetVacationTypeParam ){

    let params =   new HttpParams();
    if( param.id !==null){
    params = params.append('id',param.id);
    }
    if( param.name !==null){
      params = params.append('name',param.name);
    }
    return this.getAll(params, param);
  }
}
