import { Injectable } from '@angular/core';
import { EmployeeOrder } from '../models/employee/employee';
import { HttpCustomClientService } from './http-custom-client.service';

@Injectable({
  providedIn: 'root'
})
export class OrderService  extends HttpCustomClientService{

  constructor() {
    super('order')
   }


  getAllOrders(){
    return this.getAll(null,null);
  }


}
