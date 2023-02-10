import { EmployeePartTimeComponent } from './employee-part-time/employee-part-time.component';
import { EmployeePartTimeDialogComponent } from './employee-part-time-dialog/employee-part-time-dialog.component';
import { PayDeductionDialogComponent } from './pay-deduction-dialog/pay-deduction-dialog.component';
import { EmployeeOrderDeductionService } from './../../../shared/services/employee-order-deduction.service';
import { EmployeeMonthlyTotalOrderAndDeductionsService } from './../../../shared/services/employee-monthly-total-order-and-deductions.service';
import { IEmployeeBasicSallary, IEmployeeTotalOrdersAndDeductions } from './../../../shared/models/employee/employee';
import { Component, Input, AfterViewInit } from '@angular/core';
import { EmployeeBasicSallaryService } from 'src/app/shared/services/employee-basic-sallary.service';
import { ActivatedRoute } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { BalanceHistoryDialogComponent } from './balance-history-dialog/balance-history-dialog.component';

@Component({
  selector: 'app-balance',
  templateUrl: './balance.component.html',
  styleUrls: ['./balance.component.scss']
})
export class BalanceComponent  implements AfterViewInit{
  @Input('editable') editable=false;
  @Input('employee') employee

  empId ;
 employeeBasicSallary:IEmployeeBasicSallary;
 employeeOrderDeductions: IEmployeeTotalOrdersAndDeductions;
  /**
   *
   */
  constructor(private activatedRoute :ActivatedRoute,
  private employeeBasicSallarySevice : EmployeeBasicSallaryService,
  private employeeOrderDeductionService :EmployeeOrderDeductionService,
  public dialog: MatDialog
  ) {


  }
  ngAfterViewInit(): void {
    this.empId =this.activatedRoute.snapshot.params['id'];
    this.employeeBasicSallarySevice.getLastBasicSallary(this.empId).subscribe((x:IEmployeeBasicSallary) => this.employeeBasicSallary=x);
    this.loadDeduction();

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
    //  this.animal = result;
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
}


