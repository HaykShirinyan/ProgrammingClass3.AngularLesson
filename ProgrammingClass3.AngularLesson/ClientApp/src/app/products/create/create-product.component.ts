import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { Product } from "../../shared/models/product";
import { ProductService } from "../../shared/services/product.service";

@Component({
  templateUrl: './create-product.component.html'
})
export class CreateProductComponent {
  private readonly _productService: ProductService;
  private readonly _router: Router;

  public product: Product = {};
  public isLoading: boolean = false;

  constructor(
    productService: ProductService,
    router: Router
  ) {
    this._productService = productService;
    this._router = router;
  }

  public async createProduct(): Promise<void> {
    try {
      this.isLoading = true;

      await this._productService.add(this.product);

      this._router.navigate(['products']);
    } finally {
      this.isLoading = false;
    }
  }

  public cancelLoading(): void {
    this.isLoading = false;
  }
}
