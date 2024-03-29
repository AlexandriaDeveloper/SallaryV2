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
import { FormEmployeeOrderDetailsDataSource } from './form-employee-order-details-dataSource';

@Component({
  selector: 'app-form-employee-order-details',
  templateUrl: './form-employee-order-details.component.html',
  styleUrls: ['./form-employee-order-details.component.scss']
})
export class FormEmployeeOrderDetailsComponent implements OnInit,AfterViewInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<any>;

  dataSource: FormEmployeeOrderDetailsDataSource;
  ordersParam:OrderFileDetailsParam= new OrderFileDetailsParam();
  formId;
  displayedColumns = ['action','tabCode','tegaraCode', 'employeeName','orderName','amount'];

  constructor (
    public dialog :MatDialog, private router : ActivatedRoute
    , private orderFileService:EmployeeOrderFileDetailsService){}


    ngOnInit(): void {
      this.ordersParam.formId= this.router.snapshot.params['id'];



    }
  ngAfterViewInit(): void {
    this.ordersParam.isPagination=true;
     this.ordersParam.pageIndex=0;
     this.dataSource = new FormEmployeeOrderDetailsDataSource(this.orderFileService,this.ordersParam, this.paginator);

      this.table.dataSource = this.dataSource;
      this.paginator=this.dataSource.paginator;
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
       this.table.dataSource = this.dataSource.connect();
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
       this.table.dataSource = this.dataSource.connect();
     });
   }
   handlePageEvent(event: PageEvent) {
     this.dataSource.orderParam.pageIndex=event.pageIndex;
     this.table.dataSource = this.dataSource.connect();
   }

   searchBox(ev) {
     ev.elementValue.subscribe(x => {
       this.ordersParam = Object.assign(this.ordersParam,x.Param);
       this.table.dataSource=this.dataSource.connect()})

   }

   sortData(ev){
     this.ordersParam=ev;
     this.table.dataSource=this.dataSource.connect()
   }
   clearSerach(ev){
     this.ordersParam=ev;
     this.table.dataSource=this.dataSource.connect()
   }
   deleteOrderDetails(row){

     if(confirm (` أنت على وشك حذف الامر الخاص ب ${row.employeeName} هل انت متأكد`)){
       this.orderFileService.deleteEmployeeOrderDetails(row.id).subscribe(
           x=>{
             this.table.dataSource = this.dataSource.connect();
           })
     }

   }
}
