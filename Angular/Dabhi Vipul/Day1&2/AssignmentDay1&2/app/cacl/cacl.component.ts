import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cacl',
  templateUrl: './cacl.component.html',
  styleUrls: ['./cacl.component.css']
})
export class CaclComponent implements OnInit {

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
