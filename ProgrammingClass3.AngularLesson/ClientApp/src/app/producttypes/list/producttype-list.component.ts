import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { ProductType } from "../../shared/models/productType";

@Component({
  templateUrl: './producttype-list.component.html'
})
export class ProductTypeListComponent implements OnInit {
  private _httpClient: HttpClient;

  public producttypes?: ProductType[];

  constructor(httpClient: HttpClient) {
    this._httpClient = httpClient;
  }

  public ngOnInit(): void {
    this._httpClient.get<ProductType[]>('api/producttypes')
      .subscribe(producttypes => {
        this.producttypes = producttypes;
      });
  }
}
