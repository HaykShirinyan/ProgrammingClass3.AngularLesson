import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { Product } from "../../shared/models/product";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl: './create-unit-of-measure.component.html'
})
export class CreateUnitOfMeasureComponent {
  private _unitOfMeasureService: UnitOfMeasureService;
  private _router: Router;

  public unitOfMeasure: UnitOfMeasure = {};

  constructor(unitOfMeasureService: UnitOfMeasureService,
    router: Router)
  {
    this._unitOfMeasureService = unitOfMeasureService;
    this._router = router;
  }

  public async createUnitOfMeasure(): Promise<void> {
    await this._unitOfMeasureService.add(this.unitOfMeasure);
    this._router.navigate(['unit-of-measures'])
  }
}
