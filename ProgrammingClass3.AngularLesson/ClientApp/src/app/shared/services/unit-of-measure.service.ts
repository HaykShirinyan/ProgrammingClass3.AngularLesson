import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { UnitOfMeasure } from "../models/unit-of-measure";

@Injectable({
  providedIn: 'root'
})
export class UnitOfMeasureService {
  private _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Observable<UnitOfMeasure[]> {
    return this._http.get<UnitOfMeasure[]>('api/unit-of-measure');
  }

  public get(id: number): Observable<UnitOfMeasure[]> {
    return this._http.get<UnitOfMeasure>('api/unit-of-measure/' + id);
  }

  public add(unitOfMeasure: UnitOfMeasure): Observable<UnitOfMeasure> {
    return this._http.post<UnitOfMeasure>('api/unit-of-measure/'unitOfMeasure);
  }

  public update(unitOfMeasure: UnitOfMeasure): Observable<UnitOfMeasure> {
    return this._http.put<UnitOfMeasure>('api/unit-of-measure/' + unitOfMeasure.id, unitOfMeasure);
  }
}
