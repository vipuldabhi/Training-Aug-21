import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RectangleComponent } from './rectangle/rectangle.component';
import { LoginComponent } from './login/login.component';
import { CircleComponent } from './circle/circle.component';
import { LeftbarComponent } from './leftbar/leftbar.component';
import { SignupComponent } from './signup/signup.component';

@NgModule({
  declarations: [
    AppComponent,
    RectangleComponent,
    LoginComponent,
    CircleComponent,
    LeftbarComponent,
    SignupComponent
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
