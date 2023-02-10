import { employeeCollectionListParam } from './../../shared/models/param';
import { EmployeeCollectionService } from './../../shared/services/employee-collection.service';
import { EmployeeService } from './../../shared/services/employee.service';
import { IEmployee, employeeCollection } from './../../shared/models/employee/employee';
import { EmployeeOrderFileDetailsService } from '../../shared/services/employee-order-file-details.service';
import { OrderFileParam } from '../../shared/models/param';
import { OrderFileService } from 'src/app/shared/services/order-file.service';
import { OrderFile } from '../../shared/models/employee/employee';
import { MatPaginator } from '@angular/material/paginator';
import { map, Observable, BehaviorSubject } from 'rxjs';
import { MatSort } from '@angular/material/sort';
import { DataSource } from '@angular/cdk/collections';
export class EmployeeCollectionListDataSource  extends DataSource<employeeCollection>  {
  data = new Observable<employeeCollection[]>;
  data1 = new BehaviorSubject<employeeCollection[]>(null);
  paginator: MatPaginator | undefined;
  sort: MatSort | undefined;
 // orderParam :OrderFileParam= new OrderFileParam();

  constructor( private employeeCollectionService :EmployeeCollectionService,private employeeCollectionListParam :employeeCollectionListParam) {
    super();

  }


  /**
   * Connect this data source to the table. The table will only update when
   * the returned stream emits new items.
   * @returns A stream of the items to be rendered.
   */
  connect():Observable< employeeCollection[]>{

          this.data= this.employeeCollectionService.getEmployeeCollection( this.employeeCollectionListParam).pipe(map((x:any) => {
           this.data1.next(x);
            return x
          }));
      this.data1.subscribe();



    return this.data1.asObservable();
  }

  /**
   *  Called when the table is being destroyed. Use this function, to clean up
   * any open connections or free any held resources that were set up during connect.
   */
  disconnect(): void {}


}
