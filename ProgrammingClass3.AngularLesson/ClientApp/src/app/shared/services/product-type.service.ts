import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ProductType } from "../models/product-type";

@Injectable({
  providedIn: 'root'
})
export class ProductTypeService {
  private _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Observable<ProductType[]> {
    return this._http.get<ProductType[]>('api/products-types');
  }

  public get(id: number): Observable<ProductType> {
    return this._http.get<ProductType>('api/produt-type/' + id);
  }

  public add(producttype: ProductType): Observable<ProductType> {
    return this._http.post<ProductType>('api/product-type', producttype);
  }

  public update(producttype: ProductType): Observable<ProductType> {
    return this._http.put<ProductType>('api/product-type/' + producttype.id, producttype);
  }
}
