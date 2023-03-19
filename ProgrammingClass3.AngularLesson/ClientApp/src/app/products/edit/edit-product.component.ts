import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Product } from "../../shared/models/product";
import { ProductSevice } from "../../shared/services/product.service";

@Component({
  templateUrl: './edit-product.component.html'
})
export class EditProductComponent implements OnInit {
  private readonly _productService: ProductSevice;
  private readonly _router: Router;
  private readonly _activatedRoute: ActivatedRoute;

  public product?: Product;

  constructor(
    productService: ProductSevice,
    router: Router,
    activatedRoute: ActivatedRoute
  ) {
    this._productService = productService;
    this._router = router;
    this._activatedRoute = activatedRoute;
  }

  public ngOnInit(): void {
    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this._productService.get(Number(id))
      .subscribe(product => {
        this.product = product;
      });
  }

  public updateProduct(): void {
    this._productService.update(this.product!)
      .subscribe(() => {
        this._router.navigate(['products']);
      });
  }
}
