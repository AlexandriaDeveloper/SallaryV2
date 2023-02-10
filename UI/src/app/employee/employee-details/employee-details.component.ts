import { combineLatest, concat, concatAll, forkJoin, merge, switchAll, switchMap, zip, map, flatMap } from 'rxjs';
import { IEmployee, IEmployeeBasicSallary } from './../../shared/models/employee/employee';
import { EmployeeService } from 'src/app/shared/services/employee.service';
import { Component, OnInit, AfterViewInit } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeBasicSallaryService } from 'src/app/shared/services/employee-basic-sallary.service';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.scss']
})
export class EmployeeDetailsComponent implements OnInit,AfterViewInit{
employee :IEmployee;
formId=null;
employeeBasicSallary:IEmployeeBasicSallary;
editable =false;
id:number;
subscriptionNotification:boolean=false;
notification : boolean=false;
constructor(
  private activatedRoute :ActivatedRoute,
  private router:Router,
  private employeeService : EmployeeService,
  public dialog: MatDialog
   ) {
  this.router.routeReuseStrategy.shouldReuseRoute = () => false;
}
  ngAfterViewInit(): void {

if(this.formId ===null){

  this.employeeService.getEmployee(this.id).subscribe((x:IEmployee) => this.employee=x);
}
 else{
  this.employeeService.getEmployeeInForm(this.id,this.formId)
  .subscribe((x:IEmployee) => {
    this.employee=x;
    console.log(this.employee);
  });
 }


  }
  ngOnInit(): void {
    this.id =this.activatedRoute.snapshot.params['id'];
    this.activatedRoute.queryParams.subscribe((x:any) => {
      this.formId=x.formId;
      if(x.formId !==undefined)
      this.editable=true

    });
  }
  NextClick() {

    this.router.routeReuseStrategy.shouldReuseRoute = function () {
        return false;
    }
    this.router.onSameUrlNavigation = 'reload';
    this.router.navigate(['./employee/details/'+this.employee.next],{queryParams:{formId:this.formId}});
}
PreviousClick() {
  this.router.routeReuseStrategy.shouldReuseRoute = function () {
      return false;
  }
  this.router.onSameUrlNavigation = 'reload';
  this.router.navigate(['./employee/details/'+this.employee.previous],{queryParams:{formId:this.formId}});
}
getNotify(ev)
{
this.notification=ev;

}


}
