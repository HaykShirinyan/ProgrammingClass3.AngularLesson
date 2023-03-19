import { Component, OnInit } from "@angular/core";
import { Product } from "../../shared/models/product";
import { ProductSevice } from "../../shared/services/product.service";

@Component({
  templateUrl: './product-list.component.html'
})
export class ProductListComponent implements OnInit {
  private _productService: ProductSevice;

  public products?: Product[];
  public isLoading: boolean = false;

  constructor(productService: ProductSevice) {
    this._productService = productService 
  }

  public ngOnInit(): void {
    this._productService.getAll()
      .subscribe(products => {
        this.products = products;
        this.isLoading = false;
      })
  }

  public cancelLoading(): void {
    this.isLoading = false;
  }
}
