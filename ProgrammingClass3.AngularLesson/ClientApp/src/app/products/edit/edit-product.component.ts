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

  public async ngOnInit(): Promise<void> {
    try {
      this.spinnerText = 'Loading product data...'
      this.isLoading = true;

      let id = this._activatedRoute.snapshot.paramMap.get('id');

      this.product = await this._productService.get(Number(id));
    } finally {
      this.isLoading = false;
    }
  }

  public async updateProduct(): Promise<void> {
    try {
      this.spinnerText = 'Editing product data...'
      this.isLoading = true;

      await this._productService.update(this.product!);

      this._router.navigate(['products']);
    } finally {
      this.isLoading = false;
    }
  }

  public cancelLoading(): void {
    this.isLoading = false;
  }
}
