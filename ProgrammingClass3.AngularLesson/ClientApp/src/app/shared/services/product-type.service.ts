import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { ProductType } from "../models/product-type";

export class ProductTypeService {
  private _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Observable<ProductType[]> {
    return this._http.get<ProductType[]>('api/product-types')
  } 
}
