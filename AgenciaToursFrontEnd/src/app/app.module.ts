import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { RegistroComponent } from './components/registro/registro.component';
import { HomeComponent } from './components/home/home.component';
import { RouterModule, Routes } from '@angular/router';
import { CrudComponent } from './components/crud/crud.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatToolbarModule} from '@angular/material/toolbar';

const appRoutes: Routes=[
  { path:'registro', component: RegistroComponent },
  { path: 'home', component: HomeComponent },
  { path: 'crud', component: CrudComponent },
  //{ path:'list', component: ListPerfilComponent },
  { path:'', redirectTo:'/', pathMatch:'full' },
  { path: '**', redirectTo: '' }
]

@NgModule({
  declarations: [
    AppComponent,
    RegistroComponent,
    HomeComponent,
    CrudComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes),
    BrowserAnimationsModule,
    MatToolbarModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
