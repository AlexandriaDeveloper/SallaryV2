import { OrdersDetails2Component } from './orders-details/orders-details.component';
import { OrderFileComponent } from './order-file/order-file.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import * as path from 'path';

const routes: Routes = [
{path:'',component:OrderFileComponent},
{path:'orders-details/:id',component:OrdersDetails2Component}

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OrdersRoutingModule { }
