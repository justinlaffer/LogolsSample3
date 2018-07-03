import { Component } from '@angular/core';
import{PersonStatus} from './entities/PersonStatus';
import { PersonStatusService } from './Service/PersonStatusService'

@Component({
  selector: 'zombiereport',
  templateUrl: './Angular.component.html',
  styleUrls: ['./Angular.component.css']
})
export class AngularComponent {
  public title:string = 'Zombie Status Report';
  public statuses:PersonStatus[] = [];

  
  public constructor(PersonStatusService: PersonStatusService) {
    PersonStatusService.getAll().subscribe(result => {
      for (let status of result) {
        this.statuses.push(status);
      }
    }, error => { 
      console.log(error)
    });
     
    /*this.statuses = [
      {firstName:'Elliot', lastName:'Disner', statusId:4, statusDescription:'Unknown'},
      {firstName:'Sam', lastName:'Cohen', statusId:2, statusDescription:'Zombie'},
      {firstName:'Justin', lastName:'Laffer', statusId:1,statusDescription:'Alive'},
      {firstName:'Ben', lastName:'Tredwell', statusId:3, statusDescription:'Dead'},
      {firstName:'Matt',lastName:'Smith', statusId:2, statusDescription:'Zombie'}
      ];*/
    }
  }
