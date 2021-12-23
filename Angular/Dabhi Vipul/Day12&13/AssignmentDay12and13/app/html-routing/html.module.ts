import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HtmlRoutingModule } from './html-routing.module';
import { HtmlComponent } from '../html/html.component';
import { HtmlDay1Component } from '../html/html-day1/html-day1.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    HtmlComponent,
    HtmlDay1Component
  ],
  imports: [
    CommonModule,
    HtmlRoutingModule,
    FormsModule
  ]
})
export class HtmlModule { }
