import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthorizeGuard } from "../api-authorization/authorize.guard";
import { CounterComponent } from "./counter/counter.component";
import { FetchDataComponent } from "./fetch-data/fetch-data.component";
import { HomeComponent } from "./home/home.component";
import { CreateProductTypeComponent } from "./product-types/create/create-product-type.component";
import { EditProductTypeComponent } from "./product-types/edit/edit-product-type-component";
import { ProductTypeListComponent } from "./product-types/list/product-type-list.component";
import { CreateProductComponent } from "./products/create/create-product.component";
import { EditProductComponent } from "./products/edit/edit-product.component";
import { ProductListComponent } from "./products/list/product-list.component";
import { CreateUnitOfMeasureComponent } from "./unit-of-measures/create/create-unit-of-measure.component";
import { EditUnitOfMeasureComponent } from "./unit-of-measures/edit/edit-unit-of-measure.component";
import { UnitOfMeasureListComponent } from "./unit-of-measures/list/unit-of-measure-list.component";


const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'counter', component: CounterComponent },
  { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthorizeGuard] },
  { path: 'products', component: ProductListComponent },
  { path: 'unitofmeasure', component: UnitOfMeasureListComponent },
  { path: 'producttype', component: ProductTypeListComponent },
  { path: 'products', component: ProductListComponent },
  { path: 'products/create', component: CreateProductComponent },
  { path: 'products/edit/:id', component: EditProductComponent },
  { path: 'produttypes/create', component: CreateProductTypeComponent },
  { path: 'unitofmeasure/create', component: CreateUnitOfMeasureComponent },
  { path: 'producttype/edit/:id', component: EditProductTypeComponent },
  { path: 'unitofmeasure/edit/:id', component: EditUnitOfMeasureComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {

}
