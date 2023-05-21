import { AddFormDialogComponent } from './add-form-dialog/add-form-dialog.component';
import { FormService } from './../../shared/services/form.service';
import { FormListParam } from './../../shared/models/param';
import { FormListDataSource } from './form-list-datasource';
import { Component, AfterViewInit, ViewChild, OnInit } from '@angular/core';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { Form } from 'src/app/shared/models/employee/employee';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-form-list',
  templateUrl: './form-list.component.html',
  styleUrls: ['./form-list.component.scss']
})
export class FormListComponent implements AfterViewInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<Form>;

  dataSource: FormListDataSource;
  formParam = new FormListParam();
  displayedColumns=['action','fileNumber55','details','formDate']

  /**
   *
   */
  constructor(private formService : FormService,public dialog: MatDialog,) {
  }

  ngAfterViewInit(): void {


    this.formParam.isPagination=true;

    this.dataSource = new FormListDataSource(this.formService,this.formParam, this.paginator);
    this.dataSource.data.subscribe();
    this.table.dataSource= this.dataSource;


     this.paginator=this.dataSource.paginator;

  }
  handlePageEvent(event: PageEvent) {
   this.dataSource.formListParam.pageIndex=event.pageIndex;
   this.table.dataSource = this.dataSource.connect();
  }

  searchBox(ev) {
    ev.elementValue.subscribe(x => {
      this.formParam = Object.assign(this.formParam,x.Param);
      this.table.dataSource=this.dataSource.connect()})

  }

  sortData(ev){
    this.formParam=ev;
    this.table.dataSource=this.dataSource.connect()
  }
  clearSerach(ev){
    this.formParam=ev;
    this.table.dataSource=this.dataSource.connect()
  }
  openDialog(){
    const dialogRef = this.dialog.open(AddFormDialogComponent, {
      width:'600px',
      disableClose:true
     // data: {name: this.name, animal: this.animal},

    });

    dialogRef.afterClosed().subscribe(result => {
      this.table.dataSource = this.dataSource.connect();
     // this.animal = result;
    });
  }
  deleteForm(row){
if(confirm(`انت على وشك حذف ملف ${row.details} نهائيا هل انت متأكد ؟؟؟؟!`))
{
  this.formService.deleteForm(row.id).subscribe(x =>
    {
      this.table.dataSource=this.dataSource.connect()
    });

}
  }

}
