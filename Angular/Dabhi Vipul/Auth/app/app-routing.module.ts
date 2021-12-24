import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { HomeComponent } from './home/home.component';
import { LoggedinguardService } from './loggedinguard.service';
import { LoginComponent } from './login/login.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { ProtectedComponent } from './protected/protected.component';

const routes: Routes = [
  {
    path : '' ,redirectTo : 'home' ,pathMatch : 'full'
  },
  {
    path : 'home' , component : HomeComponent
  },
  {
    path : 'contact-us' , component : ContactUsComponent
  },
  {
    path : 'login' , component : LoginComponent
  },
  {
    path : 'protected' , component : ProtectedComponent , 
      canActivate : [LoggedinguardService]
  },
  {
    path : '**' , component : PageNotFoundComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
