import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BankRoutingModule } from './bank-routing.module';
import { BankListComponent } from './bank-list/bank-list.component';
import { AddBankDialogComponent } from './bank-list/add-bank-dialog/add-bank-dialog.component';
import { BranchListComponent } from './branch-list/branch-list.component';
import { AddBranchDialogComponent } from './branch-list/add-branch-dialog/add-branch-dialog.component';



@NgModule({
  declarations: [
   
  
    BankListComponent,
           AddBankDialogComponent,
           BranchListComponent,
           AddBranchDialogComponent
  ],
  imports: [
    CommonModule,
    BankRoutingModule,
    SharedModule,
  ]
})
export class BankModule { }
