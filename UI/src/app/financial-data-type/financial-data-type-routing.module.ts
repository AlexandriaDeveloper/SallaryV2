import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FinancialDataTypeComponent } from './financial-data-type.component';

const routes: Routes = [{ path: '', component: FinancialDataTypeComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FinancialDataTypeRoutingModule { }
