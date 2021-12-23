import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CssDay1Component } from '../css/css-day1/css-day1.component';
import { CssDay2Component } from '../css/css-day2/css-day2.component';
import { CssDay3Component } from '../css/css-day3/css-day3.component';
import { CssDay4Component } from '../css/css-day4/css-day4.component';
import { CssComponent } from '../css/css.component'; 

const routes: Routes = [
  { path : 'css' , component : CssComponent ,
    children:[
      { path : 'cssday1' , component : CssDay1Component},
      { path : 'cssday2' , component : CssDay2Component},
      { path : 'cssday3' , component : CssDay3Component},
      { path : 'cssday4' , component : CssDay4Component},
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CssRoutingModule { }
