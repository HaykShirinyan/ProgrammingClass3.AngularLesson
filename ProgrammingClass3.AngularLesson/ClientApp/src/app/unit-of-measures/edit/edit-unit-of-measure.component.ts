import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl: './edit-unit-of-measure.component.html'
})
export class EditUnitOfMeasureComponent implements OnInit {
  private readonly _unitOfMeasureService: UnitOfMeasureService;
  private readonly _router: Router;
  private readonly _activatedRoute: ActivatedRoute;

  public unitOfMeasure?: UnitOfMeasure;
  public isLoading: boolean = false;
  public spinnerText!: string;

  constructor(
    unitOfMeasureService: UnitOfMeasureService,
    router: Router,
    activatedRoute: ActivatedRoute
  ) {
    this._unitOfMeasureService = unitOfMeasureService;
    this._router = router;
    this._activatedRoute = activatedRoute;
  }

  public ngOnInit(): void {
    this.spinnerText = 'Loading unit of measure data...';
    this.isLoading = true;

    let id = this._activatedRoute.snapshot.paramMap.get('id');

    this._unitOfMeasureService.get(Number(id))
      .subscribe(unitOfMeasure => {
        this.unitOfMeasure = unitOfMeasure;
        this.isLoading = false;
      });
  }

  public updateUnitOfMeasure(): void {
    this.spinnerText = 'Editing unit of measure data...';
    this.isLoading = true;

    this._unitOfMeasureService.update(this.unitOfMeasure!)
      .subscribe(() => {
        this._router.navigate(['unit-of-measures']);
        this.isLoading = false;
      });
  }

  public cancelLoading(): void {
    this.isLoading = false;
  }
}
