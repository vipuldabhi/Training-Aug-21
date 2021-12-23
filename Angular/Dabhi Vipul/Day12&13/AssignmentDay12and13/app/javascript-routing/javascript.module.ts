import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { JavascriptRoutingModule } from './javascript-routing.module';
import { JavascriptComponent } from '../javascript/javascript.component';
import { JavascriptDay1Component } from '../javascript/javascript-day1/javascript-day1.component';
import { JavascriptDay2Component } from '../javascript/javascript-day2/javascript-day2.component';
import { JavascriptDay3Component } from '../javascript/javascript-day3/javascript-day3.component';
import { JavascriptDay4Component } from '../javascript/javascript-day4/javascript-day4.component';
import { JavascriptDay6Component } from '../javascript/javascript-day6/javascript-day6.component';


@NgModule({
  declarations: [
    JavascriptComponent,
    JavascriptDay1Component,
    JavascriptDay2Component,
    JavascriptDay3Component,
    JavascriptDay4Component,
    JavascriptDay6Component
  ],
  imports: [
    CommonModule,
    JavascriptRoutingModule
  ]
})
export class JavascriptModule { }
