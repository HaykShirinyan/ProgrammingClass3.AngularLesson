import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { ProductType } from "../../shared/models/productType";
import { ProductTypeService } from "../../shared/services/product-type.service";

@Component({
  templateUrl: './edit-product-type.component.html'
})
export class EditProductTypeComponent implements OnInit {
  private readonly _productTypeService: ProductTypeService;
  private readonly _router: Router;
  private readonly _activatedRoute: ActivatedRoute;

  public producttype?: ProductType;

  constructor(
    productTypeService: ProductTypeService,
    router: Router,
    activatedRoute: ActivatedRoute
  ) {
    this._productTypeService = productTypeService;
    this._router = router;
    this._activatedRoute = activatedRoute
  }

  public ngOnInit(): void {
    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this._productTypeService.get(Number(id))
      .subscribe(producttype => {
        this.producttype = producttype;
      });
  }

  public updateProductType(): void {
    this._productTypeService.update(this.producttype!)
      .subscribe(() => {
        this._router.navigate(['producttypes']);
      });
  }
}
