import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-circle',
  templateUrl: './circle.component.html',
  styleUrls: ['./circle.component.css']
})
export class CircleComponent implements OnInit {


  r : number = 0;

  CircleArea : number = 0;

  AreaOfCircle(r : number){
    this.CircleArea = (3.14 * r * r)
  }


  constructor() { }

  ngOnInit(): void {
  }

}
