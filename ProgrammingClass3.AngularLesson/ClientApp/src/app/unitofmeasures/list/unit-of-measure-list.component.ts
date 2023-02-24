import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Unitofmeasure } from "../../shared/models/unit-of-measure";



@Component({
  templateUrl: './unit-of-measure-list.component.html'
})
export class UnitOfMeasureListComponent implements OnInit {
  private _httpClient: HttpClient;

  public unitofmeasures?: Unitofmeasure[];

  constructor(httpClient: HttpClient) {
    this._httpClient = httpClient;
  }

  public ngOnInit(): void {
    this._httpClient.get<Unitofmeasure[]>('api/unitofmeasures')
      .subscribe(unitofmeasures => {
        this.unitofmeasures = unitofmeasures;
      }); 
  }
}
