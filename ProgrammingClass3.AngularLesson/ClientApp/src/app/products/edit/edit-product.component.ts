import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Product } from "../../shared/models/product";
import { ProductService } from "../../shared/services/product.service";

@Component({
  templateUrl: './edit-product.component.html'
})
export class EditProductComponent implements OnInit {
  private readonly _productService: ProductService;
  private readonly _router: Router;
  private readonly _activatedRoute: ActivatedRoute;

  public product?: Product;

  constructor(
    productService: ProductService,
    router: Router,
    activatedRoute: ActivatedRoute
  ) {
    this._productService = productService;
    this._router = router;
    this._activatedRoute = activatedRoute
  }

  public async ngOnInit(): Promise<void> {
    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this.product = await this._productService.get(Number(id));
  }

  public async updateProduct(): Promise<void> {
    await this._productService.update(this.product!);
    this._router.navigate(['products']);
  }
}
