import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Product } from "../models/product";

@Injectable({
  providedIn: 'root'
})
export class ProductSevice {
  private _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Observable<Product[]> {
    return this._http.get<Product[]>('api/products');
  } 
}
