import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { UnitOfMeasure } from "../models/unitOfMeasure";

@Injectable({
  providedIn: 'root'
})
export class UnitOfMeasureService {
  private _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Observable<UnitOfMeasure[]> {
    return this._http.get<UnitOfMeasure[]>('api/unitofmeasures');
  }

  public get(id: number): Observable<UnitOfMeasure> {
    return this._http.get<UnitOfMeasure>('api/unitofmeasures/' + id);
  }

  public add(unitofmeasure: UnitOfMeasure): Observable<UnitOfMeasure> {
    return this._http.post<UnitOfMeasure>('api/unitofmeasures', unitofmeasure);
  }

  public update(unitofmeasure: UnitOfMeasure): Observable<UnitOfMeasure> {
    return this._http.put<UnitOfMeasure>('api/unitofmeasures/' + unitofmeasure.id, unitofmeasure);
  }
}
