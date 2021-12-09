import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-rectangle',
  templateUrl: './rectangle.component.html',
  styleUrls: ['./rectangle.component.css']
})
export class RectangleComponent implements OnInit {


  length : number = 0;
  height : number = 0;

  area : number = 0;

  AreaOfRectangle(a:number,b:number){
    this.area = a * b;
  }


  constructor() { }

  ngOnInit(): void {
  }

}
