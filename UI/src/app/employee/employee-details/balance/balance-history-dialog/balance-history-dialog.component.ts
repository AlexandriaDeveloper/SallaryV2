import { Component, Inject, AfterViewInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { EmployeeMonthlyTotalOrderAndDeductionsService } from 'src/app/shared/services/employee-monthly-total-order-and-deductions.service';

@Component({
  selector: 'app-balance-history-dialog',
  templateUrl: './balance-history-dialog.component.html',
  styleUrls: ['./balance-history-dialog.component.scss']
})
export class BalanceHistoryDialogComponent implements AfterViewInit{
  balanceHistory:any;
  panelOpenState = false;
constructor(public dialogRef: MatDialogRef<BalanceHistoryDialogComponent>,
  @Inject(MAT_DIALOG_DATA) public data: any,

  private employeeMonthlyTotalOrderAndDeductionsService :EmployeeMonthlyTotalOrderAndDeductionsService,

  ){}
  ngAfterViewInit(): void {
    this.employeeMonthlyTotalOrderAndDeductionsService.getEmployeeMonthlyTotalOrderAndDeductionsHistoryDetailsService(this.data.employeeId, this.data.orderId).subscribe(x =>{

      this.balanceHistory=x;

    });
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
}
