import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { ProductType, } from "../../shared/models/product-type";
import { ProductTypeService } from "../../shared/services/product-type.service";



@Component({
  templateUrl: './product-type-list.component.html'
})
export class ProductTypeListComponent implements OnInit {
  private _producttypeService!: ProductTypeService;

  public producttypes?: ProductType[];

  constructor(productTypeService: ProductTypeService) {
    this._producttypeService = productTypeService;
  }

  public ngOnInit(): void {
    this._producttypeService.getAll()
      .subscribe(producttypes => { 
        this.producttypes = producttypes;
      })
  }
}
