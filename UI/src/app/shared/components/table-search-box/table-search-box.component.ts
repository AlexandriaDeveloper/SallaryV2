import { animate, state, style, transition, trigger } from '@angular/animations';
import { AfterViewInit, Component, ElementRef, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { MatSort, Sort } from '@angular/material/sort';
import { Console } from 'console';
import { debounceTime, distinctUntilChanged, fromEvent, map, Observable } from 'rxjs';
import { Param } from '../../models/param';

@Component({
  selector: 'app-table-search-box',
  templateUrl: './table-search-box.component.html',
  styleUrls: ['./table-search-box.component.scss'],
  animations:[trigger('myAnimation',[
  transition( 'void <=> *',[
    style({opacity:0}),
    animate('1s')])
])]
})
export class TableSearchBoxComponent implements OnInit, AfterViewInit {
  @ViewChild('element') element: ElementRef;
  @Output('searchEvent') SearchEvent: EventEmitter<any> = new EventEmitter<any>();
  @Output('sortEvent') SortEvent: EventEmitter<any> = new EventEmitter<any>();
  @Output('clearEvent') CloseEvent: EventEmitter<Param> = new EventEmitter<any>();
  @Input('placeHolder') placeHolder;
  @Input('elementName') elementName: string = '';
  @Input('label') label: string;
  @Input('param') Param:Param;
  @Input('sort') Sort: boolean;
  @ViewChild(MatSort) sort!: MatSort;
  closeIcon:boolean=false;
  ngAfterViewInit(): void {

    var element$ = fromEvent(this.element.nativeElement, 'keyup')
      .pipe(debounceTime(600), distinctUntilChanged(), map((x: any) => {

        let val =x?.srcElement?.value ;
        if(val!=='')
        this.closeIcon=true;
        else
        this.closeIcon=false;
        if(!Object.hasOwn( this.Param,'pageIndex')){
          Object.defineProperty(this.Param, 'pageIndex', { value:0 });
        }
        else{
          this.Param['pageIndex']=0;
        }
        if(!Object.hasOwn( this.Param,this.elementName)){
            this.Param= Object.defineProperty(this.Param, this.elementName, { value: val });
        }
        else{
          this.Param[this.elementName]=val
        }


        return this.Param;
      })
      );
    const val = { elementId: this.elementName, param: this.Param, elementValue: element$ };


    this.SearchEvent.emit(val);
  }


  //elementObservable: Observable<any>;
  ngOnInit(): void {

  }
  clear() {
    if(!Object.hasOwn( this.Param,'pageIndex')){
      Object.defineProperty(this.Param, 'pageIndex', { value: 0 });
    }
    else{
      this.Param['pageIndex']=0;
    }
    if(!Object.hasOwn( this.Param,this.elementName)){
        this.Param= Object.defineProperty(this.Param, this.elementName, { value: null });
    }
    else{
      this.Param[this.elementName]=null;
    }

    this.element.nativeElement.value = '';
    this.CloseEvent.emit(this.Param);

    this.closeIcon=false;
  }
sortChanges(ev :Sort){
  if(!Object.hasOwn( this.Param,'pageIndex')){
    Object.defineProperty(this.Param, 'pageIndex', { value: 0 });
  }
  else{
    this.Param['pageIndex']=0;
  }
  if(!Object.hasOwn( this.Param,'sort')){
    Object.defineProperty(this.Param, 'sort', { value: ev.direction });
  }
  else{
    this.Param['sort']=ev.direction;
  }

  if(!Object.hasOwn( this.Param,'sortBy')){
    Object.defineProperty(this.Param, 'sortBy', { value: ev.active });
  }
  else{
    this.Param['sortBy']=ev.active;
  }

  this.SortEvent.emit(this.Param);
}



}
