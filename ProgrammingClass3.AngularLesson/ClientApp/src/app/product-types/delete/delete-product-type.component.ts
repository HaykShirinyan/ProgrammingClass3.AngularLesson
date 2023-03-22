import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { ProductType } from "../../shared/models/product-type";
import { ProductTypeService } from "../../shared/services/product-type.service";

@Component({
  templateUrl: './delete-product-type.component.html'
})
export class DeleteProductTypeComponent implements OnInit {
  private readonly _productTypeService: ProductTypeService;
  private readonly _router: Router;
  private readonly _activatedRoute: ActivatedRoute;

  public productType?: ProductType;
  public isLoading: boolean = false;
  public spinnerText!: string;

  constructor(
    productTypeService: ProductTypeService,
    router: Router,
    activatedRoute: ActivatedRoute,
  ) {
    this._productTypeService = productTypeService;
    this._router = router;
    this._activatedRoute = activatedRoute;
  }

  public async ngOnInit(): Promise<void> {
    try {
      this.spinnerText = 'Loading product type data...';
      this.isLoading = true;

      let id = this._activatedRoute.snapshot.paramMap.get('id');

      this.productType = await this._productTypeService.get(Number(id));
    } finally {
      this.isLoading = false;
    }
  }

  public async deleteProductType(): Promise<void> {
    try {
      this.spinnerText = 'Deleting producttype'
      this.isLoading = true;

      await this._productTypeService.delete(this.productType!);

      this._router.navigate(['product-types']);
    } finally {
      this.isLoading = false;
    }
  }

  public cancelLoading(): void {
    this.isLoading = false;
  }
}
