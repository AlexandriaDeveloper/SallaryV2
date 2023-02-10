import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { employeeCollectionListParam } from '../models/param';
import { HttpCustomClientService } from './http-custom-client.service';

@Injectable({
  providedIn: 'root'
})
export class EmployeeCollectionService extends HttpCustomClientService {

  constructor() { super('employeeCollection')}
  getEmployeeCollection(collectionParam :employeeCollectionListParam){
    let params = new HttpParams();
    params = params.append('collectionId',collectionParam.collectionId);
    return this.getAll(params,collectionParam);
  }
  postEmployeeToCollection(model){
    return this.post(model);
  }

  updateEmployeeCollectionRow(ids:number[]){
    return this.http.put(this.baseApiUrl+'/reorderRows',ids);
  }

  deleteEmployeeFromCollection(id : number){
    return this.delete(id,'DeleteEmployeeFromCollection');
  }
}
