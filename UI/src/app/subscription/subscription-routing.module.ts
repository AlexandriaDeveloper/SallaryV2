import { EmployeeSubscriptionComponent } from './employee-subscription/employee-subscription.component';
import { SubscriptionListComponent } from './subscription-list/subscription-list.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


const routes: Routes = [{ path: '', component: SubscriptionListComponent },

{ path: 'employee-subsription/:id', component: EmployeeSubscriptionComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SubscriptionRoutingModule { }
