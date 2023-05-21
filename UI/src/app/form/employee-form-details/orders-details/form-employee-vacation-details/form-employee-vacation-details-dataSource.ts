import { FormEmployeeDetailsVacationService } from './../../../../shared/services/form-employee-details-vacation.service';


import { MatPaginator } from '@angular/material/paginator';
import { map, Observable } from 'rxjs';
import { MatSort } from '@angular/material/sort';
import { DataSource } from '@angular/cdk/collections';
import { OrderFile } from 'src/app/shared/models/employee/employee';
import { OrderFileDetailsParam, OrderFileParam } from 'src/app/shared/models/param';
import { EmployeeOrderFileDetailsService } from 'src/app/shared/services/employee-order-file-details.service';
export class FormEmployeeVacationDetailsDataSource  extends DataSource<OrderFile>  {
  data = new Observable<OrderFile[]>;
  paginator: MatPaginator | undefined;
  sort: MatSort | undefined;
  orderParam :OrderFileDetailsParam= new OrderFileDetailsParam();

  constructor( private orderFileService :FormEmployeeDetailsVacationService, private param :OrderFileDetailsParam,  paginatorSource? :MatPaginator) {
    super();
if(paginatorSource!=null){
  this.paginator= paginatorSource;
}
  this.orderParam=param;
  }


  /**
   * Connect this data source to the table. The table will only update when
   * the returned stream emits new items.
   * @returns A stream of the items to be rendered.
   */
  connect():Observable< OrderFile[]>{
          this.data= this.orderFileService.getVacationsByFormId( this.orderParam.formId).pipe(map((x:any) => {

         //  this.paginator.length=x.pagination.length;
  console.log(x);
            return x
          }));



    return this.data;
  }

  /**
   *  Called when the table is being destroyed. Use this function, to clean up
   * any open connections or free any held resources that were set up during connect.
   */
  disconnect(): void {}


}
