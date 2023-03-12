import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl: './edit-unit-of-measure.component.html'
})
export class EditUnitOfMeasureComponent implements OnInit {
  private readonly _unitofmeasureService: UnitOfMeasureService;
  private readonly _router: Router;
  private readonly _activatedRoute: ActivatedRoute;

  public unitofmeasure?: UnitOfMeasure;

  constructor(
    unitofmeasureService: UnitOfMeasureService,
    router: Router,
    activatedRoute: ActivatedRoute
  ) {
    this._unitofmeasureService = unitofmeasureService; 
    this._router = router;
    this._activatedRoute = activatedRoute
  }
    ngOnInit(): void {
      let id = this._activatedRoute.snapshot.paramMap.get('id');

      this._unitofmeasureService.get(Number(id))
        .subscribe(unitofmeasure => {
          this.unitofmeasure = unitofmeasure;
        })

    }
}
