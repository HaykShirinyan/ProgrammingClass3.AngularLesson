import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { lastValueFrom, Observable } from "rxjs";
import { ProductType } from "../models/product-type";

@Injectable({
  providedIn: 'root'
})
export class ProductTypeService {
  private readonly _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Promise<ProductType[]> {
    const observable = this._http.get<ProductType[]>('api/product-types');
    return lastValueFrom(observable);
  }

  public get(id: number): Promise<ProductType> {
    const observable = this._http.get<ProductType>('api/product-types/' + id);
    return lastValueFrom(observable);
  }

  public add(productType: ProductType): Promise<ProductType> {
    const observable = this._http.post<ProductType>('api/product-types', productType);
    return lastValueFrom(observable);
  }

  public update(productType: ProductType): Promise<ProductType> {
    const observable = this._http.put<ProductType>('api/product-types/' + productType.id, productType);
    return lastValueFrom(observable);
  }
}
