import { BranchListComponent } from './branch-list/branch-list.component';
import { BankListComponent } from './bank-list/bank-list.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


const routes: Routes = [
  { path: '', component: BankListComponent },
  { path: 'branch-list/:id', component: BranchListComponent },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BankRoutingModule { }
