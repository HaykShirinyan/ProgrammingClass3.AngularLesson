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
  public isLoading: boolean = false;

  constructor(productTypeService: ProductTypeService) {
    this._productTypeService = productTypeService;
  }

  public async ngOnInit(): Promise<void> {
    try {
      this.isLoading = true;

      this.productTypes = await this._productTypeService.getAll();

      this.isLoading = false;
    } finally {
      this.isLoading = false;
    }
  }

  public cancelLoading(): void {
    this.isLoading = false;
  }
}
