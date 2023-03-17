import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EmployeeRoutingModule } from './employee-routing.module';
import { EmployeeComponent } from './employee.component';
import { EmployeeListComponent } from './employee-list/employee-list.component';

import { TestTableComponent } from './test-table/test-table.component';
import { EmployeeDetailsComponent } from './employee-details/employee-details.component';
import { BalanceComponent } from './employee-details/balance/balance.component';
import { BalanceHistoryDialogComponent } from './employee-details/balance/balance-history-dialog/balance-history-dialog.component';
import { PayDeductionDialogComponent } from './employee-details/balance/pay-deduction-dialog/pay-deduction-dialog.component';
import { SubscriptionComponent } from './employee-details/subscription/subscription.component';
import { SubscriptionDeductionDialogComponent } from './employee-details/subscription/subscription-deduction-dialog/subscription-deduction-dialog.component';
import { SubscriptionHistoryDialogComponent } from './employee-details/subscription/subscription-history-dialog/subscription-history-dialog.component';
import { EmployeeBankComponent } from './employee-details/employee-bank/employee-bank.component';
import { AddEmployeeBankDialogComponent } from './employee-details/employee-bank/add-employee-bank-dialog/add-employee-bank-dialog.component';
import { EmployeePartTimeDialogComponent } from './employee-details/balance/employee-part-time-dialog/employee-part-time-dialog.component';
import { EmployeePartTimeComponent } from './employee-details/balance/employee-part-time/employee-part-time.component';
import { BalanceElementDetailsDialogComponent } from './employee-details/balance/balance-element-details-dialog/balance-element-details-dialog.component';
import { AddEmployeeElementDialogComponent } from './employee-details/balance/balance-element-details-dialog/add-employee-element-dialog/add-employee-element-dialog.component';



@NgModule({
  declarations: [
    EmployeeComponent,
    EmployeeListComponent,
    TestTableComponent,
    EmployeeDetailsComponent,
    BalanceComponent,
    BalanceHistoryDialogComponent,
    PayDeductionDialogComponent,
    SubscriptionComponent,
    SubscriptionDeductionDialogComponent,
    SubscriptionHistoryDialogComponent,
    EmployeeBankComponent,
    AddEmployeeBankDialogComponent,
    EmployeePartTimeDialogComponent,
    EmployeePartTimeComponent,
    BalanceElementDetailsDialogComponent,
    AddEmployeeElementDialogComponent,
  ],
  imports: [
    CommonModule,
    EmployeeRoutingModule,
    SharedModule,

  ]
})
export class EmployeeModule { }
