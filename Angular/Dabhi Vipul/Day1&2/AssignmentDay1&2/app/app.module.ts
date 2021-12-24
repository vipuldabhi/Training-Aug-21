import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HelloworldComponent } from './helloworld/helloworld.component';
import { CaclComponent } from './cacl/cacl.component';
import { RectangleComponent } from './rectangle/rectangle.component';
import { LoginComponent } from './login/login.component';
import { CircleComponent } from './circle/circle.component';
import { LeftBarComponent } from './left-bar/left-bar.component';
import { SignupComponent } from './signup/signup.component';
import { Practiceday1and2Component } from './practiceday1and2/practiceday1and2.component';

@NgModule({
  declarations: [
    AppComponent,
    HelloworldComponent,
    CaclComponent,
    RectangleComponent,
    LoginComponent,
    CircleComponent,
    LeftBarComponent,
    SignupComponent,
    Practiceday1and2Component,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
