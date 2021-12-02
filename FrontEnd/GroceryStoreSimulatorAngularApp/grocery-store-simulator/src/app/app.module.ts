import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarModule } from './navbar/navbar.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DashboardModule } from './dashboard/dashboard.module';
import { StoreComponent } from './store/store.component'
import { HttpClientModule } from '@angular/common/http';
import { AppConfig } from './config/AppConfig';


@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    StoreComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NavbarModule,
    DashboardModule,
    HttpClientModule
  ],
  providers: [AppConfig],
  bootstrap: [AppComponent],
  exports: [
  ]
})
export class AppModule { }
