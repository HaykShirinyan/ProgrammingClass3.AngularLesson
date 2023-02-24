import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Producttype } from "../../shared/models/product-type";



@Component({
  templateUrl: './product-type-list.component.html'
})
export class ProductTypeListComponent implements OnInit {
  private _httpClient: HttpClient;

  public producttypes?: Producttype[];

  constructor(httpClient: HttpClient) {
    this._httpClient = httpClient;
  }

  public ngOnInit(): void {
    this._httpClient.get<Producttype[]>('api/producttypes')
      .subscribe(producttypes => {
        this.producttypes = producttypes;
      })
  }
}
