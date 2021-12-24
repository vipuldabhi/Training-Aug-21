import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-practiceday1and2',
  templateUrl: './practiceday1and2.component.html',
  styleUrls: ['./practiceday1and2.component.css']
})
export class Practiceday1and2Component implements OnInit {


  day : string = "Day1_2";
  dayDetails : string = "";

  clickOutput : string = "";

  clickEvent(){
    this.clickOutput = "this is a click event";
  }


  constructor() { }

  ngOnInit(): void {
  }

}
