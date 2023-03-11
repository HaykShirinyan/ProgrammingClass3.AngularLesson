import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@anguar/router";
import { Observable } from "rxjs";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";
import { UnitOfMeasureSrvice } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl: './edit-unit-of-measure.component.html'
})
export class EditUnitOfMeasure implements OnInit {
  public _unitOfMeasureService: UnitOfMeasureSrvice;
  public _router: Router;
  public _activatedRoute: ActivatedRoute;

  public unitOfMeasure: UnitOfMeasure = {};

  constructor(unitOfMeasureService: UnitOfMeasureService,
    router: Router,
    activatedRoute: ActivatedRoute)
  {
    this._unitOfMeasureService = unitOfMeasureService,
    this._router = router,
    this._activatedRoute = activatedRoute
  }

  public ngOnInit(): void {
    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this._unitOfMeasureService.get(Number(id))
      .subscribe(unitOfMeasure => {
        this.unitOfMeasure = unitOfMeasure;
      })
  }

  public editUnitOfMeasure(): void {
    this._unitOfMeasureService.update(this.unitOfMeasure)
      .subscribe(() => {
        this._router.navigate(['unit-of-measure']);
      })
  }
}


