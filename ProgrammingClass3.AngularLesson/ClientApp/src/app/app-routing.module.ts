import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthorizeGuard } from "../api-authorization/authorize.guard";
import { CounterComponent } from "./counter/counter.component";
import { FetchDataComponent } from "./fetch-data/fetch-data.component";
import { HomeComponent } from "./home/home.component";
import { CreateProductTypeComponent } from "./product-types/create/create-product-type.component";
import { CreateProductComponent } from "./products/create/create-product.component";
import { EditProductComponent } from "./products/edit/edit-product.component";
import { ProductListComponent } from "./products/list/product-list.component";
import { UnitOfMeasureListComponent } from "./unit-of-measures/list/unit-of-measure-list.component";


const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'counter', component: CounterComponent },
  { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthorizeGuard] },
  { path: 'products', component: ProductListComponent },
  { path: 'products/create', component: CreateProductComponent },
  { path: 'products/edit/:id', component: EditProductComponent },
  { path: 'product-types/create', component: CreateProductTypeComponent }
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
