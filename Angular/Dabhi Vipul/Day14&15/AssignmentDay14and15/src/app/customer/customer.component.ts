import { Component, OnInit } from '@angular/core';
import { HttpcruddemoService } from '../httpcruddemo.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  customersList:any[]=[];
  id:number=0;
  name:string="";
  address:string="";
  isActive:boolean=true;

  deleteid:number=0;

data:object={};
  constructor(private customer : HttpcruddemoService) { }

  ngOnInit(): void {
  }

  getCustomer(){
    this.customer.getCustomers().subscribe(data => {
      this.customersList=data;
      console.log(data);
    });
  }

  addCustomer(){
  this.data={customerName:this.name,customerAddress:this.address,isActive:this.isActive};
    console.log(this.data);
    this.customer.addCustomer(this.data);
  }

  updateCustomer(){
    this.data={customerID:this.id,customerName:this.name,customerAddress:this.address,isActive:this.isActive};
    this.customer.updateCustomer(this.data);
  }

  deleteCustomer(){
    this.customer.deleteCustomer(this.deleteid);
  }

}
