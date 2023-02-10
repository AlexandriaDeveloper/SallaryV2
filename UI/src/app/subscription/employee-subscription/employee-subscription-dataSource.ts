import { EmployeeSubsriptionParam } from './../../shared/models/param';
import { EmployeeSubsriptionService } from './../../shared/services/employee-subsription.service';
import {  EmployeeSubscription } from '../../shared/models/employee/employee';
import { CollectionService } from '../../shared/services/collection.service';

import { MatPaginator } from '@angular/material/paginator';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { MatSort } from '@angular/material/sort';
import { DataSource } from '@angular/cdk/collections';
export class EmployeeSubscriptionDataSource  extends DataSource<EmployeeSubscription>  {

  dataSubject :BehaviorSubject<EmployeeSubscription[]>=new BehaviorSubject<EmployeeSubscription[]>([]);
  data = new Observable<EmployeeSubscription[]>;
  paginator: MatPaginator | undefined;
  sort: MatSort | undefined;
  employeeSubscriptionParam:EmployeeSubsriptionParam;
  ids:number[];
  constructor( private employeeSubscriptionService:EmployeeSubsriptionService, param :EmployeeSubsriptionParam,  paginatorSource? :MatPaginator) {
    super();

      if(paginatorSource!=null){
        this.paginator= paginatorSource;
      }

      this.employeeSubscriptionParam=param;
  }


  /**
   * Connect this data source to the table. The table will only update when
   * the returned stream emits new items.
   * @returns A stream of the items to be rendered.
   */
  connect():Observable< EmployeeSubscription[]>{


     this.data=this.loadData();


    return this.data;
  }

  loadData():Observable<EmployeeSubscription[]>{

    return   this.employeeSubscriptionService.getEmployeeSubscription(this.employeeSubscriptionParam).pipe(map((x:any) => {

      this.paginator.length=x.pagination.length;
      this.dataSubject.next(x.data);
      this.ids=x.data.map(t => t.id);
      return this.dataSubject.value;
   }));


  }

  /**
   *  Called when the table is being destroyed. Use this function, to clean up
   * any open connections or free any held resources that were set up during connect.
   */
  disconnect(): void {}

//   drop(ev : CdkDragDrop<EmployeeForm[]>) {
//   this.ids=[];
// //this.ids=ev.container.data.map(x => x.id)

//   this.data= this.data.pipe(map((x : EmployeeForm[])=>{
//     moveItemInArray(x,ev.previousIndex,ev.currentIndex);
//     return x;
//   }),tap(t => {
//     this.ids=t.map(j=> j.id);
//     this.reorderData();
//   }));
//   return this.data
// }

// reorderData(){
//   this.employeeFormService.updateEmployeeFormRow(this.ids).subscribe((x)=>{

// }

}
