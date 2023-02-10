import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SubscriptionRoutingModule } from './subscription-routing.module';
import { SubscriptionListComponent } from './subscription-list/subscription-list.component';
import { AddSubscriptionComponent } from './subscription-list/add-subscription/add-subscription.component';
import { EmployeeSubscriptionComponent } from './employee-subscription/employee-subscription.component';
import { AddEmployeeToSubscriptionComponent } from './employee-subscription/add-employee-to-subscription/add-employee-to-subscription.component';



@NgModule({
  declarations: [


    SubscriptionListComponent,
      AddSubscriptionComponent,
      EmployeeSubscriptionComponent,
      AddEmployeeToSubscriptionComponent
  ],
  imports: [
    CommonModule,
    SubscriptionRoutingModule,SharedModule
  ]
})
export class SubscriptionModule { }
