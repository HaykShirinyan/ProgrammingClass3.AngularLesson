import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { lastValueFrom, Observable } from "rxjs";
import { UnitOfMeasure } from "../models/unit-of-measure";

@Injectable({
  providedIn:'root'
})
export class UnitOfMeasureService{
  private readonly _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Promise<UnitOfMeasure[]> {
    const observable = this._http.get<UnitOfMeasure[]>('api/unit-of-measures');
    return lastValueFrom(observable);
  }

  public get(id: number): Promise<UnitOfMeasure> {
    const observable = this._http.get<UnitOfMeasure>('api/unit-of-measures/' + id);
    return lastValueFrom(observable);
  }

  public add(unitOfMeasure: UnitOfMeasure): Promise<UnitOfMeasure> {
    const observable = this._http.post<UnitOfMeasure>('api/unit-of-measures', unitOfMeasure);
    return lastValueFrom(observable);
  }

  public update(unitOfMeasure: UnitOfMeasure): Promise<UnitOfMeasure> {
    const observable = this._http.put<UnitOfMeasure>('api/unit-of-measures/' + unitOfMeasure.id, unitOfMeasure);
    return lastValueFrom(observable);
  }

  public delete(unitOfMeasure: UnitOfMeasure): Promise<UnitOfMeasure> {
    const observable = this._http.delete<UnitOfMeasure>('api/unit-of-measures/' + unitOfMeasure.id);
    return lastValueFrom(observable);
  }
}


