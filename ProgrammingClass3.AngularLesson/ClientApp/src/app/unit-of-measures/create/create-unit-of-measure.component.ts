import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl: './create-unit-of-measure.component.html'
})
export class CreateUnitOfMeasureComponent {
  private readonly _unitOfMeasureService: UnitOfMeasureService;
  private readonly _router: Router;

  public unitOfMeasure: UnitOfMeasure = {};
  public isLoading: boolean = false;

  constructor(
    unitOfMeasureService: UnitOfMeasureService,
    router: Router
  ) {
    this._unitOfMeasureService = unitOfMeasureService;
    this._router = router;
  }

  public async createUnitOfMeasure(): Promise<void> {
    this.isLoading = true;

    await this._unitOfMeasureService.add(this.unitOfMeasure)
    
    this._router.navigate(['unit-of-measures']);
    this.isLoading = false;
  }

  public cancelLoading(): void {
    this.isLoading = false;
  }
}
