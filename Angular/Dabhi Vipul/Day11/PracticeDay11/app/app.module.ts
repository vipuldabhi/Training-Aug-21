import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ColorsComponent } from './colors/colors.component';
import { ColorsdetailsComponent } from './colorsdetails/colorsdetails.component';
import { ColordetailsComponent } from './colors/colordetails/colordetails.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { ColorquantityComponent } from './colorquantity/colorquantity.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ColorsComponent,
    ColorsdetailsComponent,
    ColordetailsComponent,
    PageNotFoundComponent,
    ColorquantityComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
