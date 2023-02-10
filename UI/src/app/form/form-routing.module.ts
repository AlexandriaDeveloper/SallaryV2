
import { UploadSusbcriptionFileComponent } from './employee-form-details/upload-susbcription-file/upload-susbcription-file.component';
import { PeriodicSubscriptionDataComponent } from './employee-form-details/periodic-subscription-data/periodic-subscription-data.component';
import { EmployeeFormDetailsComponent } from './employee-form-details/employee-form-details.component';
import { FormListComponent } from './form-list/form-list.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OrdersDetailsComponent } from './employee-form-details/orders-details/orders-details.component';

const routes: Routes = [
  {path:'' , component : FormListComponent},
  {path:'form-details/:id' , component : EmployeeFormDetailsComponent},
  {path:'form-details/periodic-subscription/:id' , component : PeriodicSubscriptionDataComponent},
  {path:'form-details/:id/uploadSubscription' , component : UploadSusbcriptionFileComponent},
  {path:'form-details/:id/employee-order-form' , component : OrdersDetailsComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FormRoutingModule { }
