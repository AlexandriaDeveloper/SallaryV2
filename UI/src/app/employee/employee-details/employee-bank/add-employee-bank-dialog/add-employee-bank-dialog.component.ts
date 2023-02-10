import { BankBranch, PostEmployeeBank } from './../../../../shared/models/employee/employee';
import { BankBranchesService } from './../../../../shared/services/bank-branches.service';
import { Component, AfterViewInit, OnInit, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Bank, EmployeeBankAccount } from 'src/app/shared/models/employee/employee';
import { BankService } from 'src/app/shared/services/bank.service';
import { EmployeeBankAccountService } from 'src/app/shared/services/employee-bank-account.service';
import { MatSelectChange } from '@angular/material/select';

@Component({
  selector: 'app-add-employee-bank-dialog',
  templateUrl: './add-employee-bank-dialog.component.html',
  styleUrls: ['./add-employee-bank-dialog.component.scss']
})
export class AddEmployeeBankDialogComponent implements AfterViewInit ,OnInit {
  bankForm:FormGroup;
  model : EmployeeBankAccount= new EmployeeBankAccount();

  banks : Bank[];
  bankBranches :BankBranch[];
  PostEmployeeBank=new PostEmployeeBank()
selectedBranch:number
  constructor (public dialogRef: MatDialogRef<AddEmployeeBankDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,
    private employeeBankAccountService :EmployeeBankAccountService,
    private bankService :BankService,
    private branchSevice :BankBranchesService
  ){}
  ngOnInit(): void {
    this.PostEmployeeBank.employeeId=this.data.employeeId;
console
.log(this.data)
    this.bankService.getAllBanks().subscribe((x:Bank[]) => this.banks=x)
    this.bankForm=this.IntilizeBankForm();
  }
  ngAfterViewInit(): void {


  }


  IntilizeBankForm(){

      return this.fb.group({
        employeeId:[this.PostEmployeeBank.employeeId,Validators.required],
        branchId:[this.PostEmployeeBank.branchId,Validators.required],
        accountNumber:[this.PostEmployeeBank.accountNumber,Validators.required]
      });
    }
  onNoClick(): void {
    this.dialogRef.close();
  }

  bankSelectChange(ev :MatSelectChange){
    this.PostEmployeeBank.branchId=null;
    this.branchSevice.getAllBranchesByBankId(ev.value).subscribe((x:BankBranch[]) => this.bankBranches=x );

  }
  branchSelectChange(ev :MatSelectChange){

   this.bankForm.get('branchId').setValue(ev.value)

   }
  onSubmit(){


     Object.assign(this.PostEmployeeBank,this.bankForm.value);
     console.log(this.PostEmployeeBank);
    this.employeeBankAccountService.postEmployeeBankAccount(this.PostEmployeeBank).subscribe(x => {

    this.dialogRef.close(x);
      //this.onNoClick()

    });
  }
}
