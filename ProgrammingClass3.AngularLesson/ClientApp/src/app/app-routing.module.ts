import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthorizeGuard } from "../api-authorization/authorize.guard";
import { CounterComponent } from "./counter/counter.component";
import { FetchDataComponent } from "./fetch-data/fetch-data.component";
import { HomeComponent } from "./home/home.component";
import { ProductListComponent } from "./products/list/product-list.component";
import { ProductTypeListComponent } from "./producttypes/list/producttype-list.component";
import { UnitOfMeasureListComponent } from "./unitofmeasures/list/unitofmeasure-list.component";


const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'counter', component: CounterComponent },
  { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthorizeGuard] },
  { path: 'products', component: ProductListComponent },
  { path: 'producttypes', component: ProductTypeListComponent },
  { path: 'unitOfMeasures', component: UnitOfMeasureListComponent }
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
