
export interface IEmployee{
id:number,
name:string,
tabCode:string,
tegaraCode:string,
nationalId: string,
employeeHasBank:boolean,
employeeInPartTime ?:boolean;
section :string,
collage:string,
grade:string,
next?:number
previous?:number

}
export interface IEmployeeBasicSallary{

  id:number,
  basicSallary:number,
  wazifi:number,
  mokamel:number,
  taawidi:number
}
export interface IEmployeeTotalOrdersAndDeductions{

  "employeeId": number,
  "employeeOrdersDtos":IEmployeeTotalOrdersAndDeductionsDetails []


}
export interface IEmployeeTotalOrdersAndDeductionsDetails{
  "orderId": number,
  "orderName": string,
  "orderDeductionName": string,
  "orderTotal": number,
  "deductionTotal": number,
  "net": number
}
export class OrderFile{

  id?:number=0;
  details:string='';
  createdDate:Date =null;
}
export class DeductionOrder{
  id?:number;
  details: string='';
  orderId:number= 0;
  // employeeId:number= 0;
  // formId:number= 0;
  formEmployeeId=0;
  amount:number= 0;
  creditOrDepit:string='c'
}

export class EmployeeOrder{
      employeeId:number=0;
      details:string='';
      orderNumber:string='';
      formEmployeeId?:number=0;
      quantity?:number;
      creditOrDebit:string='d';
      amount? :number;
      orderId:number=0;
     // employeeOrderType:EmployeeOrderType= new EmployeeOrderType()
}
// export class EmployeeOrderType{
//   formId:number;
//   quantity?:number;
//   creditOrDebit:string='d';
//   amount? :number;
//   orderId:number=0;
// }
export class EmployeeVacation{
  formEmployeeId:number;

  vacationId:number=0;
  details:string='';
  orderNumber:string='';
  quantity:number=0;
  creditOrDebit:string='d';
  startAt?:Date= null;
  endAt?:Date=null;

}
export class FinancialYear{
  id? :number;
  name :string

}
export class Collection{
  id? :number;
  name :string

}
export class Sucription{
  id? :number;
  name :string

}
export class CheckedSucription{
  subscriptionId? :number;
  subscriptionName :string;
  checked:boolean;

}
export class employeeCollection{

  id?: number;
  employeeId: number;
  employeeTabCode:string;
  employeeTegaraCode:string;
  employeeName: string;
  employeeSection:string;
  employeeCollageName: string;
  employeeOrderInCollection: number;
}
export class Form{
  id? :number;
  details : string;
  formDate:string;
  fileNumber55:string;
  fileNumber224:string;
}
export class EmployeeForm{

  id?: number;
  employeeId: number;
  employeeTabCode:string;
  employeeTegaraCode:string;
  employeeName: string;
  employeeSection:string;
  employeeCollageName: string;
  employeeOrderInCollection: number;
}

export class EmployeeSubscription{

  id?: number;
  employeeId: number;
  subscriptionId: number;
  amount :number;
  isActive:boolean;
  employeeTabCode:string;
  employeeTegaraCode:string;
  employeeName: string;
  employeeSection:string;

}
export class AddEmployeeSubscription{
  id?: number;
  employeeId: number;
  details:string;
  subscriptionId: number;
  amount :number;
  isActive:boolean =true;
}
export class PeriodicSubscription{
  id?:number;
  subscriptionId:number;
  employeeId:number;
  formId:number;
  amount:number

}

export class PeriodicSubscriptionHistory{
  formId?:number;
  formName:string;
  creditOrDebit:[{
    id:number,
    credit : number,
    debit:number

  }]
net:number

}
export class EmployeeBankAccount {
  id?:number;
  bankName : string;
  branchName : string ;
  accountNumber : string;


}

export class PostEmployeeBank {
  id? : number;
  employeeId:number=null;
  branchId:number=null;
  accountNumber:string=null

}
export class Bank{
  id?:number;
  name :string
}
export class BankBranch{
  id?:number;
  name :string;
  bankId:number;
}

export class EmployeePartTime{
  id?:number;
  startFrom :Date;
  details:string;
  employeeId:number;
  endAt?:Date
}
export class PerioicSubscriptionByForm{

  formName: string
  net: number
  subscriptionName: string
  totalCredit: number
  totalDebit:number;
  data:PerioicSubscriptionByFormData[]

}
export class PerioicSubscriptionByFormData{

  amount:number
credirOrDebit:string
employeeName:number
employeeTabCode:string
employeeTegaraCode:string
id:number
}
export class FinancialDataType{
id?:number=0;
name :string='';
reservationDate:string;
parentFinancialDataTypeId:number;
}
export class EmployeeDataFinancialDataType{
  id?:number;
  amount=0;
  employeeId;
  financialDataTypeId:number;
  }


  export class FormEmployeeOrder{
    formId :number;
    employeeId:number;
    formEmployeeId:number;
    orderId:number;
    creditOrDebit:string;
    quantity:number;
    selectedDate:Date;
    details : string
    formEmployeeOrderExecutions:FormEmployeeOrderExecutions[]=[];
  }

  export class FormEmployeeOrderExecutions{
    id:number;
    budgetItemId: number;
    amount:number;
    formEmployeeId:number;
  }
