import { Injectable } from '@angular/core';
import { HttpCustomClientService } from './http-custom-client.service';

@Injectable({
  providedIn: 'root'
})
export class SubscriptionService extends HttpCustomClientService
{

  constructor() {super('subscription') }

  getSubsriptionsList(){
    return this.getList();
  }
  postSubsription(model){
    return this.post(model);
  }


}
