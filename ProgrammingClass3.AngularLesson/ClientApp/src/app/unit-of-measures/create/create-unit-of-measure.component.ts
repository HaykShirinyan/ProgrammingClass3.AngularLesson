import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { UnitOfMeasure } from "../../shared/models/unitOfMeasure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl: './create-unit-of-measure.component.html'
})
export class CreateUnitOfMeasureComponent {
  private readonly _unitOfMeasureService: UnitOfMeasureService;
  private readonly _router: Router;

  public unitofmeasure: UnitOfMeasure = {};

  constructor(
    unitOfMeasureService: UnitOfMeasureService,
    router: Router
  ) {
    this._unitOfMeasureService = unitOfMeasureService;
    this._router = router;
  }

  public async createUnitOfMeasure(): Promise<void> {
    await this._unitOfMeasureService.add(this.unitofmeasure);
    this._router.navigate(['unit-of-measures']);
  }
}
