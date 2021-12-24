import { Component, OnInit , Input, OnChanges, SimpleChanges, DoCheck, AfterContentInit, AfterContentChecked, AfterViewChecked, AfterViewInit, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit , OnChanges , DoCheck, AfterContentInit, AfterContentChecked
                                            , AfterViewInit, AfterViewChecked ,OnDestroy{

  @Input() simpleInput:string="";
  
  constructor() { }

  
  ngOnInit(): void {
    console.log("ngOnInit Called");
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log("onChangesCalled");
    for(let val in changes){
    let change = changes[val];
    let currentValue = JSON.stringify(change.currentValue);
    let previousValue = JSON.stringify(change.previousValue);
    console.log(`${val} : currentValue = ${currentValue} , previousValue = ${previousValue}`);
    }
  }


  ngDoCheck() {
    console.log("ngDoCheck");
  }

  ngAfterContentInit() {
    console.log("ngAfterContentInit");
  }

  ngAfterContentChecked() {
    console.log("ngAfterContentChecked");
  }

  ngAfterViewInit() {
    console.log("ngAfterViewInit");
  }

  ngAfterViewChecked() {
    console.log("ngAfterViewChecked");
  }

  ngOnDestroy() {
    console.log("ngOnDestroy");
  }

}
