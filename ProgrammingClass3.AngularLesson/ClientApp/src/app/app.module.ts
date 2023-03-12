import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ApiAuthorizationModule } from 'src/api-authorization/api-authorization.module';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';
import { AuthorizeInterceptor } from 'src/api-authorization/authorize.interceptor';
import { AppRoutingModule } from './app-routing.module';
import { ProductListComponent } from './products/list/product-list.component';
import { CreateProductComponent } from './products/create/create-product.component';
import { EditProductComponent } from './products/edit/edit-product.component';
import { ProductTypeListComponent } from './product-types/list/product-type-list.component';
import { UnitOfMeasureListComponent } from './unit-of-measures/list/unit-of-measure-list.component';
import { CreateProductTypeComponent } from './product-types/create/create-product-type.component';
import { EditProductTypeComponent } from './product-types/edit/edit-product-type.component';
import { CreateUnitOfMeasureComponent } from './unit-of-measures/create/create-unit-of-measure.component';
import { EditUnitOfMeasureComponent } from './unit-of-measures/edit/edit-unit-of-measure.component';
import { LoadingSpinnerComponent } from './shared/components/loading-spinner/loading-spinner.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ProductListComponent,
    CreateProductComponent,
    EditProductComponent,
    ProductTypeListComponent,
    UnitOfMeasureListComponent,
    CreateProductTypeComponent,
    EditProductTypeComponent,
    CreateUnitOfMeasureComponent,
    EditUnitOfMeasureComponent,
    EditProductComponent,
    LoadingSpinnerComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ApiAuthorizationModule,
    AppRoutingModule
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
