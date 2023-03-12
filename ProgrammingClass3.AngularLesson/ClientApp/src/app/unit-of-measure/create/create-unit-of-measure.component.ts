import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { Product } from "../../shared/models/product";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl: './create-unit-of-measure.component.html'
})
export class CreateUnitOfMeasureComponent {
  private _unitOfMeasureSrvice: UnitOfMeasureService;
  private _router: Router;

  public unitOfMeasure: UnitOfMeasure = {};

  constructor(unitOfMeasureService: UnitOfMeasureService,
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
