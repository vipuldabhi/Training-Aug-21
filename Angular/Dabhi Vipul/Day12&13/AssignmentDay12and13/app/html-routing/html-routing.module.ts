import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HtmlDay1Component } from '../html/html-day1/html-day1.component';
import { HtmlComponent } from '../html/html.component';

const htmlroutes: Routes = [
  { 
    path : 'html' , component : HtmlComponent ,
    children:[
      { path : 'htmlday1' , component : HtmlDay1Component}
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(htmlroutes)],
  exports: [RouterModule]
})
export class HtmlRoutingModule { }
