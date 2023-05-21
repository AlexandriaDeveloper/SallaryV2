

import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FormRoutingModule } from './form-routing.module';
import { FormListComponent } from './form-list/form-list.component';
import { AddFormDialogComponent } from './form-list/add-form-dialog/add-form-dialog.component';
import { EmployeeFormDetailsComponent } from './employee-form-details/employee-form-details.component';

import { AddEmployeeFormCollectionDialogComponent } from './employee-form-details/add-employee-form-collection-dialog/add-employee-form-collection-dialog.component';
import { AddEmployeeToFormComponent } from './employee-form-details/add-employee-to-form/add-employee-to-form.component';

import { AddFormSubscriptionDialogComponent } from './employee-form-details/add-form-subscription-dialog/add-form-subscription-dialog.component';
import { PeriodicSubscriptionDataComponent } from './employee-form-details/periodic-subscription-data/periodic-subscription-data.component';
import { UpdatePeriodicSubscriptionDataDialogComponent } from './employee-form-details/periodic-subscription-data/update-periodic-subscription-data-dialog/update-periodic-subscription-data-dialog.component';
import { AddEmployeePeriodicFormDialogComponent } from './employee-form-details/periodic-subscription-data/add-employee-periodic-form-dialog/add-employee-periodic-form-dialog.component';
import { UploadSusbcriptionFileComponent } from './employee-form-details/upload-susbcription-file/upload-susbcription-file.component';
import { OrdersDetailsComponent } from './employee-form-details/orders-details/orders-details.component';
import { NewEmployeeOrderDialogComponent } from './employee-form-details/orders-details/new-employee-order-dialog/new-employee-order-dialog.component';
import { EmployeeVacationDialogComponent } from './employee-form-details/orders-details/employee-vacation-dialog/employee-vacation-dialog.component';
import { FormEmployeeOrderDetailsComponent } from './employee-form-details/orders-details/form-employee-order-details/form-employee-order-details.component';
import { FormEmployeeVacationDetailsComponent } from './employee-form-details/orders-details/form-employee-vacation-details/form-employee-vacation-details.component';



@NgModule({
  declarations: [
    FormListComponent,
    AddFormDialogComponent,
    EmployeeFormDetailsComponent,
    NewEmployeeOrderDialogComponent,
    OrdersDetailsComponent,
    AddEmployeeFormCollectionDialogComponent,
     AddEmployeeToFormComponent,
     AddFormSubscriptionDialogComponent,
     PeriodicSubscriptionDataComponent,
     UpdatePeriodicSubscriptionDataDialogComponent,
     AddEmployeePeriodicFormDialogComponent,
     UploadSusbcriptionFileComponent,
     EmployeeVacationDialogComponent,
     FormEmployeeOrderDetailsComponent,
     FormEmployeeVacationDetailsComponent,



  ],
  imports: [
    CommonModule,
    FormRoutingModule,
    SharedModule
  ]
})
export class FormModule { }
