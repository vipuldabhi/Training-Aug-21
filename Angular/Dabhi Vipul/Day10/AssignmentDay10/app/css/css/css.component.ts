import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-css',
  templateUrl: './css.component.html',
  styleUrls: ['./css.component.css']
})
export class CssComponent implements OnInit {

  constructor(private router : Router) { }

  ngOnInit(): void {
  }

  navigateToDay1(){
    // this.router.navigateByUrl('assignmentDay1');
    this.router.navigate(['assignmentDay1']);
  }

  navigateToDay2(){
    this.router.navigateByUrl('assignmentDay2');
  }

  navigateToDay3(){
    this.router.navigateByUrl('assignmentDay3');
  }

  navigateToDay4(){
    this.router.navigateByUrl('assignmentDay4');
  }

}
