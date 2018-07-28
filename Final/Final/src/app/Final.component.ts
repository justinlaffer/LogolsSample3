import { Component } from '@angular/core';
import{PersonStatus} from './entities/PersonStatus';
import { PersonStatusService } from './Service/PersonStatusService'


@Component({
  selector: 'zombiereport',
  templateUrl: './Final.component.html',
  styleUrls: ['./Final.component.css']
})
export class FinalComponent {
  public title:string = 'Zombie Status Report';
  public Member:PersonStatus[] = [];

  
  public constructor(PersonStatusService: PersonStatusService) {
    PersonStatusService.getAll().subscribe(result => {
      for (let Member of result) {
        this.Member.push(Member);
      }
    }, error => { 
      console.log(error)
    });
     
    /*this.Member = [
      {FirstName:'Justin, LastName:'Laffer', MemberId:1, MemberDescription:'Active'},
      {FirstName:'John', LastName:'Smith', MemberId:1, MemberDescription:'Active'},
      {FirstName:'Jim', LastName:'Miller', MemberId:2,MemberDescription:'Inactive'},
      {FirstName:'Sam', LastName:'Tredwell', MemberId:2, MemberDescription:'Inacive},
     
      ];*/

    }
  }