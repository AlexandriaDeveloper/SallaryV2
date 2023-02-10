
import {  IEmployee } from './../../shared/models/employee/employee';
import { DataSource } from '@angular/cdk/collections';
import { MatPaginator, MatPaginatorIntl } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { map } from 'rxjs/operators';
import { Observable, of as observableOf, merge, of, BehaviorSubject } from 'rxjs';
import { OnInit, AfterViewInit, ChangeDetectorRef, inject, Injectable, Inject } from '@angular/core';
import { EmployeeService } from 'src/app/shared/services/employee.service';
import { EmployeeParam } from 'src/app/shared/models/param';

// TODO: Replace this with your own data model type


// TODO: replace this with real data from your application


/**
 * Data source for the EmployeeList view. This class should
 * encapsulate all logic for fetching and manipulating the displayed data
 * (including sorting, pagination, and filtering).
 */
export class EmployeeListDataSource  extends DataSource<IEmployee>  {
  data = new Observable<IEmployee[]>;
  paginator: MatPaginator | undefined;
  sort: MatSort | undefined;
  employeeParam:EmployeeParam;

  constructor( private employeeService:EmployeeService, param :EmployeeParam,  paginatorSource? :MatPaginator) {
    super();

      if(paginatorSource!=null){
        this.paginator= paginatorSource;
      }

      this.employeeParam=param;
  }


  /**
   * Connect this data source to the table. The table will only update when
   * the returned stream emits new items.
   * @returns A stream of the items to be rendered.
   */
  connect():Observable< IEmployee[]>{


          this.data= this.employeeService.getEmployees(this.employeeParam).pipe(map((x:any) => {

       //     this.paginator.pageIndex+=x.pagination.pageIndex+1;
             this.paginator.length=x.pagination.length;
            // this.paginator.pageSize=x.pagination.pageSize;

            // this.employeeParam.pageIndex=x.pagination.pageIndex;
            return x.data
          }));



    // if (this.paginator && this.sort) {
    //   // Combine everything that affects the rendered data into one update
    //   // stream for the data-table to consume.
    //   return merge(observableOf(this.data), this.paginator.page, this.sort.sortChange)
    //     .pipe(map(() => {
    //       return this.getPagedData(this.getSortedData([...this.data ]));
    //     }));
    // } else {
    //   throw Error('Please set the paginator and sort on the data source before connecting.');
    // }
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
