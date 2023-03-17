import { BalanceElementDetailsDialogComponent } from './balance-element-details-dialog/balance-element-details-dialog.component';
import { GetEmployeeElementDetailsParam } from './../../../shared/models/param';
import { EmployeePartTimeComponent } from './employee-part-time/employee-part-time.component';
import { EmployeePartTimeDialogComponent } from './employee-part-time-dialog/employee-part-time-dialog.component';
import { PayDeductionDialogComponent } from './pay-deduction-dialog/pay-deduction-dialog.component';
import { EmployeeOrderDeductionService } from './../../../shared/services/employee-order-deduction.service';
import { EmployeeMonthlyTotalOrderAndDeductionsService } from './../../../shared/services/employee-monthly-total-order-and-deductions.service';
import { IEmployeeBasicSallary, IEmployeeTotalOrdersAndDeductions } from './../../../shared/models/employee/employee';
import { Component, Input, AfterViewInit, OnInit } from '@angular/core';
import { EmployeeBasicSallaryService } from 'src/app/shared/services/employee-basic-sallary.service';
import { ActivatedRoute } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { BalanceHistoryDialogComponent } from './balance-history-dialog/balance-history-dialog.component';
import { EmployeeBasicFinicialDataService } from 'src/app/shared/services/employee-basic-finicial-data.service';
import * as moment from 'moment';

@Component({
  selector: 'app-balance',
  templateUrl: './balance.component.html',
  styleUrls: ['./balance.component.scss']
})
export class BalanceComponent  implements OnInit, AfterViewInit{
  @Input('editable') editable=false;
  @Input('employee') employee

  empId ;
 employeeBasicSallary:IEmployeeBasicSallary;
 employeeOrderDeductions: IEmployeeTotalOrdersAndDeductions;
 selectedDate ;
  /**
   *
   */
  constructor(private activatedRoute :ActivatedRoute,
  private employeeBasicSallarySevice : EmployeeBasicSallaryService,
  private employeeOrderDeductionService :EmployeeOrderDeductionService,

  public dialog: MatDialog
  ) {


  }
  ngOnInit(): void {
    this.selectedDate= new Date()//moment().toISOString();
  }
  ngAfterViewInit(): void {
    this.empId =this.activatedRoute.snapshot.params['id'];
  this.loadEmployeeFincialData();
    this.loadDeduction();

  }

  loadEmployeeFincialData(){
    this.employeeBasicSallarySevice.getLastBasicSallary(this.empId,this.selectedDate).subscribe((x:IEmployeeBasicSallary) => this.employeeBasicSallary=x);
  }

  loadDeduction(){

    this.employeeOrderDeductionService.GetEmployeeOrderBalance(this.empId).subscribe((x:IEmployeeTotalOrdersAndDeductions) => {
      this.employeeOrderDeductions=x;
    })
  }
  openDialog(orderId): void {
    const dialogRef = this.dialog.open(BalanceHistoryDialogComponent, {
      data: {employeeId: this.employeeOrderDeductions.employeeId, orderId: orderId},
     minWidth:'1200px',
     minHeight:'500px',
     maxHeight:'900px',
     hasBackdrop:true
    });

    dialogRef.afterClosed().subscribe(result => {
  this.loadEmployeeFincialData();
    });
  }
  openPartTimeDialog(): void {
    const dialogRef = this.dialog.open(EmployeePartTimeDialogComponent, {
      data: {employeeId: this.employeeOrderDeductions.employeeId,employee:this.employee},
     minWidth:'400px',

     hasBackdrop:true
    });

    dialogRef.afterClosed().subscribe(result => {
    //  this.animal = result;
     this.loadDeduction();
    });
  }

  openPartTimeHistoryDialog(): void {
    const dialogRef = this.dialog.open(EmployeePartTimeComponent, {
      data: {employeeId: this.employeeOrderDeductions.employeeId,employee:this.employee},
     minWidth:'800px',

     hasBackdrop:true
    });

    dialogRef.afterClosed().subscribe(result => {
 this.loadDeduction();
    });
  }

  openPayDeductionDialog(orderId): void {
    const dialogRef = this.dialog.open(PayDeductionDialogComponent, {
      data: { orderId: orderId ,employeeId :this.employeeOrderDeductions.employeeId},
     minWidth:'400px',
     minHeight:'300px',
     maxHeight:'900px',
     hasBackdrop:true
    });

    dialogRef.afterClosed().subscribe(result => {
    //  this.animal = result;

    this.loadDeduction();
    });
  }

//   getFincicialData(id){

//     let time  = moment().toISOString();

//     let param = new GetEmployeeElementDetailsParam();
//     param.reservationDate=moment().toISOString();


// param.finicialDataTypeId=id;
// param.employeeId=this.employeeOrderDeductions.employeeId;

//     this.employeeBasicFinicialDataService
//     .GetEmployeeElementDetailsQuery(param)
//     .subscribe( x=> console.log(x));
//   }

dateChange(ev){
  let time  = moment( ev.target.value._d,'YYYY-MM-DD').add(2,'hours');
   this.selectedDate=time.toDate();
   this.loadEmployeeFincialData()
}


  getFincicialData(id){
    let time  = moment(this.selectedDate).toISOString();

    let param = new GetEmployeeElementDetailsParam();
    param.reservationDate=moment().toISOString();
    const dialogRef = this.dialog.open(BalanceElementDetailsDialogComponent, {
      data: { employeeId :this.employeeOrderDeductions.employeeId , finicialDataTypeId:id,date:time},
    maxHeight:'900px',
     hasBackdrop:true,
     disableClose:true
    });

    dialogRef.afterClosed().subscribe(result => {
    //  this.animal = result;

    this.loadEmployeeFincialData();
    });
  }
}


