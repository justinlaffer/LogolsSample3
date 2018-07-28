import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PersonStatus } from '../entities/PersonStatus';

@Injectable()
export class PersonStatusService {
    url: string = "http://localhost:5000/api/PersonStatus/";

    constructor(private http: HttpClient) { }

    public getAll() {
        return this.http.get<PersonStatus[]>(this.url);
    }

    public get(id: number) {
        return this.http.get<PersonStatus>(this.url + id);
    }

    public update(Member: PersonStatus) {
        return this.http.put(this.url, Member);
    }

    public insert(Member: PersonStatus) {
        return this.http.post(this.url, Member);
    }

    public delete(id: number) {
        return this.http.delete(this.url + id);
    }
}