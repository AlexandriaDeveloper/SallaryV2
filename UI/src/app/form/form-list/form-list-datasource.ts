import { FormService } from './../../shared/services/form.service';
import { FormListParam } from './../../shared/models/param';
import { Form } from './../../shared/models/employee/employee';


import { DataSource } from '@angular/cdk/collections';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { map } from 'rxjs/operators';
import { Observable, of as observableOf, merge, of, BehaviorSubject } from 'rxjs';

// TODO: Replace this with your own data model type


// TODO: replace this with real data from your application


/**
 * Data source for the EmployeeList view. This class should
 * encapsulate all logic for fetching and manipulating the displayed data
 * (including sorting, pagination, and filtering).
 */
export class FormListDataSource  extends DataSource<Form>  {
  data = new Observable<Form[]>;
  paginator: MatPaginator | undefined;
  sort: MatSort | undefined;
  formListParam:FormListParam;

  constructor( private formService:FormService, param :FormListParam,  paginatorSource? :MatPaginator) {
    super();

      if(paginatorSource!=null){
        this.paginator= paginatorSource;
      }

      this.formListParam=param;
  }


  /**
   * Connect this data source to the table. The table will only update when
   * the returned stream emits new items.
   * @returns A stream of the items to be rendered.
   */
  connect():Observable< Form[]>{


          this.data= this.formService.getAllPagedForm(this.formListParam).pipe(map((x:any) => {

             this.paginator.length=x.pagination.length;

            return x.data;
          }));
    return this.data;
  }

  /**
   *  Called when the table is being destroyed. Use this function, to clean up
   * any open connections or free any held resources that were set up during connect.
   */
  disconnect(): void {}

  /**
   * Paginate the data (client-side). If you're using server-side pagination,
   * this would be replaced by requesting the appropriate data from the server.
   */
  // private getPagedData(data: IEmployee[]): IEmployee[] {
  //   if (this.paginator) {

  //   }
  // }

  /**
   * Sort the data (client-side). If you're using server-side sorting,
   * this would be replaced by requesting the appropriate data from the server.
   */
//   private getSortedData(data: IEmployee[]) {
//     if (!this.sort || !this.sort.active || this.sort.direction === '') {
//       return data;
//     }


//   }
// }

/** Simple sort comparator for example ID/Name columns (for client-side sorting). */
// function compare(a: string | number, b: string | number, isAsc: boolean): number {
//   return (a < b ? -1 : 1) * (isAsc ? 1 : -1);
}
