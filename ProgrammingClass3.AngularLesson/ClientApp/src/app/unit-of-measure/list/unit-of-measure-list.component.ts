import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { UnitOfMeasure } from "../../shared/models/unit-of-measure";

@Component({
  templateUrl: './unit-of-measure-list.component.html'
})
export class UnitOfMeasureComponent implements OnInit {
  private _httpClient: HttpClient;

  public unitOfMeasures?: UnitOfMeasure[];

  constructor(httpClient: HttpClient) {
    this._httpClient = httpClient;
  }

  public ngOnInit(): void {
    this._httpClient.get<UnitOfMeasure[]>('api/unit-of-measures')
      .subscribe(unitOfMeasures => {
        this.unitOfMeasures = unitOfMeasures;
      });
  }
}
