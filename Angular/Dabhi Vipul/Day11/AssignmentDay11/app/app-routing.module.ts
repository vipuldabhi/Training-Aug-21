import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CssDay1Component } from './css/css-day1/css-day1.component';
import { CssDay2Component } from './css/css-day2/css-day2.component';
import { CssDay3Component } from './css/css-day3/css-day3.component';
import { CssDay4Component } from './css/css-day4/css-day4.component';
import { CssComponent } from './css/css.component';
import { HomeComponent } from './home/home.component';
import { HtmlDay1Component } from './html/html-day1/html-day1.component';
import { HtmlComponent } from './html/html.component';
import { JavascriptDay1Component } from './javascript/javascript-day1/javascript-day1.component';
import { JavascriptDay2Component } from './javascript/javascript-day2/javascript-day2.component';
import { JavascriptDay3Component } from './javascript/javascript-day3/javascript-day3.component';
import { JavascriptDay4Component } from './javascript/javascript-day4/javascript-day4.component';
import { JavascriptDay6Component } from './javascript/javascript-day6/javascript-day6.component';
import { JavascriptComponent } from './javascript/javascript.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const routes: Routes = [
  { path : '', redirectTo:'home' , pathMatch:'full'},
  { path : 'home' , component : HomeComponent },
  { path : 'html' , component : HtmlComponent ,
    children:[
      { path : 'htmlday1' , component : HtmlDay1Component}
    ]
  },
  { path : 'css' , component : CssComponent ,
    children:[
      { path : 'cssday1' , component : CssDay1Component},
      { path : 'cssday2' , component : CssDay2Component},
      { path : 'cssday3' , component : CssDay3Component},
      { path : 'cssday4' , component : CssDay4Component},
    ]
  },
  { path : 'javascript' , component : JavascriptComponent ,
    children:[
      { path : 'javascriptday1' , component : JavascriptDay1Component},
      { path : 'javascriptday2' , component : JavascriptDay2Component},
      { path : 'javascriptday3' , component : JavascriptDay3Component},
      { path : 'javascriptday4' , component : JavascriptDay4Component},
      { path : 'javascriptday6' , component : JavascriptDay6Component},
    ]
  },
  { path : '**' , component : PageNotFoundComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
