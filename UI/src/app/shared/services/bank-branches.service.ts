import { BankBranch } from './../models/employee/employee';
import { Injectable } from '@angular/core';
import { HttpCustomClientService } from './http-custom-client.service';

@Injectable({
  providedIn: 'root'
})
export class BankBranchesService extends HttpCustomClientService {

  constructor() {super('BankBranch') }
  getAllBranchesByBankId( bankId:number){
    return this.http.get(this.baseApiUrl+'/'+bankId)
  }
  postBankBranch(model :BankBranch){
    return this.post(model);
  }
  updateBankBranch(model :BankBranch){
    return this.put(model);
  }
  deleteBankBranch(id:number){
    return this.delete(id);
  }

}
