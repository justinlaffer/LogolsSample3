import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { AngularComponent } from './Angular.component';
import { addStatusComponent } from './addStatus.component';

import { PersonStatusService } from './Service/PersonStatusService';

const appRoutes: Routes = [
  {path: 'addStatus', component:addStatusComponent},
  {path:'Angular', component:AngularComponent},
  {path:'', component:AngularComponent}
];

@NgModule({
  declarations: [
    AppComponent
    ,AngularComponent
    ,addStatusComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [ PersonStatusService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
