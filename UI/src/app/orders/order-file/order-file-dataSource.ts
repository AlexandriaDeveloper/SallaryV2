import { OrderFileParam } from './../../shared/models/param';
import { OrderFileService } from 'src/app/shared/services/order-file.service';
import { OrderFile } from './../../shared/models/employee/employee';
import { MatPaginator } from '@angular/material/paginator';
import { map, Observable } from 'rxjs';
import { MatSort } from '@angular/material/sort';
import { DataSource } from '@angular/cdk/collections';
export class OrderFileDataSource  extends DataSource<OrderFile>  {
  data = new Observable<OrderFile[]>;
  paginator: MatPaginator | undefined;
  sort: MatSort | undefined;
  orderParam :OrderFileParam;

  constructor(private orderFileService :OrderFileService, private param :OrderFileParam,  paginatorSource? :MatPaginator) {
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


          this.data= this.orderFileService.getPaginatedOrder(this.orderParam).pipe(map((x:any) => {

             this.paginator.length=x.pagination.length;

            return x.data
          }));




    return this.data;
  }

  /**
   *  Called when the table is being destroyed. Use this function, to clean up
   * any open connections or free any held resources that were set up during connect.
   */
  disconnect(): void {}


}
