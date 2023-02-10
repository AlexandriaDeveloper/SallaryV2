import { AddOrderFileDialogComponent } from './add-order-file-dialog/add-order-file-dialog.component';
import { OrderFile } from './../../shared/models/employee/employee';
import { OrderFileDataSource } from './order-file-dataSource';
import { OrderFileParam } from './../../shared/models/param';
import { Component, AfterViewInit, ViewChild } from '@angular/core';
import { OrderFileService } from 'src/app/shared/services/order-file.service';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-order-file',
  templateUrl: './order-file.component.html',
  styleUrls: ['./order-file.component.scss']
})
export class OrderFileComponent  implements AfterViewInit{
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<OrderFile>;
  dataSource: OrderFileDataSource;
  orderFileParam :OrderFileParam= new OrderFileParam();

  displayedColumns = ['action', 'details','createdDate'];

constructor(private orderFileService:OrderFileService,  public dialog: MatDialog ) {


}
  ngAfterViewInit(): void {
    this.orderFileParam.isPagination=true;


    this.dataSource = new OrderFileDataSource(this.orderFileService,this.orderFileParam, this.paginator);
    this.table.dataSource = this.dataSource.connect();
    this.table.dataSource = this.dataSource;
    this.paginator=this.dataSource.paginator;
  }
  handlePageEvent(event: PageEvent){
    this.dataSource.orderParam.pageIndex=event.pageIndex;
    this.table.dataSource = this.dataSource.connect();
  }

  openDialog(orderId): void {
    const dialogRef = this.dialog.open(AddOrderFileDialogComponent, {
      data: {
        //employeeId: this.employeeOrderDeductions.employeeId, orderId: orderId
      },
     minWidth:'500px',
     height:'220px',
     hasBackdrop:false
    });

    dialogRef.afterClosed().subscribe(result => {
      this.table.dataSource = this.dataSource.connect();
    //  this.animal = result;
    });
  }
}
