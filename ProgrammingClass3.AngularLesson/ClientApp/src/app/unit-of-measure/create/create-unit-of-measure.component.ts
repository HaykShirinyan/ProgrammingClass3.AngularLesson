import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { Product } from "../../shared/models/product";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";
import { UnitOfMasureSrvice } from "../../shared/services/product-type.service";

@Component({
  templateUrl: './create-unit-of-measure.component.html'
})
export class CreateUnitOfMeasureComponent {
  private _unitOfMeasureSrvice: UnitOfMasureSrvice;
  private _router: Router;

  public unitOfMeasure: UnitOfMasure = {};

  constructor(unitOfMeasureService: UnitOfMasureSrvice,
    router: Router)
  {
    this._unitOfMeasureSrvice = unitOfMeasureService;
    this._router = router;
  }

  public createUnitOfMeasure(): void {
    this._unitOfMeasureSrvice.add(this.unitOfMeasure)
      .subscribe(() => {
        this._router.navigate(['unit-of-measures'])
      });
  }
}
