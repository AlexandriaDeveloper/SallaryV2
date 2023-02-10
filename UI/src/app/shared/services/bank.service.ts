import { Injectable } from '@angular/core';
import { HttpCustomClientService } from './http-custom-client.service';

@Injectable({
  providedIn: 'root'
})
export class BankService extends HttpCustomClientService {

  constructor() {super('Bank') }
  getAllBanks(){
    return this.getList();
  }
  postBank(model){
    return this.post(model);
  }
  updateBank(model){
    return this.http.put(this.baseApiUrl,model);
  }
  deleteBank(id){
    return this.delete(id);
  }
}
