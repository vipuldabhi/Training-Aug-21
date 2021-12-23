import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-javascript',
  templateUrl: './javascript.component.html',
  styleUrls: ['./javascript.component.css']
})
export class JavascriptComponent implements OnInit {

  constructor(private router : Router) { }

  ngOnInit(): void {
  }

  navigateToDay1(){
    this.router.navigateByUrl('javascriptDay1');
  }

  navigateToDay2(){
    this.router.navigateByUrl('javascriptDay2');
  }

  navigateToDay3(){
    this.router.navigateByUrl('javascriptDay3');
  }

  navigateToDay4(){
    this.router.navigateByUrl('javascriptDay4');
  }

  navigateToDay6(){
    this.router.navigateByUrl('javascriptDay6');
  }



}
