import { HttpClient, HttpParams } from '@angular/common/http';
import { HttpCustomClientService } from './http-custom-client.service';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CollectionService extends HttpCustomClientService {

  constructor() { super('collection')}


  getAllCollections(){

    return this.getList();
  }
  getCollectionById(id:number){

    return this.getById(id);
  }

  postCollection(model){
    return this.post(model);
  }
}
