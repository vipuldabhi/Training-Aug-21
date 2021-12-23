import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HtmlComponent } from './html/html.component';
import { HtmlDay1Component } from './html/html-day1/html-day1.component';
import { CssComponent } from './css/css.component';
import { CssDay1Component } from './css/css-day1/css-day1.component';
import { CssDay2Component } from './css/css-day2/css-day2.component';
import { CssDay3Component } from './css/css-day3/css-day3.component';
import { CssDay4Component } from './css/css-day4/css-day4.component';
import { HomeComponent } from './home/home.component';
import { JavascriptComponent } from './javascript/javascript.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { JavascriptDay1Component } from './javascript/javascript-day1/javascript-day1.component';
import { JavascriptDay2Component } from './javascript/javascript-day2/javascript-day2.component';
import { JavascriptDay3Component } from './javascript/javascript-day3/javascript-day3.component';
import { JavascriptDay4Component } from './javascript/javascript-day4/javascript-day4.component';
import { JavascriptDay6Component } from './javascript/javascript-day6/javascript-day6.component';

@NgModule({
  declarations: [
    AppComponent,
    HtmlComponent,
    HtmlDay1Component,
    CssComponent,
    CssDay1Component,
    CssDay2Component,
    CssDay3Component,
    CssDay4Component,
    HomeComponent,
    JavascriptComponent,
    PageNotFoundComponent,
    JavascriptDay1Component,
    JavascriptDay2Component,
    JavascriptDay3Component,
    JavascriptDay4Component,
    JavascriptDay6Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
