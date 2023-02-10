import { IEmployee } from './../../shared/models/employee/employee';
import { FormService } from '../../shared/services/form.service';
import { EmployeeFormParam, FormListParam } from '../../shared/models/param';



import { DataSource } from '@angular/cdk/collections';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { map, tap } from 'rxjs/operators';
import { Observable, of as observableOf, merge, of, BehaviorSubject } from 'rxjs';
import { EmployeeFormService } from 'src/app/shared/services/employee-form.service';
import { EmployeeForm } from 'src/app/shared/models/employee/employee';
import { CdkDragDrop, moveItemInArray } from '@angular/cdk/drag-drop';

// TODO: Replace this with your own data model type


// TODO: replace this with real data from your application


/**
 * Data source for the EmployeeList view. This class should
 * encapsulate all logic for fetching and manipulating the displayed data
 * (including sorting, pagination, and filtering).
 */
export class EmployeeFormDataSource  extends DataSource<EmployeeForm>  {
  dataSubject :BehaviorSubject<EmployeeForm[]>=new BehaviorSubject<EmployeeForm[]>([]);
  data = new Observable<EmployeeForm[]>;
  paginator: MatPaginator | undefined;
  sort: MatSort | undefined;
  employeeFormParam:EmployeeFormParam;
  ids:number[];
  constructor( private employeeFormService:EmployeeFormService, param :EmployeeFormParam,  paginatorSource? :MatPaginator) {
    super();

      if(paginatorSource!=null){
        this.paginator= paginatorSource;
      }

      this.employeeFormParam=param;
  }


  /**
   * Connect this data source to the table. The table will only update when
   * the returned stream emits new items.
   * @returns A stream of the items to be rendered.
   */
  connect():Observable< EmployeeForm[]>{


     this.data=this.loadData();


    return this.data;
  }

  loadData():Observable<EmployeeForm[]>{

    return   this.employeeFormService.GetEmployeesByFormId(this.employeeFormParam).pipe(map((x:any) => {

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

  drop(ev : CdkDragDrop<EmployeeForm[]>) {
  this.ids=[];
//this.ids=ev.container.data.map(x => x.id)

  this.data= this.data.pipe(map((x : EmployeeForm[])=>{
    moveItemInArray(x,ev.previousIndex,ev.currentIndex);
    return x;
  }),tap(t => {
    this.ids=t.map(j=> j.id);
    this.reorderData();
  }));
  return this.data
}

reorderData(){
  this.employeeFormService.updateEmployeeFormRow(this.ids).subscribe();

}

}
