import { Component } from '@angular/core';
import{PersonStatus} from './entities/PersonStatus';


@Component({
  selector: 'addStatus',
  templateUrl: './addStatus.component.html',
  styleUrls: ['./addStatus.component.css']
})
export class addStatusComponent {
  public PersonStatus:PersonStatus;

  public constructor(private PersonStatusService: PersonStatusService) {
    this.PersonStatus = new PersonStatus();
  }
  
  public insertClick():void {
    this.PersonStatusService.insert(this.PersonStatus).subscribe(() => {
      console.log("person inserted");
    }, error => console.error(error));
  }
}
