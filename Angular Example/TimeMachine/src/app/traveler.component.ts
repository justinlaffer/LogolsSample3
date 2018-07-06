import { Component } from '@angular/core';
import { Traveler } from './entities/traveler';
import { TravelerService } from './services/travelerService';
import { ActivatedRoute } from '@angular/router';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'traveler',
  templateUrl: './traveler.component.html',
  styleUrls: ['./traveler.component.css']
})
export class TravelerComponent {
  public traveler:Traveler;
  public operation:string = "Add";

  public constructor(private route: ActivatedRoute, private travelerService: TravelerService) {
    let id:number = 0; 
    this.route.params.subscribe((params) => id = +params['id']);
    this.traveler = new Traveler();

    if (id != null && id > 0) {
      this.travelerService.get(id).subscribe((traveler) => this.traveler = traveler);
      this.operation = "Edit";
    }
  }

  public insertClick():void {
    if (this.operation == "Add") {
      this.travelerService.insert(this.traveler).subscribe(() => {
        console.log("traveler inserted");
      }, error => console.error(error));
    }
    else {
      console.log(this.traveler);
      this.travelerService.update(this.traveler).subscribe(() => {
        console.log("traveler updated");
      }, error => console.error(error));
    }
  }
}