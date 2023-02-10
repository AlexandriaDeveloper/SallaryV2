import { AddEmployeePeriodicFormDialogComponent } from './add-employee-periodic-form-dialog/add-employee-periodic-form-dialog.component';
import { AddEmployeeFormCollectionDialogComponent } from './../add-employee-form-collection-dialog/add-employee-form-collection-dialog.component';
import { UpdatePeriodicSubscriptionDataDialogComponent } from './update-periodic-subscription-data-dialog/update-periodic-subscription-data-dialog.component';
import { PeriodicSubscriptionService } from './../../../shared/services/periodic-subscription.service';
import { EmployeeFormService } from './../../../shared/services/employee-form.service';
import { ActivatedRoute } from '@angular/router';
import { Component, OnInit, AfterViewInit, ViewChild, ElementRef } from '@angular/core';
import { CheckedSucription, PerioicSubscriptionByForm } from 'src/app/shared/models/employee/employee';
import { MatTabChangeEvent } from '@angular/material/tabs';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-periodic-subscription-data',
  templateUrl: './periodic-subscription-data.component.html',
  styleUrls: ['./periodic-subscription-data.component.scss']
})
export class PeriodicSubscriptionDataComponent  implements OnInit,AfterViewInit{
formId:number;
modelToUpdate;
tabs:CheckedSucription[];
perioicSubscriptionByForm:PerioicSubscriptionByForm= new PerioicSubscriptionByForm();
  constructor(private activatedRoute : ActivatedRoute,
    private employeeFormService : EmployeeFormService,
    private periodicSubscriptionService : PeriodicSubscriptionService,
    public dialog: MatDialog) {


  }
  ngAfterViewInit(): void {



  }
  ngOnInit(): void {
    this.formId=this.activatedRoute.snapshot.params['id'];

this.loadData();

   // throw new Error('Method not implemented.');
  }

  loadData(){

    this.employeeFormService.getCheckedSubscription(this.formId).subscribe((x:CheckedSucription[]) =>{
      this.tabs=x.filter(t => t.checked)

    })
  }
  onChange(ev :MatTabChangeEvent ){

    let id =this.tabs[ev.index].subscriptionId;
    this.periodicSubscriptionService
    .getPeriodicSubscriptionByFormId(this.formId, id)
    .subscribe((x:PerioicSubscriptionByForm) =>{ this.perioicSubscriptionByForm=x;console.log(x)})

  }

  openDialog(id){
    this.periodicSubscriptionService.getPeriodicSubscriptionById(id).subscribe(x => {

    const dialogRef = this.dialog.open(UpdatePeriodicSubscriptionDataDialogComponent, {
      data: {model : x},
      // minWidth:'600px',
      // height:"300px",
      disableClose:true,
      hasBackdrop:true,
      panelClass:['dialogCss']
     });

     dialogRef.afterClosed().subscribe(result => {
 this.loadData();
      // this.animal = result;
     });
    })
  }

  AddEmployeeDialog(){
  // this.periodicSubscriptionService.getPeriodicSubscriptionById(id).subscribe(x => {
    console.log(this.formId);

    const dialogRef = this.dialog.open(AddEmployeePeriodicFormDialogComponent, {
      data: {formId:this.formId},
       width:'600px',
      // height:"300px",
      disableClose:true,
      hasBackdrop:true,
      panelClass:['dialogCss']
     });

      dialogRef.afterClosed().subscribe(result => {
   this.loadData();

    });

  }
  deletePeriodicSubscription(row){
   if( confirm(`انت على وشك حذف اشتراك  الموظف ${row.employeeName} هل انت متأكذ ؟؟؟!!`))
    this.periodicSubscriptionService.deletePeriodicSubscriptionById(row.id).subscribe(x =>{

      this.loadData();
    });
  }
}
