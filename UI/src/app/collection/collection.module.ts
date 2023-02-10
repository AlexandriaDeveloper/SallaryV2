import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CollectionRoutingModule } from './collection-routing.module';
import { CollectionListComponent } from './collection-list/collection-list.component';

import { AddCollectionDialogComponent } from './collection-list/add-collection-dialog/add-collection-dialog.component';
import { EmployeeCollectionListComponent } from './employee-collection-list/employee-collection-list.component';
import { AddEmployeToCollictionDialogComponent } from './employee-collection-list/add-employe-to-colliction-dialog/add-employe-to-colliction-dialog.component';


@NgModule({
  declarations: [
    CollectionListComponent,
    AddCollectionDialogComponent,
    EmployeeCollectionListComponent,
    AddEmployeToCollictionDialogComponent
  ],
  imports: [
    CommonModule,
    CollectionRoutingModule,
    SharedModule
  ]
})
export class CollectionModule { }
