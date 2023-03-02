import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ProductType } from "../models/product-type";

@Injectable({
  providedIn: 'root'
})
export class ProductTypeService {
  private readonly _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Observable<ProductType[]> {
    return this._http.get<ProductType[]>('api/product-types');
  }

  public get(id: number): Observable<ProductType> {
    return this._http.get<ProductType>('api/product-types/' + id);
  }

  public add(productType: ProductType): Observable<ProductType> {
    return this._http.post<ProductType>('api/product-types', productType);
  }

  public update(productType: ProductType): Observable<ProductType> {
    return this._http.put<ProductType>('api/product-types/' + productType.id, productType);
  }
}
