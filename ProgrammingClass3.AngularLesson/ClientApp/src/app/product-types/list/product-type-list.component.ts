import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { ProductType } from "../../shared/models/product-type";
import { ProductTypeService } from "../../shared/services/product-type.service";

@Component({
  templateUrl: './product-type-list.component.html'
})
export class ProductTypeComponent implements OnInit {
  private _productTypeService: ProductTypeService;

  public productTypes?: ProductType[];

  constructor(productTypeService: ProductTypeService) {
    this._productTypeService = productTypeService;
  }

  public ngOnInit(): void {
    this._productTypeService.getAll()
      .subscribe(productTypes => {
        this.productTypes = productTypes;
      });
  }
}
