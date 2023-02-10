import { HttpClient, HttpParams } from '@angular/common/http';
import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class OrderFileService extends HttpCustomClientService {

  constructor() {
    super('orderFile')
   }

   getPaginatedOrder(param ) {
    let params = new HttpParams();
    return this.getAll( params,param,'GetPaginatedOrderFile') ;
   }

   postOrderFile(model){

    return this.post(model);
   }
}
