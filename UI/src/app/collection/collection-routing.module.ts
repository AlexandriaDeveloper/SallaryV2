import { EmployeeCollectionListComponent } from './employee-collection-list/employee-collection-list.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CollectionListComponent } from './collection-list/collection-list.component';

const routes: Routes = [{
  path:'',component:CollectionListComponent,

},{
  path:'employee-collection-list/:id',component:EmployeeCollectionListComponent
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CollectionRoutingModule { }
