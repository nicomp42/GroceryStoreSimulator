import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { StoreComponent } from './store/store.component';

const routes: Routes = 
[{path: "dashboard", component: DashboardComponent},
 {path: '', redirectTo: '/dashboard', pathMatch: 'full'}, {path: 'stores', component: StoreComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
