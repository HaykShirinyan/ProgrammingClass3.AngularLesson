import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Route, Router } from "@angular/router";
import { ProductType } from "../../shared/models/product-type";
import { ProductTypeService } from "../../shared/services/product-type.service";

@Component({
  templateUrl: './edit-product-type.component.html'
})
export class EditProductTypeComponent implements OnInit {
  private readonly _productTypeService: ProductTypeService;
  private readonly _router: Router;
  private readonly _activatedRoute: ActivatedRoute;

  public productType?: ProductType;
  public isLoading: boolean = false;
  public spinnerText!: string;

  constructor(
    producTypeService: ProductTypeService,
    router: Router,
    activatedRoute: ActivatedRoute
  ) {
    this._productTypeService = producTypeService;
    this._router = router;
    this._activatedRoute = activatedRoute;
  }

  public ngOnInit(): void {
    this.spinnerText = 'Loading product Type data...';
    this.isLoading = true;

    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this._productTypeService.get(Number(id))
      .subscribe(productType => {
        this.productType = productType;
        this.isLoading = false;
      });
  }

  public updateProductType(): void {
    this.spinnerText = 'Editing product type data...';
    this.isLoading = true;

    this._productTypeService.update(this.productType!)
      .subscribe(() => {
        this._router.navigate(['product-types']);
        this.isLoading = false;
      });
  }

  public cancelLoading(): void {
    this.isLoading = false;
  }
}
