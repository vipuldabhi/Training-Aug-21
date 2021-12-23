import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { JavascriptDay1Component } from './javascript/javascript-day1/javascript-day1.component';
import { JavascriptDay2Component } from './javascript/javascript-day2/javascript-day2.component';
import { JavascriptDay3Component } from './javascript/javascript-day3/javascript-day3.component';
import { JavascriptDay4Component } from './javascript/javascript-day4/javascript-day4.component';
import { JavascriptDay6Component } from './javascript/javascript-day6/javascript-day6.component';


@NgModule({
  declarations: [
    AppComponent,
    JavascriptDay1Component,
    JavascriptDay2Component,
    JavascriptDay3Component,
    JavascriptDay4Component,
    JavascriptDay6Component,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
