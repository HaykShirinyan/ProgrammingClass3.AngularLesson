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

  public async ngOnInit(): Promise<void> {
    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this.productType = await this._productTypeService.get(Number(id));
  }

  public async editProductType(): Promise<void> {
    await this._productTypeService.update(this.productType);
    this._router.navigate(['product-types'])
  }
}
