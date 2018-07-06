import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { LogComponent } from './log.component';
import { TimeMachineComponent } from './timeMachine.component';
import { TravelerComponent } from './traveler.component';
import { TravelerService } from './services/travelerService';
import { LogService } from './services/logService';

const appRoutes: Routes = [
  { path: 'log', component: LogComponent },
  { path: 'timeMachine', component: TimeMachineComponent },
  { path: 'traveler', component: TravelerComponent },
  { path: 'traveler/:id', component: TravelerComponent },
  { path: '', component: TimeMachineComponent }  
];

@NgModule({
  declarations: [
    AppComponent,
    LogComponent,
    TimeMachineComponent,
    TravelerComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    LogService,
    TravelerService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
