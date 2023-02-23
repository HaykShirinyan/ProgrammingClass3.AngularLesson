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
}
