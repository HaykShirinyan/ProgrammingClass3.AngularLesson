import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { UnitOfMeasure } from "../../shared/models/unitOfMeasure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl: './edit-unit-of-measure.component.html'
})
export class EditUnitOfMeasureComponent implements OnInit {
  private readonly _unitOfMeasureService: UnitOfMeasureService;
  private readonly _router: Router;
  private readonly _activatedRoute: ActivatedRoute;

  public unitofmeasure?: UnitOfMeasure;

  constructor(
    unitOfMeasureService: UnitOfMeasureService,
    router: Router,
    activatedRoute: ActivatedRoute
  ) {
    this._unitOfMeasureService = unitOfMeasureService;
    this._router = router;
    this._activatedRoute = activatedRoute
  }

  public async ngOnInit(): Promise<void> {
    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this.unitofmeasure = await this._unitOfMeasureService.get(Number(id));
  }

  public async updateUnitOfMeasure(): Promise<void> {
    await this._unitOfMeasureService.update(this.unitofmeasure!);
    this._router.navigate(['unitofmeasures']);
  }
}
