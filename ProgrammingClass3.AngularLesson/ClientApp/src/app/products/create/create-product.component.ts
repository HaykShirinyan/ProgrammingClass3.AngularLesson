import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { Product } from "../../shared/models/product";
import { ProductSevice } from "../../shared/services/product.service";

@Component({
  templateUrl: './create-product.component.html'
})
export class CreateProductComponent {
  private readonly _productService: ProductSevice;
  private readonly _router: Router;

  public product: Product = {};

  constructor(
    productService: ProductSevice,
    router: Router
  ) {
    this._productService = productService;
    this._router = router;
  }

  public createProduct(): void {
    this._productService.add(this.product)
      .subscribe(() => {
        this._router.navigate(['products']);
      });
  }
}
