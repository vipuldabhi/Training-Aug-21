import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { ProtectedComponent } from './protected/protected.component';
import { AUTH_PROVIDERS } from './auth.service';
import { LoggedinguardService } from './loggedinguard.service';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    ContactUsComponent,
    HomeComponent,
    PageNotFoundComponent,
    ProtectedComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
    AUTH_PROVIDERS,
    LoggedinguardService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
