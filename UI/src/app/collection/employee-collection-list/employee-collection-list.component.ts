
import { EmployeeCollectionService } from './../../shared/services/employee-collection.service';
import { EmployeeCollectionListDataSource } from './employee-collection-list-dataSource';
import { ActivatedRoute } from '@angular/router';
import { AddEmployeToCollictionDialogComponent } from './add-employe-to-colliction-dialog/add-employe-to-colliction-dialog.component';
import { Component, AfterViewInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { employeeCollection } from 'src/app/shared/models/employee/employee';
import { employeeCollectionListParam } from 'src/app/shared/models/param';
import { MatTable } from '@angular/material/table';
import { CdkDragDrop, moveItemInArray } from '@angular/cdk/drag-drop';
import { map } from 'rxjs';
import { throws } from 'assert';

@Component({
  selector: 'app-employee-collection-list',
  templateUrl: './employee-collection-list.component.html',
  styleUrls: ['./employee-collection-list.component.scss']
})
export class EmployeeCollectionListComponent implements AfterViewInit {
  collectionId
 // dataSource: EmployeeCollectionListDataSource;
  @ViewChild(MatTable) table!: MatTable<employeeCollection>;
  displayedColumns = ['action','num','employeeTabCode','employeeTegaraCode','employeeName','employeeSection','employeeCollageName'];
   employeeCollectionParam :employeeCollectionListParam= new employeeCollectionListParam();
   data : employeeCollection[]=[]
  constructor(public dialog: MatDialog,private router : ActivatedRoute
   , private employeeCollectionService : EmployeeCollectionService
    ){}
  ngAfterViewInit(): void {

   this.collectionId=this.router.snapshot.params['id']
   this.employeeCollectionParam.collectionId=this.collectionId;

    this.loadEmployeeCollection();

  // this.dataSource = new EmployeeCollectionListDataSource(this.employeeCollectionService, this.employeeCollectionParam);
  // this.table.dataSource= this.dataSource.connect();

  }
  loadEmployeeCollection(){

     this.employeeCollectionService.getEmployeeCollection( this.employeeCollectionParam).pipe(map((x:any) => {

    this.data=x;
     })).subscribe();

  }
  openDialog(){

    const dialogRef = this.dialog.open(AddEmployeToCollictionDialogComponent, {
     data: {collectionId: this.collectionId},
      width:'500px',
      disableClose:true,
      hasBackdrop:true

     });

     dialogRef.afterClosed().subscribe(result => {
      this.loadEmployeeCollection();
      // this.table.dataSource = this.dataSource.connect();
      // this.animal = result;
     });
  }
  drop(ev : CdkDragDrop<employeeCollection[]>) {

        // this.dataSource.data.subscribe(x =>{

        moveItemInArray(this.data,ev.previousIndex,ev.currentIndex);
        var ids = this.data.map(x => x.id);
      this.reorderData();

  }

  reorderData(){
    var ids = this.data.map(x => x.id);
      this.employeeCollectionService.updateEmployeeCollectionRow(ids).subscribe((x)=>{
         this.table.renderRows();});

  }
  deleteEmployee(id){
   if( confirm("انت على وشك حذف موظف هل انت متأكد ؟!!!"))
{    this.employeeCollectionService.deleteEmployeeFromCollection(id).subscribe(x =>{
  this.reorderData();
  this.loadEmployeeCollection()

});}
  }
}
