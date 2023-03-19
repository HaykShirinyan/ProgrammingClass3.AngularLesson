import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthorizeGuard } from "../api-authorization/authorize.guard";
import { CounterComponent } from "./counter/counter.component";
import { FetchDataComponent } from "./fetch-data/fetch-data.component";
import { HomeComponent } from "./home/home.component";
import { ProductTypeComponent } from "./product-types/list/product-type-list.component";
import { ProductListComponent } from "./products/list/product-list.component";
import { UnitOfMeasureComponent } from "./unit-of-measure/list/unit-of-measure-list.component";
import {CreateProductComponent} from "./products/create/create-product.component";
import {CreateUnitOfMeasureComponent} from "./unit-of-measure/create/create-unit-of-measure.component";
import {CreateProductType} from "./product-types/create/create-product-type.component";
import {EditProductComponent} from "./products/edit/edit-product.component";
import {TicTacToeComponent} from "./tic-tac-toe/tic-tac-toe.component";


const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'counter', component: CounterComponent },
  { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthorizeGuard] },
  { path: 'products', component: ProductListComponent },
  { path: 'unit-of-measures', component: UnitOfMeasureComponent },
  { path: 'product-types', component: ProductTypeComponent },
  { path: 'products/create', component: CreateProductComponent },
  { path: 'unit-of-measures/create', component: CreateUnitOfMeasureComponent },
  { path: 'product-types/create', component: CreateProductType },
  { path: 'products/edit', component: EditProductComponent },
  { path: 'product-types/edit', component: EditProductComponent },
  { path: 'unit-of-measures/edit', component: EditProductComponent },
  { path: 'tic-tac-toe', component: TicTacToeComponent }
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
