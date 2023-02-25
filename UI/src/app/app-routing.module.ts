import { OrdersModule } from './orders/orders.module';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [{ path: 'employee', loadChildren: () => import('./employee/employee.module').then(m => m.EmployeeModule) },
{ path: 'order', loadChildren: () => import('./orders/orders.module').then(m => m.OrdersModule) },
{ path: 'form', loadChildren: () => import('./form/form.module').then(m => m.FormModule) },
{ path: 'collection', loadChildren: () => import('./collection/collection.module').then(m => m.CollectionModule) },
{ path: 'subscription', loadChildren: () => import('./subscription/subscription.module').then(m => m.SubscriptionModule) },
{ path: 'bank', loadChildren: () => import('./bank/bank.module').then(m => m.BankModule) },
{ path: 'financial-data-type', loadChildren: () => import('./financial-data-type/financial-data-type.module').then(m => m.FinancialDataTypeModule) },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
