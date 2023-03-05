import { Router } from "@angular/router";
import { ProductType } from "../../shared/models/product-type";
import { ProductTypeService } from "../../shared/services/product-type.service";

export class CreateProductType {
  private _productTypeService: ProductTypeService;
  private _router: Router;

  public productType: ProductType = {};

  constructor(productTypeService: ProductTypeService,
    router: Router)
  {
    this._productTypeService = productTypeService,
    this._router = router
  }

  public createProductType(): void {
    this._productTypeService.add(this.productType)
      .subscribe(() => {
        this._router.navigate(['product-types']);
      });
  }
}
