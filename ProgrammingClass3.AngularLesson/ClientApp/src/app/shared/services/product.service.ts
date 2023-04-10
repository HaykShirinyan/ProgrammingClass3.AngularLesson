import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { lastValueFrom } from "rxjs";
import { Product } from "../models/product";

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  public getAll(): Promise<Product[]> {
    const observable = this._http.get<Product[]>('api/products');
    return lastValueFrom(observable);
  }

  public get(id: number): Promise<Product> {
    const observable = this._http.get<Product>('api/products/' + id);
    return lastValueFrom(observable);
  }

  public add(product: Product): Promise<Product> {
    const observable = this._http.post<Product>('api/products', product);
    return lastValueFrom(observable);
  }

  public update(product: Product): Promise<Product> {
    const observable = this._http.put<Product>('api/products/' + product.id, product);
    return lastValueFrom(observable);
  }

  public delete(product: Product): Promise<Product> {
    const observable = this._http.delete<Product>('api/products/' + product.id);
    return lastValueFrom(observable);
  }
}
