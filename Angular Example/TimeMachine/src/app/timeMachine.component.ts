import { Component } from '@angular/core';
import { Log } from './entities/log'
import { LogService } from './services/logService'
import { TravelerService } from './services/travelerService'
import { Traveler } from './entities/traveler'

@Component({
  selector: 'timemachine',
  templateUrl: './timeMachine.component.html',
  styleUrls: ['./timeMachine.component.css']
})
export class TimeMachineComponent {
  public log:Log;
  public travelers:Traveler[];
  public currentTravelerId:number;

  public constructor(private logService: LogService, private travelerService: TravelerService) {
    this.log = new Log();
    this.travelers = [];
    this.travelerService.getAll().subscribe(result => {
      this.travelers.push(...result);
    }, error => console.error(error));
  }

  public insertClick():void {
    this.logService.insert(this.log).subscribe(() => {
      console.log("log inserted");
    }, error => console.error(error));
  }

  public timeTravelerChanged():void {
    let editLink = document.getElementById("EditLink");
    if (this.log.timeTravelerId == null) {
      editLink.style.display = "none";
    }
    else {
      this.currentTravelerId = Number((<HTMLInputElement>document.getElementById("Traveler")).value);
      editLink.style.display = "inline";
    }
  }
}