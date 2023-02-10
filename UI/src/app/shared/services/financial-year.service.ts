import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FinancialYearService extends HttpCustomClientService {

  constructor() {
    super('financialYear/')
   }
   getAllFinancialYears(){
    return this.http.get(this.baseApiUrl);

   }
   getLastFinancialYear(){

    return this.http.get(this.baseApiUrl+'getLastFinancialYear');
   }
}
