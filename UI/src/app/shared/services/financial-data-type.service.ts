import { FinancialDataType } from './../models/employee/employee';
import { HttpParams } from '@angular/common/http';
import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';
import { FinancialDataTypeParam } from '../models/param';

@Injectable({
  providedIn: 'root'
})
export class FinancialDataTypeService  extends HttpCustomClientService{

  constructor() {super('financialDataType') }


  getAllFinicialDataType(param :  FinancialDataTypeParam ){

    let params = new HttpParams();
    if(param.financialDataTypesId )
    {

     params= params.append('financialDataTypesId',param.financialDataTypesId);
    }

    if(param.name )
    {

     params= params.append('name',param.name);
    }

    if(param.reservationDate!== null )
    {

     params= params.append('reservationDate',param.reservationDate.toString());
    }
      return this.http.get(this.baseApiUrl, {params})
  }

  postFinicialDataType(model : FinancialDataType){
    return this.http.post(this.baseApiUrl,model);
  }
  putFinicialDataType(model : FinancialDataType){
    return this.http.put(this.baseApiUrl,model);
  }
  deleteFinicialDataType(id :number){
    return this.delete(id);
  }
}
