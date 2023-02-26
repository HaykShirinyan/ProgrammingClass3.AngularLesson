import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Product } from "../models/product";

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Observable<Product[]> {
    return this._http.get<Product[]>('api/products');
  }

  public get(id: number): Observable<Product> {
    return this._http.get<Product>('api/products/' + id);
  }

  public add(product: Product): Observable<Product> {
    return this._http.post<Product>('api/products', product);
  }

  public update(product: Product): Observable<Product> {
    return this._http.put<Product>('api/products/' + product.id, product);
  }
}
