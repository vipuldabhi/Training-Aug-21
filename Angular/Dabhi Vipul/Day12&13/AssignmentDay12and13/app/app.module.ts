import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { JavascriptComponent } from './javascript/javascript.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { JavascriptDay1Component } from './javascript/javascript-day1/javascript-day1.component';
import { JavascriptDay2Component } from './javascript/javascript-day2/javascript-day2.component';
import { JavascriptDay3Component } from './javascript/javascript-day3/javascript-day3.component';
import { JavascriptDay4Component } from './javascript/javascript-day4/javascript-day4.component';
import { JavascriptDay6Component } from './javascript/javascript-day6/javascript-day6.component';
import { HtmlModule } from './html-routing/html.module';
import { CssModule } from './css-routing/css.module';
import { JavascriptModule } from './javascript-routing/javascript.module';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PageNotFoundComponent,
  ],
  imports: [
    BrowserModule,
    HtmlModule,
    CssModule,
    JavascriptModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
