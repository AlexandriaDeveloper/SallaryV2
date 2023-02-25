import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FinancialDataTypeRoutingModule } from './financial-data-type-routing.module';
import { FinancialDataTypeComponent } from './financial-data-type.component';
import { AddFinancialDataTypeElementDialogComponent } from './add-financial-data-type-element/add-financial-data-type-element-dialog.component';


@NgModule({
  declarations: [
    FinancialDataTypeComponent,
    AddFinancialDataTypeElementDialogComponent
  ],
  imports: [
    CommonModule,
    FinancialDataTypeRoutingModule,
     SharedModule
  ]
})
export class FinancialDataTypeModule { }
