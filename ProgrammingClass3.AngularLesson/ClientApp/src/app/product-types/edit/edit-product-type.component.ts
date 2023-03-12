import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { ProductType } from "../../shared/models/product-type";
import { ProductTypeService } from "../../shared/services/product-type.service";

@Component({
  templateUrl: 'edit-product-type.component.html'
})
export class EditProductType implements OnInit {
  private _productTypeService: ProductTypeService;
  private _router: Router;
  private _activatedRoute: ActivatedRoute;

  public productType: ProductType = {};

  constructor(productTypeService: ProductTypeService,
    router: Router,
    activatedRoute: ActivatedRoute)
  {
    this._productTypeService = productTypeService
    this._router = router
    this._activatedRoute = activatedRoute
  }

  public ngOnInit(): void {
    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this._productTypeService.get(Number(id))
      .subscribe(productType => {
        this.productType = this.productType;
      });
  }

  public editProductType(): void {
    this._productTypeService.update(this.productType)
      .subscribe(() => {
        this._router.navigate(['product-types'])
      })
  }
}
