import { AddEmployeeBankDialogComponent } from './add-employee-bank-dialog/add-employee-bank-dialog.component';
import { EmployeeBankAccount } from './../../../shared/models/employee/employee';
import { EmployeeBankAccountService } from './../../../shared/services/employee-bank-account.service';
import { Component, Input, AfterViewInit, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-employee-bank',
  templateUrl: './employee-bank.component.html',
  styleUrls: ['./employee-bank.component.scss']
})
export class EmployeeBankComponent implements AfterViewInit, OnInit {
  @Input('employee') employee;
  employeeBankAccount: EmployeeBankAccount;
  constructor(private employeeBankAccountService : EmployeeBankAccountService,  public dialog: MatDialog){}
  ngOnInit(): void {
    if(this.employee.employeeHasBank)
          this.loadEmployeeBank();
  }


  loadEmployeeBank(){

    this.employeeBankAccountService
    .getEmployeeBankAccount(this.employee.employeeBankId)
    .subscribe((x:EmployeeBankAccount) => this.employeeBankAccount=x )

  }
ngAfterViewInit(): void {


  //throw new Error('Method not implemented.');
}

openAddBankAccountDialog(){

  const dialogRef = this.dialog.open(AddEmployeeBankDialogComponent, {
    data: {employeeId: this.employee.id},
   minWidth:'600px',


   hasBackdrop:true
  });

  dialogRef.afterClosed().subscribe(result => {
    console.log(result);
    this.employee.employeeBankId=result;
  this.loadEmployeeBank();
  this.employee.employeeHasBank=true;
  });

}
removeAccount(){
 if(confirm("انت على وشك حذف حساب البنكى للموظف هل انت متأكد ؟؟!"))
   this.employeeBankAccountService.deleteEmployeeBankAccount(this.employee.id).subscribe(x=>{

    this.employeeBankAccount=null;
    this.employee.employeeHasBank=false;

   });

}
}
