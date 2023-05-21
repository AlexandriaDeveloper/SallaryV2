import { FormEmployeeVacationDetailsDataSource } from './form-employee-vacation-details-dataSource';
import { FormEmployeeDetailsVacationService } from './../../../../shared/services/form-employee-details-vacation.service';
import { FormEmployeeOrderDetailsDataSource } from './../form-employee-order-details/form-employee-order-details-dataSource';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { ActivatedRoute } from '@angular/router';
import { OrderFileDetailsParam } from 'src/app/shared/models/param';
import { EmployeeOrderFileDetailsService } from 'src/app/shared/services/employee-order-file-details.service';
import { EmployeeVacationDialogComponent } from '../employee-vacation-dialog/employee-vacation-dialog.component';
import { NewEmployeeOrderDialogComponent } from '../new-employee-order-dialog/new-employee-order-dialog.component';

@Component({
  selector: 'app-form-employee-vacation-details',
  templateUrl: './form-employee-vacation-details.component.html',
  styleUrls: ['./form-employee-vacation-details.component.scss']
})
export class FormEmployeeVacationDetailsComponent implements OnInit ,AfterViewInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table2!: MatTable<any>;

 dataSource2: FormEmployeeVacationDetailsDataSource;
  ordersParam:OrderFileDetailsParam= new OrderFileDetailsParam();
  formId;

//  [
//     {
//       "id": 2,
//       "startAt": "2023-04-01T00:00:00",
//       "endAt": null,
//       "vacationId": 1,
//       "details": "",
//       "vacation": {
//           "id": 1,
//           "name": "اجازة بدون مرتب"
//       },
//       "employee": {
//           "id": 215,
//           "name": "محمد على شريف محمد",
//           "nationalId": "28505190201376",
//           "tabCode": "2309",
//           "tegaraCode": "9302",
//           "collageName": "كلية الطب",
//           "section": "اخصائي مؤقت ",
//           "employeeHasBank": false,
//           "employeeBankId": null
//       }
//   }
// ]
  displayedColumns = ['action','tabCode','tegaraCode', 'employeeName','vacationName','startAt','endAt'];

  constructor (
    public dialog :MatDialog, private router : ActivatedRoute
    , private orderFileService:FormEmployeeDetailsVacationService){}


    ngOnInit(): void {
      this.ordersParam.formId= this.router.snapshot.params['id'];



    }
  ngAfterViewInit(): void {
    this.ordersParam.isPagination=true;
     this.ordersParam.pageIndex=0;
     this.dataSource2 = new FormEmployeeVacationDetailsDataSource(this.orderFileService,this.ordersParam, this.paginator);

      this.table2.dataSource = this.dataSource2;
      this.paginator=this.dataSource2.paginator;
   }
   openEmployeeOrderDialog(): void {


     const dialogRef = this.dialog.open(NewEmployeeOrderDialogComponent, {
       data: {formId: this.ordersParam.formId},

       minWidth:'600px',
      // minHeight:'759px',
       disableClose:true,
       panelClass:['dialog']
     });

     dialogRef.afterClosed().subscribe(result => {
       //this.animal = result;
      // this.table.dataSource = this.dataSource.connect();
     });
   }
   openEmployeeVacationDialog(): void {
     const dialogRef = this.dialog.open(EmployeeVacationDialogComponent, {
       data: {formId: this.ordersParam.formId},

       maxWidth:'600px',
      // minHeight:'759px',
       disableClose:true,
       panelClass:['dialog']
     });

     dialogRef.afterClosed().subscribe(result => {
       //this.animal = result;
     //  this.table.dataSource = this.dataSource.connect();
     });
   }
   handlePageEvent(event: PageEvent) {
    // this.dataSource.orderParam.pageIndex=event.pageIndex;
    // this.table.dataSource = this.dataSource.connect();
   }

   searchBox(ev) {
     ev.elementValue.subscribe(x => {
       this.ordersParam = Object.assign(this.ordersParam,x.Param);
      // this.table.dataSource=this.dataSource.connect()
    })

   }

   sortData(ev){
     this.ordersParam=ev;
    // this.table.dataSource=this.dataSource.connect()
   }
   clearSerach(ev){
     this.ordersParam=ev;
    // this.table.dataSource=this.dataSource.connect()
   }
   deleteOrderDetails(row){

    //  if(confirm (` أنت على وشك حذف الامر الخاص ب ${row.employeeName} هل انت متأكد`)){
    //    this.orderFileService.deleteEmployeeOrderDetails(row.id).subscribe(
    //        x=>{
    //      //    this.table.dataSource = this.dataSource.connect();
    //        })
    //  }

   }
}
