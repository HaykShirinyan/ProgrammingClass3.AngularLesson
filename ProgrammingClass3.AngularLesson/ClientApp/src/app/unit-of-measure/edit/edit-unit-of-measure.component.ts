import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Observable } from "rxjs";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl: './edit-unit-of-measure.component.html'
})
export class EditUnitOfMeasure implements OnInit {
  public _unitOfMeasureService: UnitOfMeasureService;
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

  public async ngOnInit(): Promise<void> {
    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this.unitOfMeasure = await this._unitOfMeasureService.get(Number(id));
  }

  public async editUnitOfMeasure(): Promise<void> {
    await this._unitOfMeasureService.update(this.unitOfMeasure);
    this._router.navigate(['unit-of-measure'])
  }
}
