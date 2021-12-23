import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ColorquantityComponent } from './colorquantity/colorquantity.component';
import { ColorsComponent } from './colors/colors.component';
import { ColorsdetailsComponent } from './colorsdetails/colorsdetails.component';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const routes: Routes = [
  { path : '',redirectTo:'home',pathMatch:'full' },
  { path : 'home',component:HomeComponent },
  { path : 'colors',component:ColorsComponent ,
      children:[
        {
          path : 'colorsdetails',component : ColorsdetailsComponent
        },
        {
          path : 'colorsquantiry',component : ColorquantityComponent
        }
      ]
},
{ path : '**',component:PageNotFoundComponent },



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
