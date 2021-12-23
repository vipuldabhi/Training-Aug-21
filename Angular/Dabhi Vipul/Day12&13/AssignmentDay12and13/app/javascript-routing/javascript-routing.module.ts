import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JavascriptDay1Component } from '../javascript/javascript-day1/javascript-day1.component';
import { JavascriptDay2Component } from '../javascript/javascript-day2/javascript-day2.component';
import { JavascriptDay3Component } from '../javascript/javascript-day3/javascript-day3.component';
import { JavascriptDay4Component } from '../javascript/javascript-day4/javascript-day4.component';
import { JavascriptDay6Component } from '../javascript/javascript-day6/javascript-day6.component';
import { JavascriptComponent } from '../javascript/javascript.component';

const routes: Routes = [
  { path : 'javascript' , component : JavascriptComponent ,
  children:[
    { path : 'javascriptday1' , component : JavascriptDay1Component},
    { path : 'javascriptday2' , component : JavascriptDay2Component},
    { path : 'javascriptday3' , component : JavascriptDay3Component},
    { path : 'javascriptday4' , component : JavascriptDay4Component},
    { path : 'javascriptday6' , component : JavascriptDay6Component},
  ]
},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class JavascriptRoutingModule { }
