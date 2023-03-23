import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl:'./delete-unit-of-measure.component.html'
})
export class DeleteUnitOfMeasureComponent implements OnInit {
  private readonly _unitOfMeasureService: UnitOfMeasureService;
  private readonly _router: Router;
  private readonly _activatedRoute: ActivatedRoute;

  public unitOfMeasure?: UnitOfMeasure;
  public isLoading: boolean = false;
  public spinnerText!: string;

  constructor(
    unitOfMeasureService: UnitOfMeasureService,
    router: Router,
    activatedRoute: ActivatedRoute,
  ) {
    this._unitOfMeasureService = unitOfMeasureService;
    this._router = router;
    this._activatedRoute = activatedRoute;
  }

  public async ngOnInit(): Promise<void> {
    try {
      this.isLoading = true;
      this.spinnerText = 'Loading unit of measure data...';

      let id = this._activatedRoute.snapshot.paramMap.get('id');

      this.unitOfMeasure = await this._unitOfMeasureService.get(Number(id));

    } finally {
      this.isLoading = false;
    }
  }

  public async deleteUnitOfMeasure(): Promise<void> {
    try {
      this.isLoading = true;
      this.spinnerText = 'Deleting unit of measuring';

      await this._unitOfMeasureService.delete(this.unitOfMeasure!);

      this._router.navigate(['unit-of-measures']);
    } finally {
      this.isLoading = false;
    }
  }

  public cancelLoading(): void {
    this.isLoading = false;
  }
}
