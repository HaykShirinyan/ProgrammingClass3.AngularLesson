import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { lastValueFrom, Observable } from "rxjs";
import { UnitOfMeasure } from "../models/unitOfMeasure";

@Injectable({
  providedIn: 'root'
})
export class UnitOfMeasureService {
  private _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Promise<UnitOfMeasure[]> {
    const observable = this._http.get<UnitOfMeasure[]>('api/unitofmeasures');
    return lastValueFrom(observable);
  }
  public get(id: number): Promise<UnitOfMeasure> {
    const observable = this._http.get<UnitOfMeasure>('api/unitofmeasures/' + id);
    return lastValueFrom(observable);
  }

  public add(unitofmeasure: UnitOfMeasure): Promise<UnitOfMeasure> {
    const observable = this._http.post<UnitOfMeasure>('api/unitofmeasures', unitofmeasure);
    return lastValueFrom(observable);
  }

  public update(unitofmeasure: UnitOfMeasure): Promise<UnitOfMeasure> {
    const observable = this._http.put<UnitOfMeasure>('api/unitofmeasures/' + unitofmeasure.id, unitofmeasure);
    return lastValueFrom(observable);
  }
}
