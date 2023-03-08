import { Component } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { ProductTypeService } from "../../../shared/services/product-type.service";
import { UnitOfMeasureService } from "../../../shared/services/unit-of-measure.service";


@Component({
  templateUrl: './edit-poduct-type.component.html'
})
export class EditProductTypeComponent {
  private readonly _producttypeService: ProductTypeService;
  private readonly _router: Router;
  private readonly _activatedRoute: ActivatedRoute;

  constructor(
    producttypeService: ProductTypeService
    router: Router,
    activatedRoute: ActivatedRoute
  ) {
    this._producttypeService = producttypeService;
    this._router = router;
    this._activatedRoute = activatedRoute
  }

  ngOnInit(): void {
    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this._producttypeService.get(Number(id))
      .subscribe(producttype => {
        this.producttype = producttype
      })

  }
}
