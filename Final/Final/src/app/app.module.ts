import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { FinalComponent } from './Final.component';

import { PersonStatusService } from './Service/PersonStatusService';

@NgModule({
  declarations: [
    AppComponent,
    FinalComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [
    PersonStatusService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }



