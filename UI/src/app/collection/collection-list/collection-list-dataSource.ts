import { Collection } from './../../shared/models/employee/employee';
import { CollectionService } from './../../shared/services/collection.service';
import { OrderFileParam } from '../../shared/models/param';
import { OrderFileService } from 'src/app/shared/services/order-file.service';
import { OrderFile } from '../../shared/models/employee/employee';
import { MatPaginator } from '@angular/material/paginator';
import { map, Observable } from 'rxjs';
import { MatSort } from '@angular/material/sort';
import { DataSource } from '@angular/cdk/collections';
export class CollectionListDataSource  extends DataSource<Collection>  {
  data = new Observable<Collection[]>;
  paginator: MatPaginator | undefined;
  sort: MatSort | undefined;


  constructor(private collectionService :CollectionService,   paginatorSource? :MatPaginator) {
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
  connect():Observable< Collection[]>{

          this.data= this.collectionService.getAllCollections().pipe(map((x:any) => {

            // this.paginator.length=x.pagination.length;

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
