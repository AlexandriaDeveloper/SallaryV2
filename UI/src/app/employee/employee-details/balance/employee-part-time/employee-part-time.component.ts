import { EmployeePartTimeService } from './../../../../shared/services/employee-part-time.service';
import { Component, AfterViewInit, OnInit, Inject } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { EmployeePartTime } from 'src/app/shared/models/employee/employee';
import { EmployeePartTimeDialogComponent } from '../employee-part-time-dialog/employee-part-time-dialog.component';

@Component({
  selector: 'app-employee-part-time',
  templateUrl: './employee-part-time.component.html',
  styleUrls: ['./employee-part-time.component.scss']
})
export class EmployeePartTimeComponent implements AfterViewInit, OnInit {
  model :EmployeePartTime[]= [];
  /**
   *
   */
  constructor(public dialogRef: MatDialogRef<EmployeePartTimeComponent>,private dialog : MatDialog,
    @Inject(MAT_DIALOG_DATA) public data: any,private employeePartTimeService : EmployeePartTimeService) {


  }
  ngOnInit(): void {
  this.loadData()
  }

  loadData(){
    this.employeePartTimeService
    .getEmployeePartTimeHistoryByEmployeeId(this.data.employeeId)
    .subscribe((x:EmployeePartTime[]) => this.model=x)
  }
  ngAfterViewInit(): void {

  }
  onNoClick(){
    this.dialogRef.close()
  }
  openAddPartTime(){
    const dialogRef = this.dialog.open(EmployeePartTimeDialogComponent, {
      data: {employee:this.data.employee},
     minWidth:'400px',

     hasBackdrop:true
    });

    dialogRef.afterClosed().subscribe(result => {
   this.loadData();
    });
  }
}
