import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { ProductType } from "../../shared/models/product-type";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl: './create-unit-of-measure.component.html'
})
export class CreateUnitOfMeasureComponent {
 private readonly _unitofmeasureService: UnitOfMeasureService;
  private readonly _router: Router;

  public unitOfMeasure: UnitOfMeasure = {}; 

  constructor(
    unitOfMeasureService: UnitOfMeasureService,
    router: Router 
  ) {
    this._unitofmeasureService = unitOfMeasureService;
    this._router = router;
  }

  public createUnitOfMeasure(): void {  
    this._unitofmeasureService.add(this.unitOfMeasure)
      .subscribe(() => {
        this._router.navigate(['unitOfMeasure']);
      });
  }
}
   
