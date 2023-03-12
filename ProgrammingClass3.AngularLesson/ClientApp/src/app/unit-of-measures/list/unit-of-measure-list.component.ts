import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { UnitOfMeasure } from "../../shared/models/unitOfMeasure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";

@Component({
  templateUrl: './unit-of-measure-list.component.html'
})
export class UnitOfMeasureListComponent implements OnInit {
  private _unitOfMeasureService: UnitOfMeasureService;

  public unitofmeasures?: UnitOfMeasure[];
  public isLoading: boolean = false;
  

  constructor(unitOfMeasureService: UnitOfMeasureService) {
    this._unitOfMeasureService = unitOfMeasureService;
  }

  public ngOnInit(): void {
    this.isLoading = true;

    this._unitOfMeasureService.getAll()
      .subscribe(unitOfMeasures => {
        this.unitofmeasures = unitOfMeasures;
        this.isLoading = false;
        
      })
  }
  public cancelLoading(): void {
    this.isLoading = false;
  }
}
