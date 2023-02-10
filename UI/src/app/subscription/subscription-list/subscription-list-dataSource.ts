import { Sucription } from '../../shared/models/employee/employee';
import { CollectionService } from '../../shared/services/collection.service';
import { MatPaginator } from '@angular/material/paginator';
import { map, Observable } from 'rxjs';
import { MatSort } from '@angular/material/sort';
import { DataSource } from '@angular/cdk/collections';
import { SubscriptionService } from 'src/app/shared/services/subscription.service';
export class SubscriptionListDataSource  extends DataSource<Sucription>  {
  data = new Observable<Sucription[]>;
  paginator: MatPaginator | undefined;
  sort: MatSort | undefined;


  constructor(private subscriptionService :SubscriptionService,   paginatorSource? :MatPaginator) {
    super();
if(paginatorSource!=null){
  this.paginator= paginatorSource;
}

  }


  /**
   * Connect this data source to the table. The table will only update when
   * the returned stream emits new items.
   * @returns A stream of the items to be rendered.
   */
  connect():Observable< Sucription[]>{

          this.data= this.subscriptionService.getSubsriptionsList().pipe(map((x:any) => {
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
