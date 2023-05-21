import { SubscriptionHistoryDialogComponent } from './subscription-history-dialog/subscription-history-dialog.component';
import { MatDialog } from '@angular/material/dialog';
import { SubscriptionDeductionDialogComponent } from './subscription-deduction-dialog/subscription-deduction-dialog.component';
import { EmployeeSubsriptionParam } from 'src/app/shared/models/param';
import { EmployeeSubsriptionService } from 'src/app/shared/services/employee-subsription.service';
import { ActivatedRoute } from '@angular/router';
import { Component, AfterViewInit, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-subscription',
  templateUrl: './subscription.component.html',
  styleUrls: ['./subscription.component.scss']
})
export class SubscriptionComponent implements OnInit, AfterViewInit {
 @Input('employeeId') employeeId ;
@Input('formEmployeeId') formEmployeeId ;
// @Input('formId') formId ;
@Input('editable') editable =false ;
param : EmployeeSubsriptionParam = new EmployeeSubsriptionParam();
data:any;
@Output('notification') notification :EventEmitter<boolean>= new EventEmitter<boolean>();
constructor(private dialog:MatDialog, private router : ActivatedRoute , private  employeeSubsriptionService:EmployeeSubsriptionService ) {


}
  ngOnInit(): void {
   // throw new Error('Method not implemented.');
  }
  ngAfterViewInit(): void {
this.loadData();



  }

  loadData(){

    this.employeeSubsriptionService.getEmployeeSubscriptionByEmployeeId(this.employeeId).subscribe(x => {
      this.data=x;
    let net =this.data.reduce( (c,v) => c +=v.net,0);

    if(net !==0){
      this.notification.emit(false)
    }
    else{
      this.notification.emit(true);
    }
    }) ;

  }

  openSubscriptionDeductionDialog(subscriptionId): void {

    const dialogRef = this.dialog.open(SubscriptionDeductionDialogComponent, {
      data: { employeeId: this.employeeId ,subscriptionId:subscriptionId,formEmployeeId :this.formEmployeeId},
     minWidth:'400px',
     minHeight:'300px',
     maxHeight:'900px',
     hasBackdrop:true
    });

    dialogRef.afterClosed().subscribe(result => {
      this.loadData();
    //  this.animal = result;
    //this.loadDeduction();
    });
  }


  openSubscriptioHistoryDialog(subscriptionId): void {

        const dialogRef = this.dialog.open(SubscriptionHistoryDialogComponent, {
          data: { employeeId: this.employeeId ,subscriptionId:subscriptionId},
         minWidth:'1200px',
         minHeight:'300px',
         maxHeight:'900px',
         hasBackdrop:true
        });

        dialogRef.afterClosed().subscribe(result => {

          this.loadData();
        //  this.animal = result;
        //this.loadDeduction();
        });
      }
}
