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
  public isLoading: boolean = false;
  public spinnerText!: string;

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

  public ngOnInit(): void {
    this.isLoading = true;
    this.spinnerText = 'Loading product data';

    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this._productService.get(Number(id))
      .subscribe(product => {
        this.product = product;
        this.isLoading = false;
      });
  }

  public updateProduct(): void {
    this.isLoading = true;
    this.spinnerText = 'Editing product';

    this._productService.update(this.product!)
      .subscribe(() => {
        this._router.navigate(['products']);
        this.isLoading = false;
      });
  }

  public cancelLoading(): void {
    this.isLoading = false;
  }
}
