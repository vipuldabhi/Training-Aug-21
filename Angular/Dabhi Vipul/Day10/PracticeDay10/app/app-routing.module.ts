import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { UserComponent } from './user/user.component';

const routes: Routes = [
  {
    path:'',redirectTo : 'user',
    pathMatch : 'full'
  },
  {
    path:'user',
    component:UserComponent
  },
  {
    path:'admin',
    component:AdminComponent
  },
  {
    path:'user/:id/:name',
    component:UserComponent
  },
  {
    path:'**',
    component:PageNotFoundComponent
  }

  // { path: '',   redirectTo: '/heroes', pathMatch: 'full' },
  // { path: 'crisis-center', component: CrisisListComponent },
  // { path: 'heroes', component: HeroListComponent },
  // { path: '**', component: PageNotFoundComponent   },

  
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
