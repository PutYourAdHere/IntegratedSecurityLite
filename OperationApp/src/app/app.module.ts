import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { AdminLayoutComponent } from "./layouts/admin-layout/admin-layout.component";
import { OperatorLayoutComponent } from "./layouts/operator-layout/operator-layout.component";

import { NgbModule } from "@ng-bootstrap/ng-bootstrap";

import { AppRoutingModule } from './app-routing.module';
import { ComponentsModule } from "./components/components.module";

import { DashboardComponent } from "./pages/dashboard/dashboard.component";
import { MapComponent } from "./pages/map/map.component";
import { NotificationsComponent } from "./pages/notifications/notifications.component";
import { UserComponent } from "./pages/user/user.component";
import { TablesComponent } from "./pages/tables/tables.component";


@NgModule({
  imports: [
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    ComponentsModule,
    NgbModule,
    RouterModule,
    AppRoutingModule,
    ToastrModule.forRoot()
  ],
  declarations: [ 
    AppComponent, 
    AdminLayoutComponent, 
    OperatorLayoutComponent, 
    DashboardComponent,
    UserComponent,
    TablesComponent,
    NotificationsComponent,
    MapComponent,
   ],
  bootstrap: [AppComponent],
  providers: []
})

export class AppModule { }

