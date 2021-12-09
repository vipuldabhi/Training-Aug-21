import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})
export class CalcComponent implements OnInit {


  a : number = 0;
  b : number = 0;
  result : number = 0;

Addition(a:number,b:number) {
      this.result = a + b;
  }
Subtraction(a:number,b:number)  {
    this.result = a - b;
}
Multiplication(a:number,b:number)  {
  this.result = a * b;
}
Division(a:number,b:number)  {
  this.result = a / b;
}


  constructor() { }

  ngOnInit(): void {
  }

}
