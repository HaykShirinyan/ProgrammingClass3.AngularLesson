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
import { ProductTypeComponent } from './product-types/list/product-type-list.component';
import { CreateProductComponent } from './products/create/create-product.component';
import { CreateProductType } from './product-types/create/create-product-type.component';
import { EditProductComponent } from './products/edit/edit-product.component';
import { EditUnitOfMeasure } from './unit-of-measure/edit/edit-unit-of-measure.component';
import { EditProductType } from './product-types/edit/edit-product-type.component';
import { CreateUnitOfMeasureComponent } from './unit-of-measure/create/create-unit-of-measure.component';
import { LoadingSpinnerComponent } from './shared/components/loading-spinner/loading-spinner.component';
import { BackButtonComponent } from './back-button/back-button.component';
import { UnitOfMeasureComponent } from './unit-of-measure/list/unit-of-measure-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ProductListComponent,
    ProductTypeComponent,
    CreateProductComponent,
    CreateProductType,
    EditProductComponent,
    UnitOfMeasureComponent,
    EditUnitOfMeasure,
    EditProductType,
    CreateUnitOfMeasureComponent,
    LoadingSpinnerComponent,
    BackButtonComponent
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
