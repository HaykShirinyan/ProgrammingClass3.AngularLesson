import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { lastValueFrom, Observable } from "rxjs";
import { ProductType } from "../models/productType";

@Injectable({
  providedIn: 'root'
})
export class ProductTypeService {
  private _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Promise<ProductType[]> {
    const observable = this._http.get<ProductType[]>('api/producttypes');
    return lastValueFrom(observable);
  }
  public get(id: number): Promise<ProductType> {
    const observable = this._http.get<ProductType>('api/producttypes/' + id);
    return lastValueFrom(observable);
  }

  public add(producttype: ProductType): Promise<ProductType> {
    const observable = this._http.post<ProductType>('api/producttypes', producttype);
    return lastValueFrom(observable);
  }

  public update(producttype: ProductType): Promise<ProductType> {
    const observable = this._http.put<ProductType>('api/producttypes/' + producttype.id, producttype);
    return lastValueFrom(observable);
  }

  public delete(producttype: ProductType): Promise<ProductType> {
    const observable = this._http.delete<ProductType>('api/producttypes/' + producttype.id);
    return lastValueFrom(observable);
  }
}
