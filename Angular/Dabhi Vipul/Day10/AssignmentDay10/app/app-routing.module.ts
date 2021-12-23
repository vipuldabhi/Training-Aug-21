import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { AssignmentDay1Component } from './css/assignment-day1/assignment-day1.component';
import { AssignmentDay2Component } from './css/assignment-day2/assignment-day2.component';
import { AssignmentDay3Component } from './css/assignment-day3/assignment-day3.component';
import { AssignmentDay4Component } from './css/assignment-day4/assignment-day4.component';
import { CssComponent } from './css/css/css.component';
import { HomeComponent } from './home/home.component';
import { AsignmentDay1Component } from './html/asignment-day1/asignment-day1.component';
import { HtmlComponent } from './html/html/html.component';
import { JavascriptDay1Component } from './javascript/javascript-day1/javascript-day1.component';
import { JavascriptDay2Component } from './javascript/javascript-day2/javascript-day2.component';
import { JavascriptDay3Component } from './javascript/javascript-day3/javascript-day3.component';
import { JavascriptDay4Component } from './javascript/javascript-day4/javascript-day4.component';
import { JavascriptDay6Component } from './javascript/javascript-day6/javascript-day6.component';
import { JavascriptComponent } from './javascript/javascript/javascript.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const routes: Routes = [
  // {
  //   path : '
  //   component : HtmlComponent
  // },
  {
    path:'',redirectTo:'home',pathMatch:'full'
  },
  {
    path : 'home',
    component : HomeComponent
  },
  {
    path : 'html',
    component : HtmlComponent
  },
  {
    path : 'css',
    component : CssComponent
  },
  {
    path : 'javascript',
    component : JavascriptComponent
  },
  { path : 'asignmentDay1' , component:AsignmentDay1Component},
  { path : 'assignmentDay1' , component:AssignmentDay1Component},
  { path : 'assignmentDay2' , component:AssignmentDay2Component},
  { path : 'assignmentDay3' , component:AssignmentDay3Component},
  { path : 'assignmentDay4' , component:AssignmentDay4Component},

  { path : 'javascriptDay1' , component:JavascriptDay1Component},
  { path : 'javascriptDay2' , component:JavascriptDay2Component},
  { path : 'javascriptDay3' , component:JavascriptDay3Component},
  { path : 'javascriptDay4' , component:JavascriptDay4Component},
  { path : 'javascriptDay6' , component:JavascriptDay6Component},

  {
    path : '**',
    component : PageNotFoundComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
