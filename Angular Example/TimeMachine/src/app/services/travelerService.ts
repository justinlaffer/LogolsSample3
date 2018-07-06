import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Log } from '../entities/Log';
import { Traveler } from '../entities/traveler';

@Injectable()
export class TravelerService {
    url: string = "http://localhost:5000/api/TimeTraveler/";

    constructor(private http: HttpClient) { }

    public getAll() {
        return this.http.get<Traveler[]>(this.url);
    }

    public get(id: number) {
        return this.http.get<Traveler>(this.url + id);
    }

    public update(traveler: Traveler) {
        return this.http.put(this.url, traveler);
    }

    public insert(traveler: Traveler) {
        return this.http.post(this.url, traveler);
    }

    public delete(id: number) {
        return this.http.delete(this.url + id);
    }
}