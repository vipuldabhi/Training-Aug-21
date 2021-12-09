import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-practiceday3',
  templateUrl: './practiceday3.component.html',
  styleUrls: ['./practiceday3.component.css']
})
export class Practiceday3Component implements OnInit {

  show:boolean=true;


  showhide(){
    if(this.show == true){
      this.show = false;
    }
    else{
      this.show = true;
    }
  }

  productList:Array<any>=[{ProductName:"Pen",ProductPrice:30,ProductQuantity:50,rating:1},
                          {ProductName:"Pencil",ProductPrice:15,ProductQuantity:25,rating:2}]
  
  color:string="";

 changeColor(){
   return this.color;
 }

 background:string="";

  constructor() { 
    
  }

  ngOnInit(): void {
  }

}
