import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CssRoutingModule } from './css-routing.module';
import { CssComponent } from '../css/css.component';
import { CssDay1Component } from '../css/css-day1/css-day1.component';
import { CssDay2Component } from '../css/css-day2/css-day2.component';
import { CssDay3Component } from '../css/css-day3/css-day3.component';
import { CssDay4Component } from '../css/css-day4/css-day4.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [ 
    CssComponent,
    CssDay1Component,
    CssDay2Component,
    CssDay3Component,
    CssDay4Component
  ],
  imports: [
    CommonModule,
    CssRoutingModule,
    FormsModule
  ]
})
export class CssModule { }
