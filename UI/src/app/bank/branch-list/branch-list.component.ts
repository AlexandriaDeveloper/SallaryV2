import { AddBranchDialogComponent } from './add-branch-dialog/add-branch-dialog.component';
import { BankBranchesService } from './../../shared/services/bank-branches.service';
import { ActivatedRoute } from '@angular/router';
import { Component, OnInit, AfterViewInit } from '@angular/core';
import { BankBranch } from 'src/app/shared/models/employee/employee';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-branch-list',
  templateUrl: './branch-list.component.html',
  styleUrls: ['./branch-list.component.scss']
})
export class BranchListComponent implements OnInit ,AfterViewInit {
  bankId :number;
  data :BankBranch[];
  ngOnInit(): void {
   // throw new Error('Method not implemented.');
   this.bankId= this.activatedRoute.snapshot.params['id']
   console.log(this.bankId);

  }


  constructor(private brancheService :BankBranchesService ,private matDialog : MatDialog,private activatedRoute :ActivatedRoute) {


  }
  ngAfterViewInit(): void {
    this.loadData();
  }

  loadData(){
    this.brancheService.getAllBranchesByBankId(this.bankId).subscribe((x:BankBranch[]) => this.data=x);
  }
  openAddBankDialog(){
    const dialogRef = this.matDialog.open(AddBranchDialogComponent,{
      data:{state:'add', model : {id :0,bankId:this.bankId}},
      width:'300px',
      disableClose :true
    })
    dialogRef.afterClosed().subscribe(result => {
     this.loadData();
    });
  }
  openEditBankDialog(row){
    const dialogRef = this.matDialog.open(AddBranchDialogComponent,{
      data:{state:'edit', model : row},
      width:'300px',
      disableClose :true
    })
    dialogRef.afterClosed().subscribe(result => {
     this.loadData();
    });
  }
  deleteBankBranch(row){
    if(confirm(`انت على وشك حذف فرع البنك  ${row.name} هل انت متأكد ؟؟؟!`)){
      this.brancheService.deleteBankBranch(row.id).subscribe(x => this.loadData());
    }
  }
}
