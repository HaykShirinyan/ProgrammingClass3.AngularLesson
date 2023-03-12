import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";
import { UnitOfMeasureService } from "../../shared/services/unit-of-measure.service";



@Component({
  templateUrl: './unit-of-measure-list.component.html'
})
export class UnitOfMeasureListComponent implements OnInit {
  private _unitofmeasureService!: UnitOfMeasureService;

  public unitofmeasures?: UnitOfMeasure[];
  public isLoading: boolean = false;

  constructor(unitOfMeasure: UnitOfMeasureService) {
    this._unitofmeasureService = unitOfMeasure;
  }

  public ngOnInit(): void {
    this.isLoading = true;

    this._unitofmeasureService.getAll()
      .subscribe(unitofmeasures => { 
        this.unitofmeasures = unitofmeasures;
        this.isLoading = false;
      }); 
  }
}
