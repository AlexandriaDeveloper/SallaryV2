import { AddBankDialogComponent } from './add-bank-dialog/add-bank-dialog.component';
import { MatDialog } from '@angular/material/dialog';
import { Bank } from './../../shared/models/employee/employee';
import { BankService } from './../../shared/services/bank.service';
import { Component, AfterViewInit } from '@angular/core';

@Component({
  selector: 'app-bank-list',
  templateUrl: './bank-list.component.html',
  styleUrls: ['./bank-list.component.scss']
})
export class BankListComponent implements AfterViewInit {

data :Bank[];
  constructor(private bankService :BankService ,private matDialog : MatDialog) {


  }
  ngAfterViewInit(): void {
    this.loadData();
  }

  loadData(){
    this.bankService.getAllBanks().subscribe((x:Bank[]) => this.data=x);
  }
  openAddBankDialog(){
    const dialogRef = this.matDialog.open(AddBankDialogComponent,{
      data:{state:'add', id :0},
      width:'300px',
      disableClose :true
    })
    dialogRef.afterClosed().subscribe(result => {
     this.loadData();
    });
  }
  openEditBankDialog(row){
    const dialogRef = this.matDialog.open(AddBankDialogComponent,{
      data:{state:'edit', bank : row},
      width:'300px',
      disableClose :true
    })
    dialogRef.afterClosed().subscribe(result => {
     this.loadData();
    });
  }
  deleteBank(row){
    if(confirm(`انت على وشك حذف بنك ${row.name} هل انت متأكد ؟؟؟!`)){
      this.bankService.deleteBank(row.id).subscribe(x => this.loadData());
    }
  }
}
