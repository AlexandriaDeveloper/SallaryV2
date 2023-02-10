export class Param {
  pageSize: number=15 ;
  pageIndex: number=0;
  length:number;
  isPagination: boolean = true;
  sort:string=null;
  sortBy:string=null;
  totalCount:number=0;

}

export class EmployeeParam extends Param{
  name?:string=null;
  nationalId?:string=null;
  tabCode?:string=null;
  tegaraCode?:string=null;
  section?:string=null;
  collage? :string=null;

  employeeHasBank:boolean=null;
}
export class OrderFileParam extends Param{

}
export class OrderFileDetailsParam extends Param{

  tabCode?:string=null;
  tegaraCode?:string=null;
  formId?:number;
  employeeName?:string=null;
  orderName?:string=null;
  details?:string=null;
  startFrom?:Date=null;
  endAt?:Date=null
  amount? :number;

}
export class employeeCollectionListParam extends Param{
  collectionId:number;
}

export class FormListParam extends Param{
  details : string=null;
  fromDate:string=null;
  fileNumber55:string=null;
  fileNumber224:string=null;
}
export class EmployeeFormParam extends Param{
  formId?:number=null;
  employeeName?:string=null;
  employeeNationalId?:string=null;
  employeeTabCode?:string=null;
  employeeTegaraCode?:string=null;
  employeeSection?:string=null;
  employeeCollageName? :string=null;
}
export class EmployeeSubsriptionParam extends Param{
  subsriptionId?:number=null;
  employeeId?:number=null;
  employeeName?:string=null;
  employeeNationalId?:string=null;
  employeeTabCode?:string=null;
  employeeTegaraCode?:string=null;
  employeeSection?:string=null;
  employeeCollageName? :string=null;
  amount? :number=null;
  isActive? : boolean =null
}