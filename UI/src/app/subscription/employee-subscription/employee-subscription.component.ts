import { AddEmployeeToSubscriptionComponent } from './add-employee-to-subscription/add-employee-to-subscription.component';
import { EmployeeSubsriptionService } from './../../shared/services/employee-subsription.service';
import { EmployeeSubscription } from './../../shared/models/employee/employee';
import { EmployeeSubscriptionDataSource } from './employee-subscription-dataSource';
import { Component, AfterViewInit, ViewChild } from '@angular/core';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { EmployeeSubsriptionParam } from 'src/app/shared/models/param';
import { ActivatedRoute } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-employee-subscription',
  templateUrl: './employee-subscription.component.html',
  styleUrls: ['./employee-subscription.component.scss']
})
export class EmployeeSubscriptionComponent implements AfterViewInit {
  employees :EmployeeSubscription[];
  displayedColumns =['action','employeeTabCode','employeeTegaraCode','employeeName','employeeNationalId','employeeSection','amount','isActive']
  subscriptionId : number
  dataSource : EmployeeSubscriptionDataSource;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<EmployeeSubscription>;
  employeeSubscriptionmParam = new EmployeeSubsriptionParam();

  /**
   *
   */
  constructor(private router : ActivatedRoute , private employeeFormService : EmployeeSubsriptionService,public dialog: MatDialog) {


  }
  ngAfterViewInit(): void {
   this.subscriptionId= this.router.snapshot.params['id']
   this.employeeSubscriptionmParam.subsriptionId=this.subscriptionId;

   this.dataSource= new EmployeeSubscriptionDataSource(this.employeeFormService,this.employeeSubscriptionmParam,this.paginator);
   this.table.dataSource=this.dataSource;
  }
  handlePageEvent(event: PageEvent) {
    this.dataSource.employeeSubscriptionParam.pageSize=event.pageSize;
    this.dataSource.employeeSubscriptionParam.pageIndex=event.pageIndex;
    this.table.dataSource = this.dataSource.connect();
   }


   searchBox(ev) {
    ev.elementValue.subscribe(x => {
      this.employeeSubscriptionmParam = Object.assign(this.employeeSubscriptionmParam,x.Param);
      this.table.dataSource=this.dataSource.connect()})

  }

  sortData(ev){
    this.employeeSubscriptionmParam=ev;
    this.table.dataSource=this.dataSource.connect()
  }
  clearSerach(ev){
    this.employeeSubscriptionmParam=ev;
    this.table.dataSource=this.dataSource.connect()
  }
  openCollectionDialog(){

    // const dialogRef = this.dialog.open(AddEmployeeFormCollectionDialogComponent, {
    //   data: {formId: this.formId},
    //   minWidth:'600px',
    //   disableClose:true,
    //   hasBackdrop:true,
    //   panelClass:['dialogCss']
    //  });

    //  dialogRef.afterClosed().subscribe(result => {
    //    this.table.dataSource = this.dataSource.connect();
    //   // this.animal = result;
    //  });


  }
  openAddEmployeeDialog(){

    const dialogRef = this.dialog.open(AddEmployeeToSubscriptionComponent, {
      data: {subscriptionId: this.subscriptionId},
      width:'500px',
      disableClose:true,
      hasBackdrop:true,
      panelClass:['dialogCss']
     });

     dialogRef.afterClosed().subscribe(result => {
       this.table.dataSource = this.dataSource.connect();
      // this.animal = result;
     });
  }
 deleteEmployeeFromForm(row){
  if(confirm(`هل انت متأكد انك تريد حذف ${row.employeeName} من الملف ؟؟؟!`)){
    this.employeeFormService.deleteEmployeeFromSubscription(row.id).subscribe(x => {

       this.table.dataSource = this.dataSource.connect();
      })
  }
 }
 playPause(row){

  this.employeeFormService.updateEmployeeSubscriptionActiveToggle(row.id).subscribe(x =>{
    row.isActive =x;
  })
 }
 openEditEmployeeDialog(row){

  const dialogRef = this.dialog.open(AddEmployeeToSubscriptionComponent, {
    data: {row: row,state:'edit',subscriptionId: this.subscriptionId},
    width:'500px',
    disableClose:true,
    hasBackdrop:true,
    panelClass:['dialogCss']
   });

   dialogRef.afterClosed().subscribe(result => {
     this.table.dataSource = this.dataSource.connect();
    // this.animal = result;
   });
}
}
