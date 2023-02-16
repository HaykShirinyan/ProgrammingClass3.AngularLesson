import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { UnitOfMeasure } from "../../shared/models/unitOfMeasure";

@Component({
  templateUrl: './unitofmeasure-list.component.html'
})
export class UnitOfMeasureListComponent implements OnInit {
  private _httpClient: HttpClient;

  public unitOfMeasures?: UnitOfMeasure[];

  constructor(httpClient: HttpClient) {
    this._httpClient = httpClient;
  }

  public ngOnInit(): void {
    this._httpClient.get<UnitOfMeasure[]>('api/UnitOfMeasures')
      .subscribe(unitOfMeasures => {
        this.unitOfMeasures = unitOfMeasures;
      });
  }
}
