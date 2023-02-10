import { AddFormSubscriptionDialogComponent } from './add-form-subscription-dialog/add-form-subscription-dialog.component';
import { AddEmployeeToFormComponent } from './add-employee-to-form/add-employee-to-form.component';
import { AddEmployeeFormCollectionDialogComponent } from './add-employee-form-collection-dialog/add-employee-form-collection-dialog.component';
import { AddCollectionDialogComponent } from './../../collection/collection-list/add-collection-dialog/add-collection-dialog.component';
import { EmployeeFormService } from './../../shared/services/employee-form.service';
import { EmployeeFormDataSource } from './employee-form-datasource';
import { EmployeeFormParam } from './../../shared/models/param';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeForm, IEmployee } from './../../shared/models/employee/employee';
import { Component, AfterViewInit, ViewChild, OnInit } from '@angular/core';
import { MatTable } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatDialog } from '@angular/material/dialog';
import { CdkDragDrop, moveItemInArray } from '@angular/cdk/drag-drop';
import { EmployeeService } from 'src/app/shared/services/employee.service';

@Component({
  selector: 'app-employee-form-details',
  templateUrl: './employee-form-details.component.html',
  styleUrls: ['./employee-form-details.component.scss']
})
export class EmployeeFormDetailsComponent implements OnInit, AfterViewInit {
  //employees :IEmployee[];
  displayedColumns =['action','employeeTabCode','employeeTegaraCode','employeeName','employeeNationalId','employeeSection']
  formId : number
  dataSource : EmployeeFormDataSource;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<EmployeeForm>;
  enmployeeFormParam = new EmployeeFormParam();

  /**
   *
   */
  constructor(private router : ActivatedRoute ,
    private route : Router,
    private employeeFormService : EmployeeFormService, private employeeService : EmployeeService,public dialog: MatDialog) {


  }
  ngOnInit(): void {
    this.formId= this.router.snapshot.params['id']
  }
  ngAfterViewInit(): void {

   this.enmployeeFormParam.formId=this.formId;

   this.dataSource= new EmployeeFormDataSource(this.employeeFormService,this.enmployeeFormParam,this.paginator);
   this.table.dataSource=this.dataSource;

  }
  handlePageEvent(event: PageEvent) {
    this.dataSource.employeeFormParam.pageSize=event.pageSize;
    this.dataSource.employeeFormParam.pageIndex=event.pageIndex;
    this.table.dataSource = this.dataSource.connect();
   }


   searchBox(ev) {
    ev.elementValue.subscribe(x => {
      this.enmployeeFormParam = Object.assign(this.enmployeeFormParam,x.Param);
      this.table.dataSource=this.dataSource.connect()})

  }

  sortData(ev){
    this.enmployeeFormParam=ev;
    this.table.dataSource=this.dataSource.connect()
  }
  clearSerach(ev){
    this.enmployeeFormParam=ev;
    this.table.dataSource=this.dataSource.connect()
  }
  openCollectionDialog(){

    const dialogRef = this.dialog.open(AddEmployeeFormCollectionDialogComponent, {
      data: {formId: this.formId},
      minWidth:'600px',
      disableClose:true,
      hasBackdrop:true,
      panelClass:['dialogCss']
     });

     dialogRef.afterClosed().subscribe(result => {
       this.table.dataSource = this.dataSource.connect();
      // this.animal = result;
     });


  }
  openAddEmployeeDialog(){

    const dialogRef = this.dialog.open(AddEmployeeToFormComponent, {
      data: {formId: this.formId},
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
  drop(ev : CdkDragDrop<EmployeeForm[]>) {

   this.table.dataSource= this.dataSource.drop(ev);
   this.table.renderRows();
 }
 deleteEmployeeFromForm(row){
  if(confirm(`هل انت متأكد انك تريد حذف ${row.employeeName} من الملف ؟؟؟!`)){
    this.employeeFormService.deleteEmployeeFromForm(row.id).subscribe(x => {
      this.dataSource.reorderData();
       this.table.dataSource = this.dataSource.connect();
      })
  }
 }
 openAddSubscriptionDialog(){

  const dialogRef = this.dialog.open(AddFormSubscriptionDialogComponent, {
    data: {formId: this.formId},
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
navigateToEmployee(employeeId){

this.route.navigateByUrl('[employee]');
}

}
