import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ProductType } from "../models/productType";

@Injectable({
  providedIn: 'root'
})
export class ProductTypeService {
  private _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Observable<ProductType[]> {
    return this._http.get<ProductType[]>('api/producttypes');
  }

  public get(id: number): Observable<ProductType> {
    return this._http.get<ProductType>('api/producttypes/' + id);
  }

  public add(producttype: ProductType): Observable<ProductType> {
    return this._http.post<ProductType>('api/producttypes', producttype);
  }

  public update(producttype: ProductType): Observable<ProductType> {
    return this._http.put<ProductType>('api/producttypes/' + producttype.id, producttype);
  }
}
